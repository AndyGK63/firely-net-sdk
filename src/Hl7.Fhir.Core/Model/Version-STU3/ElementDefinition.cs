﻿/* 
 * Copyright (c) 2016, Furore (info@furore.com) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/ewoutkramer/fhir-net-api/master/LICENSE
 */


using Hl7.Fhir.Introspection;
using System;
using System.Diagnostics;
using System.Text;

namespace Hl7.Fhir.Model.STU3
{
    // http://blogs.msdn.com/b/jaredpar/archive/2011/03/18/debuggerdisplay-attribute-best-practices.aspx
    [DebuggerDisplay(@"\{{DebuggerDisplay,nq}}")]
    public partial class ElementDefinition
    {
        public ElementDefinition()
        {

        }

        public ElementDefinition(string path)
        {
            Path = path;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [NotMapped]
        string DebuggerDisplay
        {
            get {
                StringBuilder sb = new StringBuilder(128);
                // sb.AppendFormat("Path='{0}'", Path);
                // if (Name != null) { sb.AppendFormat(" Name='{0}'", Name); }
                sb.Append(Path);
                if (SliceName != null)
                {
                    sb.Append(":");
                    sb.Append(SliceName);
                }
                return sb.ToString();
            }
        }
    }
}
