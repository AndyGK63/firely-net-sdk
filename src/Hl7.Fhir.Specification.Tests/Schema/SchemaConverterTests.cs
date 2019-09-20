﻿using Hl7.Fhir.ElementModel;
using Hl7.Fhir.FhirPath;
using Hl7.Fhir.Model;
using Hl7.Fhir.Specification.Source;
using Hl7.Fhir.Specification.Specification.Source;
using Hl7.Fhir.Validation.Schema;
using Hl7.FhirPath;
using Hl7.FhirPath.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Hl7.Fhir.Specification.Tests.Schema
{
    [TestClass]
    public class SchemaConverterTests
    {
        readonly ISchemaResolver _resolver;
        readonly FhirPathCompiler _fpCompiler;

        public SchemaConverterTests()
        {
            _resolver = new ElementSchemaResolver(
                new CachedResolver(
                    new MultiResolver(
                        new ZipSource("specification.zip"),
                        new DirectorySource(@"C:\Users\Marco\Downloads")
                    )
                ));

            var symbolTable = new SymbolTable();
            symbolTable.AddStandardFP();
            symbolTable.AddFhirExtensions();
            _fpCompiler = new FhirPathCompiler(symbolTable);
        }

        private string BigString()
        {
            var sb = new StringBuilder(1024 * 1024);
            for (int i = 0; i < 1024; i++)
            {
                sb.Append("x");
            }

            var sub = sb.ToString();

            sb = new StringBuilder(1024 * 1024);
            for (int i = 0; i < 1024; i++)
            {
                sb.Append(sub);
            }
            sb.Append("more");
            return sb.ToString();
        }


        [TestMethod]
        public void MyTestMethod()
        {

            var poco = new Patient() { Name = new List<HumanName>() { new HumanName() { Family = BigString() } } };
            var patient = poco.ToTypedElement();

            var schemaElement = _resolver.GetSchema(new Uri("http://hl7.org/fhir/StructureDefinition/Patient", UriKind.Absolute));
            var results = schemaElement.Validate(new[] { patient }, new ValidationContext());
            Assert.IsNotNull(results);
            Assert.AreEqual(1, results.Count);
            Assert.AreEqual(0, results[0].Item1.Count);
            var json = schemaElement.ToJson().ToString();
            Debug.WriteLine(json);
            //json.ToString(); 

        }

        private string TypedElementAsString(ITypedElement element)
        {
            var json = BuildNode(element);
            return json.ToString();

            JToken BuildNode(ITypedElement elt)
            {
                var result = new JObject
                {
                    { "name", elt.Name },
                    { "type", elt.InstanceType },
                    { "location", elt.Location},
                    { "value", elt.Value?.ToString()},
                    { "definition", elt.Definition == null ? "" : DefintionNode(elt.Definition) }
                };
                result.Add(new JProperty("children", new JArray(elt.Children().Select(c =>
                  BuildNode(c).MakeNestedProp()))));


                return result;
            }

            JToken DefintionNode(IElementDefinitionSummary def)
            {
                var result = new JObject
                {
                    { "elementName", def.ElementName },
                    { "inSummary", def.InSummary },
                    { "isChoiceElement", def.IsChoiceElement },
                    { "isCollection", def.IsCollection },
                    { "isRequired", def.IsRequired },
                    { "isResource", def.IsResource },
                    { "nonDefaultNamespace", def.NonDefaultNamespace },
                    { "order", def.Order }
                };
                return result;
            }

        }

        [TestMethod]
        public void MyTestMethod2()
        {
            var poco = new HumanName() { Family = BigString() };
            poco.GivenElement.Add(new FhirString(BigString()));
            poco.GivenElement.Add(new FhirString("Maria"));
            poco.Use = HumanName.NameUse.Usual;
            var element = poco.ToTypedElement();

            var eltstring = TypedElementAsString(new ValueTypedElement(element));

            var schemaElement = _resolver.GetSchema(new Uri("http://hl7.org/fhir/StructureDefinition/HumanName", UriKind.Absolute));

            //var json = schemaElement.ToJson().ToString();

            var results = schemaElement.Validate(new[] { element }, new ValidationContext());
            Assert.IsNotNull(results);
            Assert.AreEqual(1, results.Count);
            var assertResult = results[0].Item1.Result;
            Assert.IsNotNull(assertResult);
            Assert.IsFalse(assertResult.IsSuccessful, "HumanName is not valid");

            /*
            string json2 = "";
            foreach (var item in _resolver.GetSchemas())
            {
                json2 = item.ToJson().ToString();
            }
            _resolver.GetSchemas().Select(s => json2 += s.ToJson().ToString());

            var stringSchema = _resolver.GetSchema(new Uri("http://hl7.org/fhir/StructureDefinition/string", UriKind.Absolute));
            json = stringSchema.ToJson().ToString();

            Debug.WriteLine(json);
            //json.ToString();
            */
        }
        [TestMethod]
        public void TestInstance()
        {
            var instantSchema = _resolver.GetSchema(new Uri("http://hl7.org/fhir/StructureDefinition/instant", UriKind.Absolute));

            var instantPoco = new Instant(DateTimeOffset.Now);

            var element = instantPoco.ToTypedElement();

            var result = instantSchema.Validate(new[] { element }, new ValidationContext() { FhirPathCompiler = _fpCompiler });

            Assert.IsTrue(result[0].Item1.Result.IsSuccessful);
        }

        [TestMethod]
        public void ValidateMaxStringonFhirString()
        {
            var fhirString = new FhirString(BigString()).ToTypedElement();

            var stringSchema = _resolver.GetSchema(new Uri("http://hl7.org/fhir/StructureDefinition/string", UriKind.Absolute));

            var results = stringSchema.Validate(new[] { fhirString }, new ValidationContext());

            Assert.IsNotNull(results);
            Assert.AreEqual(1, results.Count);
            var assertResult = results[0].Item1.Result;
            Assert.IsNotNull(assertResult);
            Assert.IsFalse(assertResult.IsSuccessful, "fhirString is not valid");
        }

        [TestMethod]
        public void ValidateOwnProfile()
        {


            var stringSchema = _resolver.GetSchema(new Uri("http://example.org/fhir/StructureDefinition/MyHumanName", UriKind.Absolute));

            var json = stringSchema.ToJson().ToString();

            var poco = new HumanName() { Family = "Visser" };
            poco.Period = new Period(new FhirDateTime("2019-09-02"), new FhirDateTime("2019-09-05"));
            poco.GivenElement.Add(new FhirString(BigString()));
            poco.GivenElement.Add(new FhirString("Maria"));

            var results = stringSchema.Validate(new[] { poco.ToTypedElement() }, new ValidationContext() { FhirPathCompiler = _fpCompiler });

            Assert.IsNotNull(results);
            Assert.IsTrue(results.Count > 0);
            var assertResult = results[0].Item1.Result;
            Assert.IsNotNull(assertResult);
            Assert.IsFalse(assertResult.IsSuccessful, "poco should be not valid");
        }

    }

    public class ValueTypedElement : ITypedElement
    {
        private readonly ITypedElement _wrapped;

        public ValueTypedElement(ITypedElement instance)
        {
            _wrapped = instance;
        }

        public string Name => _wrapped.Name;

        public string InstanceType => _wrapped.InstanceType;

        public object Value => _wrapped.Value;

        public string Location => _wrapped.Location;

        public IElementDefinitionSummary Definition => _wrapped.Definition;

        public IEnumerable<ITypedElement> Children(string name = null)
        {
            foreach (var child in _wrapped.Children())
            {
                yield return new ValueTypedElement(child);

            }
            if (_wrapped.InstanceType == "string")
            {
                yield return new ValueElementNode(_wrapped.Value, _wrapped.Location);
            }
        }
    }
}
