﻿/*
* Copyright (c) 2014, Firely (info@fire.ly) and contributors
* See the file CONTRIBUTORS for details.
*
* This file is licensed under the BSD 3-Clause license
* available at https://raw.githubusercontent.com/FirelyTeam/firely-net-sdk/master/LICENSE
*/

using Hl7.Fhir.Model;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;


namespace Hl7.Fhir.Rest
{
    public class FhirClient : BaseFhirClient
    {
        /// <summary>
        /// Creates a new client using a default endpoint
        /// If the endpoint does not end with a slash (/), it will be added.
        /// </summary>
        /// <remarks>
        /// If the messageHandler is provided then it must be disposed by the caller
        /// </remarks>
        /// <param name="endpoint">
        /// The URL of the server to connect to.<br/>
        /// If the trailing '/' is not present, then it will be appended automatically
        /// </param>
        /// <param name="settings"></param>
        /// <param name="messageHandler"></param>
        public FhirClient(Uri endpoint, FhirClientSettings settings = null, HttpMessageHandler messageHandler = null)
            : base(endpoint, ModelInfo.ModelInspector, ModelInfo.Version, settings)
        {
            // If user does not supply message handler, create our own and add decompression strategy in default handler.
            var handler = messageHandler ?? new HttpClientHandler()
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            };

            HttpClientRequester requester = new HttpClientRequester(Endpoint, Settings, handler, messageHandler == null);
            Requester = requester;

            // Expose default request headers to user.
            RequestHeaders = requester.Client.DefaultRequestHeaders;
        }

        /// <summary>
        /// Creates a new client using a default endpoint
        /// If the endpoint does not end with a slash (/), it will be added.
        /// </summary>
        /// <remarks>
        /// The httpClient must be disposed by the caller
        /// </remarks>
        /// <param name="endpoint">
        /// The URL of the server to connect to.<br/>
        /// If the trailing '/' is not present, then it will be appended automatically
        /// </param>
        /// <param name="settings"></param>
        /// <param name="httpClient"></param>
        public FhirClient(Uri endpoint, HttpClient httpClient, FhirClientSettings settings = null)
            : base(endpoint, ModelInfo.ModelInspector, ModelInfo.Version, settings)
        {
            HttpClientRequester requester = new HttpClientRequester(Endpoint, Settings, httpClient);
            Requester = requester;

            // Expose default request headers to user.
            RequestHeaders = requester.Client.DefaultRequestHeaders;
        }

        /// <summary>
        /// Creates a new client using a default endpoint
        /// If the endpoint does not end with a slash (/), it will be added.
        /// </summary>
        /// <remarks>
        /// If the messageHandler is provided then it must be disposed by the caller
        /// </remarks>
        /// <param name="endpoint">
        /// The URL of the server to connect to.<br/>
        /// If the trailing '/' is not present, then it will be appended automatically
        /// </param>
        /// <param name="settings"></param>
        /// <param name="messageHandler"></param>
        public FhirClient(string endpoint, FhirClientSettings settings = null, HttpMessageHandler messageHandler = null)
            : this(new Uri(endpoint), settings, messageHandler)
        {
        }

        /// <summary>
        /// Creates a new client using a default endpoint
        /// If the endpoint does not end with a slash (/), it will be added.
        /// </summary>
        /// <remarks>
        /// The httpClient must be disposed by the caller
        /// </remarks>
        /// <param name="endpoint">
        /// The URL of the server to connect to.<br/>
        /// If the trailing '/' is not present, then it will be appended automatically
        /// </param>
        /// <param name="settings"></param>
        /// <param name="httpClient"></param>
        public FhirClient(string endpoint, HttpClient httpClient, FhirClientSettings settings = null)
            : this(new Uri(endpoint), httpClient, settings)
        {
        }

        /// <summary>
        /// Default request headers that can be modified to persist default headers to internal client.
        /// </summary>
        public HttpRequestHeaders RequestHeaders { get; protected set; }

        /// <summary>
        /// Override dispose in order to clean up request headers tied to disposed requester.
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this.RequestHeaders = null;
                    base.Dispose(disposing);
                }

                disposedValue = true;
            }
        }
    }
}
