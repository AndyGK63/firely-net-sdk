﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Utility;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  

*/

#pragma warning disable 1591 // suppress XML summary warnings 

//
// Generated for FHIR v4.2.0
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// Definition of an observation
    /// </summary>
    [FhirType("ObservationDefinition", IsResource=true)]
    [DataContract]
    public partial class ObservationDefinition : Hl7.Fhir.Model.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ObservationDefinition; } }
        [NotMapped]
        public override string TypeName { get { return "ObservationDefinition"; } }
        
        /// <summary>
        /// Permitted data type for observation value.
        /// (url: http://hl7.org/fhir/ValueSet/permitted-data-type)
        /// </summary>
        [FhirEnumeration("ObservationDataType")]
        public enum ObservationDataType
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/permitted-data-type)
            /// </summary>
            [EnumLiteral("Quantity", "http://hl7.org/fhir/permitted-data-type"), Description("Quantity")]
            Quantity,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/permitted-data-type)
            /// </summary>
            [EnumLiteral("CodeableConcept", "http://hl7.org/fhir/permitted-data-type"), Description("CodeableConcept")]
            CodeableConcept,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/permitted-data-type)
            /// </summary>
            [EnumLiteral("string", "http://hl7.org/fhir/permitted-data-type"), Description("string")]
            String,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/permitted-data-type)
            /// </summary>
            [EnumLiteral("boolean", "http://hl7.org/fhir/permitted-data-type"), Description("boolean")]
            Boolean,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/permitted-data-type)
            /// </summary>
            [EnumLiteral("integer", "http://hl7.org/fhir/permitted-data-type"), Description("integer")]
            Integer,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/permitted-data-type)
            /// </summary>
            [EnumLiteral("Range", "http://hl7.org/fhir/permitted-data-type"), Description("Range")]
            Range,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/permitted-data-type)
            /// </summary>
            [EnumLiteral("Ratio", "http://hl7.org/fhir/permitted-data-type"), Description("Ratio")]
            Ratio,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/permitted-data-type)
            /// </summary>
            [EnumLiteral("SampledData", "http://hl7.org/fhir/permitted-data-type"), Description("SampledData")]
            SampledData,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/permitted-data-type)
            /// </summary>
            [EnumLiteral("time", "http://hl7.org/fhir/permitted-data-type"), Description("time")]
            Time,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/permitted-data-type)
            /// </summary>
            [EnumLiteral("dateTime", "http://hl7.org/fhir/permitted-data-type"), Description("dateTime")]
            DateTime,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/permitted-data-type)
            /// </summary>
            [EnumLiteral("Period", "http://hl7.org/fhir/permitted-data-type"), Description("Period")]
            Period,
        }

        /// <summary>
        /// Codes identifying the category of observation range.
        /// (url: http://hl7.org/fhir/ValueSet/observation-range-category)
        /// </summary>
        [FhirEnumeration("ObservationRangeCategory")]
        public enum ObservationRangeCategory
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/observation-range-category)
            /// </summary>
            [EnumLiteral("reference", "http://hl7.org/fhir/observation-range-category"), Description("reference range")]
            Reference,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/observation-range-category)
            /// </summary>
            [EnumLiteral("critical", "http://hl7.org/fhir/observation-range-category"), Description("critical range")]
            Critical,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/observation-range-category)
            /// </summary>
            [EnumLiteral("absolute", "http://hl7.org/fhir/observation-range-category"), Description("absolute range")]
            Absolute,
        }

        [FhirType("QuantitativeDetailsComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class QuantitativeDetailsComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "QuantitativeDetailsComponent"; } }
            
            /// <summary>
            /// Customary unit for quantitative results
            /// </summary>
            [FhirElement("customaryUnit", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept CustomaryUnit
            {
                get { return _CustomaryUnit; }
                set { _CustomaryUnit = value; OnPropertyChanged("CustomaryUnit"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _CustomaryUnit;
            
            /// <summary>
            /// SI unit for quantitative results
            /// </summary>
            [FhirElement("unit", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Unit
            {
                get { return _Unit; }
                set { _Unit = value; OnPropertyChanged("Unit"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Unit;
            
            /// <summary>
            /// SI to Customary unit conversion factor
            /// </summary>
            [FhirElement("conversionFactor", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.FhirDecimal ConversionFactorElement
            {
                get { return _ConversionFactorElement; }
                set { _ConversionFactorElement = value; OnPropertyChanged("ConversionFactorElement"); }
            }
            
            private Hl7.Fhir.Model.FhirDecimal _ConversionFactorElement;
            
            /// <summary>
            /// SI to Customary unit conversion factor
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public decimal? ConversionFactor
            {
                get { return ConversionFactorElement != null ? ConversionFactorElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        ConversionFactorElement = null; 
                    else
                        ConversionFactorElement = new Hl7.Fhir.Model.FhirDecimal(value);
                    OnPropertyChanged("ConversionFactor");
                }
            }
            
            /// <summary>
            /// Decimal precision of observation quantitative results
            /// </summary>
            [FhirElement("decimalPrecision", Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.Integer DecimalPrecisionElement
            {
                get { return _DecimalPrecisionElement; }
                set { _DecimalPrecisionElement = value; OnPropertyChanged("DecimalPrecisionElement"); }
            }
            
            private Hl7.Fhir.Model.Integer _DecimalPrecisionElement;
            
            /// <summary>
            /// Decimal precision of observation quantitative results
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public int? DecimalPrecision
            {
                get { return DecimalPrecisionElement != null ? DecimalPrecisionElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        DecimalPrecisionElement = null; 
                    else
                        DecimalPrecisionElement = new Hl7.Fhir.Model.Integer(value);
                    OnPropertyChanged("DecimalPrecision");
                }
            }
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as QuantitativeDetailsComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(CustomaryUnit != null) dest.CustomaryUnit = (Hl7.Fhir.Model.CodeableConcept)CustomaryUnit.DeepCopy();
                    if(Unit != null) dest.Unit = (Hl7.Fhir.Model.CodeableConcept)Unit.DeepCopy();
                    if(ConversionFactorElement != null) dest.ConversionFactorElement = (Hl7.Fhir.Model.FhirDecimal)ConversionFactorElement.DeepCopy();
                    if(DecimalPrecisionElement != null) dest.DecimalPrecisionElement = (Hl7.Fhir.Model.Integer)DecimalPrecisionElement.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new QuantitativeDetailsComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as QuantitativeDetailsComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(CustomaryUnit, otherT.CustomaryUnit)) return false;
                if( !DeepComparable.Matches(Unit, otherT.Unit)) return false;
                if( !DeepComparable.Matches(ConversionFactorElement, otherT.ConversionFactorElement)) return false;
                if( !DeepComparable.Matches(DecimalPrecisionElement, otherT.DecimalPrecisionElement)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as QuantitativeDetailsComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(CustomaryUnit, otherT.CustomaryUnit)) return false;
                if( !DeepComparable.IsExactly(Unit, otherT.Unit)) return false;
                if( !DeepComparable.IsExactly(ConversionFactorElement, otherT.ConversionFactorElement)) return false;
                if( !DeepComparable.IsExactly(DecimalPrecisionElement, otherT.DecimalPrecisionElement)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (CustomaryUnit != null) yield return CustomaryUnit;
                    if (Unit != null) yield return Unit;
                    if (ConversionFactorElement != null) yield return ConversionFactorElement;
                    if (DecimalPrecisionElement != null) yield return DecimalPrecisionElement;
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (CustomaryUnit != null) yield return new ElementValue("customaryUnit", CustomaryUnit);
                    if (Unit != null) yield return new ElementValue("unit", Unit);
                    if (ConversionFactorElement != null) yield return new ElementValue("conversionFactor", ConversionFactorElement);
                    if (DecimalPrecisionElement != null) yield return new ElementValue("decimalPrecision", DecimalPrecisionElement);
                }
            }

            
        }
        
        
        [FhirType("QualifiedIntervalComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class QualifiedIntervalComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "QualifiedIntervalComponent"; } }
            
            /// <summary>
            /// reference | critical | absolute
            /// </summary>
            [FhirElement("category", Order=40)]
            [DataMember]
            public Code<Hl7.Fhir.Model.ObservationDefinition.ObservationRangeCategory> CategoryElement
            {
                get { return _CategoryElement; }
                set { _CategoryElement = value; OnPropertyChanged("CategoryElement"); }
            }
            
            private Code<Hl7.Fhir.Model.ObservationDefinition.ObservationRangeCategory> _CategoryElement;
            
            /// <summary>
            /// reference | critical | absolute
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public Hl7.Fhir.Model.ObservationDefinition.ObservationRangeCategory? Category
            {
                get { return CategoryElement != null ? CategoryElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        CategoryElement = null; 
                    else
                        CategoryElement = new Code<Hl7.Fhir.Model.ObservationDefinition.ObservationRangeCategory>(value);
                    OnPropertyChanged("Category");
                }
            }
            
            /// <summary>
            /// The interval itself, for continuous or ordinal observations
            /// </summary>
            [FhirElement("range", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.Range Range
            {
                get { return _Range; }
                set { _Range = value; OnPropertyChanged("Range"); }
            }
            
            private Hl7.Fhir.Model.Range _Range;
            
            /// <summary>
            /// Range context qualifier
            /// </summary>
            [FhirElement("context", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Context
            {
                get { return _Context; }
                set { _Context = value; OnPropertyChanged("Context"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Context;
            
            /// <summary>
            /// Targetted population of the range
            /// </summary>
            [FhirElement("appliesTo", Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.CodeableConcept> AppliesTo
            {
                get { if(_AppliesTo==null) _AppliesTo = new List<Hl7.Fhir.Model.CodeableConcept>(); return _AppliesTo; }
                set { _AppliesTo = value; OnPropertyChanged("AppliesTo"); }
            }
            
            private List<Hl7.Fhir.Model.CodeableConcept> _AppliesTo;
            
            /// <summary>
            /// male | female | other | unknown
            /// </summary>
            [FhirElement("gender", Order=80)]
            [DataMember]
            public Code<Hl7.Fhir.Model.AdministrativeGender> GenderElement
            {
                get { return _GenderElement; }
                set { _GenderElement = value; OnPropertyChanged("GenderElement"); }
            }
            
            private Code<Hl7.Fhir.Model.AdministrativeGender> _GenderElement;
            
            /// <summary>
            /// male | female | other | unknown
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public Hl7.Fhir.Model.AdministrativeGender? Gender
            {
                get { return GenderElement != null ? GenderElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        GenderElement = null; 
                    else
                        GenderElement = new Code<Hl7.Fhir.Model.AdministrativeGender>(value);
                    OnPropertyChanged("Gender");
                }
            }
            
            /// <summary>
            /// Applicable age range, if relevant
            /// </summary>
            [FhirElement("age", Order=90)]
            [DataMember]
            public Hl7.Fhir.Model.Range Age
            {
                get { return _Age; }
                set { _Age = value; OnPropertyChanged("Age"); }
            }
            
            private Hl7.Fhir.Model.Range _Age;
            
            /// <summary>
            /// Applicable gestational age range, if relevant
            /// </summary>
            [FhirElement("gestationalAge", Order=100)]
            [DataMember]
            public Hl7.Fhir.Model.Range GestationalAge
            {
                get { return _GestationalAge; }
                set { _GestationalAge = value; OnPropertyChanged("GestationalAge"); }
            }
            
            private Hl7.Fhir.Model.Range _GestationalAge;
            
            /// <summary>
            /// Condition associated with the reference range
            /// </summary>
            [FhirElement("condition", Order=110)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString ConditionElement
            {
                get { return _ConditionElement; }
                set { _ConditionElement = value; OnPropertyChanged("ConditionElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _ConditionElement;
            
            /// <summary>
            /// Condition associated with the reference range
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Condition
            {
                get { return ConditionElement != null ? ConditionElement.Value : null; }
                set
                {
                    if (value == null)
                        ConditionElement = null; 
                    else
                        ConditionElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Condition");
                }
            }
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as QualifiedIntervalComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(CategoryElement != null) dest.CategoryElement = (Code<Hl7.Fhir.Model.ObservationDefinition.ObservationRangeCategory>)CategoryElement.DeepCopy();
                    if(Range != null) dest.Range = (Hl7.Fhir.Model.Range)Range.DeepCopy();
                    if(Context != null) dest.Context = (Hl7.Fhir.Model.CodeableConcept)Context.DeepCopy();
                    if(AppliesTo != null) dest.AppliesTo = new List<Hl7.Fhir.Model.CodeableConcept>(AppliesTo.DeepCopy());
                    if(GenderElement != null) dest.GenderElement = (Code<Hl7.Fhir.Model.AdministrativeGender>)GenderElement.DeepCopy();
                    if(Age != null) dest.Age = (Hl7.Fhir.Model.Range)Age.DeepCopy();
                    if(GestationalAge != null) dest.GestationalAge = (Hl7.Fhir.Model.Range)GestationalAge.DeepCopy();
                    if(ConditionElement != null) dest.ConditionElement = (Hl7.Fhir.Model.FhirString)ConditionElement.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new QualifiedIntervalComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as QualifiedIntervalComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(CategoryElement, otherT.CategoryElement)) return false;
                if( !DeepComparable.Matches(Range, otherT.Range)) return false;
                if( !DeepComparable.Matches(Context, otherT.Context)) return false;
                if( !DeepComparable.Matches(AppliesTo, otherT.AppliesTo)) return false;
                if( !DeepComparable.Matches(GenderElement, otherT.GenderElement)) return false;
                if( !DeepComparable.Matches(Age, otherT.Age)) return false;
                if( !DeepComparable.Matches(GestationalAge, otherT.GestationalAge)) return false;
                if( !DeepComparable.Matches(ConditionElement, otherT.ConditionElement)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as QualifiedIntervalComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(CategoryElement, otherT.CategoryElement)) return false;
                if( !DeepComparable.IsExactly(Range, otherT.Range)) return false;
                if( !DeepComparable.IsExactly(Context, otherT.Context)) return false;
                if( !DeepComparable.IsExactly(AppliesTo, otherT.AppliesTo)) return false;
                if( !DeepComparable.IsExactly(GenderElement, otherT.GenderElement)) return false;
                if( !DeepComparable.IsExactly(Age, otherT.Age)) return false;
                if( !DeepComparable.IsExactly(GestationalAge, otherT.GestationalAge)) return false;
                if( !DeepComparable.IsExactly(ConditionElement, otherT.ConditionElement)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (CategoryElement != null) yield return CategoryElement;
                    if (Range != null) yield return Range;
                    if (Context != null) yield return Context;
                    foreach (var elem in AppliesTo) { if (elem != null) yield return elem; }
                    if (GenderElement != null) yield return GenderElement;
                    if (Age != null) yield return Age;
                    if (GestationalAge != null) yield return GestationalAge;
                    if (ConditionElement != null) yield return ConditionElement;
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (CategoryElement != null) yield return new ElementValue("category", CategoryElement);
                    if (Range != null) yield return new ElementValue("range", Range);
                    if (Context != null) yield return new ElementValue("context", Context);
                    foreach (var elem in AppliesTo) { if (elem != null) yield return new ElementValue("appliesTo", elem); }
                    if (GenderElement != null) yield return new ElementValue("gender", GenderElement);
                    if (Age != null) yield return new ElementValue("age", Age);
                    if (GestationalAge != null) yield return new ElementValue("gestationalAge", GestationalAge);
                    if (ConditionElement != null) yield return new ElementValue("condition", ConditionElement);
                }
            }

            
        }
        
        
        [FhirType("ComponentComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class ComponentComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ComponentComponent"; } }
            
            /// <summary>
            /// Type of observation
            /// </summary>
            [FhirElement("code", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Code
            {
                get { return _Code; }
                set { _Code = value; OnPropertyChanged("Code"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Code;
            
            /// <summary>
            /// Quantity | CodeableConcept | string | boolean | integer | Range | Ratio | SampledData | time | dateTime | Period
            /// </summary>
            [FhirElement("permittedDataType", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Code<Hl7.Fhir.Model.ObservationDefinition.ObservationDataType>> PermittedDataTypeElement
            {
                get { if(_PermittedDataTypeElement==null) _PermittedDataTypeElement = new List<Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ObservationDefinition.ObservationDataType>>(); return _PermittedDataTypeElement; }
                set { _PermittedDataTypeElement = value; OnPropertyChanged("PermittedDataTypeElement"); }
            }
            
            private List<Code<Hl7.Fhir.Model.ObservationDefinition.ObservationDataType>> _PermittedDataTypeElement;
            
            /// <summary>
            /// Quantity | CodeableConcept | string | boolean | integer | Range | Ratio | SampledData | time | dateTime | Period
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<Hl7.Fhir.Model.ObservationDefinition.ObservationDataType?> PermittedDataType
            {
                get { return PermittedDataTypeElement != null ? PermittedDataTypeElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        PermittedDataTypeElement = null; 
                    else
                        PermittedDataTypeElement = new List<Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ObservationDefinition.ObservationDataType>>(value.Select(elem=>new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ObservationDefinition.ObservationDataType>(elem)));
                    OnPropertyChanged("PermittedDataType");
                }
            }
            
            /// <summary>
            /// Quantitative details
            /// </summary>
            [FhirElement("quantitativeDetails", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.ObservationDefinition.QuantitativeDetailsComponent QuantitativeDetails
            {
                get { return _QuantitativeDetails; }
                set { _QuantitativeDetails = value; OnPropertyChanged("QuantitativeDetails"); }
            }
            
            private Hl7.Fhir.Model.ObservationDefinition.QuantitativeDetailsComponent _QuantitativeDetails;
            
            /// <summary>
            /// Qualified interval
            /// </summary>
            [FhirElement("qualifiedInterval", Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.ObservationDefinition.QualifiedIntervalComponent> QualifiedInterval
            {
                get { if(_QualifiedInterval==null) _QualifiedInterval = new List<Hl7.Fhir.Model.ObservationDefinition.QualifiedIntervalComponent>(); return _QualifiedInterval; }
                set { _QualifiedInterval = value; OnPropertyChanged("QualifiedInterval"); }
            }
            
            private List<Hl7.Fhir.Model.ObservationDefinition.QualifiedIntervalComponent> _QualifiedInterval;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ComponentComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Code != null) dest.Code = (Hl7.Fhir.Model.CodeableConcept)Code.DeepCopy();
                    if(PermittedDataTypeElement != null) dest.PermittedDataTypeElement = new List<Code<Hl7.Fhir.Model.ObservationDefinition.ObservationDataType>>(PermittedDataTypeElement.DeepCopy());
                    if(QuantitativeDetails != null) dest.QuantitativeDetails = (Hl7.Fhir.Model.ObservationDefinition.QuantitativeDetailsComponent)QuantitativeDetails.DeepCopy();
                    if(QualifiedInterval != null) dest.QualifiedInterval = new List<Hl7.Fhir.Model.ObservationDefinition.QualifiedIntervalComponent>(QualifiedInterval.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ComponentComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ComponentComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Code, otherT.Code)) return false;
                if( !DeepComparable.Matches(PermittedDataTypeElement, otherT.PermittedDataTypeElement)) return false;
                if( !DeepComparable.Matches(QuantitativeDetails, otherT.QuantitativeDetails)) return false;
                if( !DeepComparable.Matches(QualifiedInterval, otherT.QualifiedInterval)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ComponentComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if( !DeepComparable.IsExactly(PermittedDataTypeElement, otherT.PermittedDataTypeElement)) return false;
                if( !DeepComparable.IsExactly(QuantitativeDetails, otherT.QuantitativeDetails)) return false;
                if( !DeepComparable.IsExactly(QualifiedInterval, otherT.QualifiedInterval)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Code != null) yield return Code;
                    foreach (var elem in PermittedDataTypeElement) { if (elem != null) yield return elem; }
                    if (QuantitativeDetails != null) yield return QuantitativeDetails;
                    foreach (var elem in QualifiedInterval) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", Code);
                    foreach (var elem in PermittedDataTypeElement) { if (elem != null) yield return new ElementValue("permittedDataType", elem); }
                    if (QuantitativeDetails != null) yield return new ElementValue("quantitativeDetails", QuantitativeDetails);
                    foreach (var elem in QualifiedInterval) { if (elem != null) yield return new ElementValue("qualifiedInterval", elem); }
                }
            }

            
        }
        
        
        /// <summary>
        /// Logical canonical URL to reference this ObservationDefinition (globally unique)
        /// </summary>
        [FhirElement("url", InSummary=true, Order=90)]
        [DataMember]
        public Hl7.Fhir.Model.FhirUri UrlElement
        {
            get { return _UrlElement; }
            set { _UrlElement = value; OnPropertyChanged("UrlElement"); }
        }
        
        private Hl7.Fhir.Model.FhirUri _UrlElement;
        
        /// <summary>
        /// Logical canonical URL to reference this ObservationDefinition (globally unique)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Url
        {
            get { return UrlElement != null ? UrlElement.Value : null; }
            set
            {
                if (value == null)
                  UrlElement = null; 
                else
                  UrlElement = new Hl7.Fhir.Model.FhirUri(value);
                OnPropertyChanged("Url");
            }
        }
        
        /// <summary>
        /// Business identifier of the ObservationDefinition
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=100)]
        [DataMember]
        public Hl7.Fhir.Model.Identifier Identifier
        {
            get { return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private Hl7.Fhir.Model.Identifier _Identifier;
        
        /// <summary>
        /// Business version of the ObservationDefinition
        /// </summary>
        [FhirElement("version", InSummary=true, Order=110)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString VersionElement
        {
            get { return _VersionElement; }
            set { _VersionElement = value; OnPropertyChanged("VersionElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _VersionElement;
        
        /// <summary>
        /// Business version of the ObservationDefinition
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Version
        {
            get { return VersionElement != null ? VersionElement.Value : null; }
            set
            {
                if (value == null)
                  VersionElement = null; 
                else
                  VersionElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Version");
            }
        }
        
        /// <summary>
        /// Name for this ObservationDefinition (Human friendly)
        /// </summary>
        [FhirElement("title", InSummary=true, Order=120)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString TitleElement
        {
            get { return _TitleElement; }
            set { _TitleElement = value; OnPropertyChanged("TitleElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _TitleElement;
        
        /// <summary>
        /// Name for this ObservationDefinition (Human friendly)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Title
        {
            get { return TitleElement != null ? TitleElement.Value : null; }
            set
            {
                if (value == null)
                  TitleElement = null; 
                else
                  TitleElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Title");
            }
        }
        
        /// <summary>
        /// Based on FHIR definition of another observation
        /// </summary>
        [FhirElement("derivedFromCanonical", InSummary=true, Order=130)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Canonical> DerivedFromCanonicalElement
        {
            get { if(_DerivedFromCanonicalElement==null) _DerivedFromCanonicalElement = new List<Hl7.Fhir.Model.Canonical>(); return _DerivedFromCanonicalElement; }
            set { _DerivedFromCanonicalElement = value; OnPropertyChanged("DerivedFromCanonicalElement"); }
        }
        
        private List<Hl7.Fhir.Model.Canonical> _DerivedFromCanonicalElement;
        
        /// <summary>
        /// Based on FHIR definition of another observation
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public IEnumerable<string> DerivedFromCanonical
        {
            get { return DerivedFromCanonicalElement != null ? DerivedFromCanonicalElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                  DerivedFromCanonicalElement = null; 
                else
                  DerivedFromCanonicalElement = new List<Hl7.Fhir.Model.Canonical>(value.Select(elem=>new Hl7.Fhir.Model.Canonical(elem)));
                OnPropertyChanged("DerivedFromCanonical");
            }
        }
        
        /// <summary>
        /// Based on external definition
        /// </summary>
        [FhirElement("derivedFromUri", InSummary=true, Order=140)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.FhirUri> DerivedFromUriElement
        {
            get { if(_DerivedFromUriElement==null) _DerivedFromUriElement = new List<Hl7.Fhir.Model.FhirUri>(); return _DerivedFromUriElement; }
            set { _DerivedFromUriElement = value; OnPropertyChanged("DerivedFromUriElement"); }
        }
        
        private List<Hl7.Fhir.Model.FhirUri> _DerivedFromUriElement;
        
        /// <summary>
        /// Based on external definition
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public IEnumerable<string> DerivedFromUri
        {
            get { return DerivedFromUriElement != null ? DerivedFromUriElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                  DerivedFromUriElement = null; 
                else
                  DerivedFromUriElement = new List<Hl7.Fhir.Model.FhirUri>(value.Select(elem=>new Hl7.Fhir.Model.FhirUri(elem)));
                OnPropertyChanged("DerivedFromUri");
            }
        }
        
        /// <summary>
        /// draft | active | retired | unknown
        /// </summary>
        [FhirElement("status", InSummary=true, Order=150)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<Hl7.Fhir.Model.PublicationStatus> StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        
        private Code<Hl7.Fhir.Model.PublicationStatus> _StatusElement;
        
        /// <summary>
        /// draft | active | retired | unknown
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.PublicationStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.PublicationStatus>(value);
                OnPropertyChanged("Status");
            }
        }
        
        /// <summary>
        /// If for testing purposes, not real usage
        /// </summary>
        [FhirElement("experimental", InSummary=true, Order=160)]
        [DataMember]
        public Hl7.Fhir.Model.FhirBoolean ExperimentalElement
        {
            get { return _ExperimentalElement; }
            set { _ExperimentalElement = value; OnPropertyChanged("ExperimentalElement"); }
        }
        
        private Hl7.Fhir.Model.FhirBoolean _ExperimentalElement;
        
        /// <summary>
        /// If for testing purposes, not real usage
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public bool? Experimental
        {
            get { return ExperimentalElement != null ? ExperimentalElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  ExperimentalElement = null; 
                else
                  ExperimentalElement = new Hl7.Fhir.Model.FhirBoolean(value);
                OnPropertyChanged("Experimental");
            }
        }
        
        /// <summary>
        /// Type of subject for the defined observation
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=170, Choice=ChoiceType.DatatypeChoice)]
        [CLSCompliant(false)]
		[AllowedTypes(typeof(Hl7.Fhir.Model.CodeableConcept),typeof(Hl7.Fhir.Model.ResourceReference))]
        [DataMember]
        public Hl7.Fhir.Model.Element Subject
        {
            get { return _Subject; }
            set { _Subject = value; OnPropertyChanged("Subject"); }
        }
        
        private Hl7.Fhir.Model.Element _Subject;
        
        /// <summary>
        /// Date status first applied
        /// </summary>
        [FhirElement("date", InSummary=true, Order=180)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime DateElement
        {
            get { return _DateElement; }
            set { _DateElement = value; OnPropertyChanged("DateElement"); }
        }
        
        private Hl7.Fhir.Model.FhirDateTime _DateElement;
        
        /// <summary>
        /// Date status first applied
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Date
        {
            get { return DateElement != null ? DateElement.Value : null; }
            set
            {
                if (value == null)
                  DateElement = null; 
                else
                  DateElement = new Hl7.Fhir.Model.FhirDateTime(value);
                OnPropertyChanged("Date");
            }
        }
        
        /// <summary>
        /// The name of the individual or organization that published the ObservationDefinition
        /// </summary>
        [FhirElement("publisher", InSummary=true, Order=190)]
        [CLSCompliant(false)]
		[References("Practitioner","PractitionerRole","Organization")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Publisher
        {
            get { return _Publisher; }
            set { _Publisher = value; OnPropertyChanged("Publisher"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Publisher;
        
        /// <summary>
        /// Contact details for the publisher
        /// </summary>
        [FhirElement("contact", InSummary=true, Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactDetail> Contact
        {
            get { if(_Contact==null) _Contact = new List<ContactDetail>(); return _Contact; }
            set { _Contact = value; OnPropertyChanged("Contact"); }
        }
        
        private List<ContactDetail> _Contact;
        
        /// <summary>
        /// Natural language description of the ObservationDefinition
        /// </summary>
        [FhirElement("description", Order=210)]
        [DataMember]
        public Hl7.Fhir.Model.Markdown Description
        {
            get { return _Description; }
            set { _Description = value; OnPropertyChanged("Description"); }
        }
        
        private Hl7.Fhir.Model.Markdown _Description;
        
        /// <summary>
        /// Content intends to support these contexts
        /// </summary>
        [FhirElement("useContext", Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<UsageContext> UseContext
        {
            get { if(_UseContext==null) _UseContext = new List<UsageContext>(); return _UseContext; }
            set { _UseContext = value; OnPropertyChanged("UseContext"); }
        }
        
        private List<UsageContext> _UseContext;
        
        /// <summary>
        /// Intended jurisdiction for this ObservationDefinition (if applicable)
        /// </summary>
        [FhirElement("jurisdiction", InSummary=true, Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> Jurisdiction
        {
            get { if(_Jurisdiction==null) _Jurisdiction = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Jurisdiction; }
            set { _Jurisdiction = value; OnPropertyChanged("Jurisdiction"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _Jurisdiction;
        
        /// <summary>
        /// Why this ObservationDefinition is defined
        /// </summary>
        [FhirElement("purpose", Order=240)]
        [DataMember]
        public Hl7.Fhir.Model.Markdown Purpose
        {
            get { return _Purpose; }
            set { _Purpose = value; OnPropertyChanged("Purpose"); }
        }
        
        private Hl7.Fhir.Model.Markdown _Purpose;
        
        /// <summary>
        /// Use and/or publishing restrictions
        /// </summary>
        [FhirElement("copyright", Order=250)]
        [DataMember]
        public Hl7.Fhir.Model.Markdown Copyright
        {
            get { return _Copyright; }
            set { _Copyright = value; OnPropertyChanged("Copyright"); }
        }
        
        private Hl7.Fhir.Model.Markdown _Copyright;
        
        /// <summary>
        /// When ObservationDefinition was approved by publisher
        /// </summary>
        [FhirElement("approvalDate", Order=260)]
        [DataMember]
        public Hl7.Fhir.Model.Date ApprovalDateElement
        {
            get { return _ApprovalDateElement; }
            set { _ApprovalDateElement = value; OnPropertyChanged("ApprovalDateElement"); }
        }
        
        private Hl7.Fhir.Model.Date _ApprovalDateElement;
        
        /// <summary>
        /// When ObservationDefinition was approved by publisher
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string ApprovalDate
        {
            get { return ApprovalDateElement != null ? ApprovalDateElement.Value : null; }
            set
            {
                if (value == null)
                  ApprovalDateElement = null; 
                else
                  ApprovalDateElement = new Hl7.Fhir.Model.Date(value);
                OnPropertyChanged("ApprovalDate");
            }
        }
        
        /// <summary>
        /// Last review date for the ObservationDefinition
        /// </summary>
        [FhirElement("lastReviewDate", Order=270)]
        [DataMember]
        public Hl7.Fhir.Model.Date LastReviewDateElement
        {
            get { return _LastReviewDateElement; }
            set { _LastReviewDateElement = value; OnPropertyChanged("LastReviewDateElement"); }
        }
        
        private Hl7.Fhir.Model.Date _LastReviewDateElement;
        
        /// <summary>
        /// Last review date for the ObservationDefinition
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string LastReviewDate
        {
            get { return LastReviewDateElement != null ? LastReviewDateElement.Value : null; }
            set
            {
                if (value == null)
                  LastReviewDateElement = null; 
                else
                  LastReviewDateElement = new Hl7.Fhir.Model.Date(value);
                OnPropertyChanged("LastReviewDate");
            }
        }
        
        /// <summary>
        /// The effective date range for the ObservationDefinition
        /// </summary>
        [FhirElement("effectivePeriod", InSummary=true, Order=280)]
        [DataMember]
        public Hl7.Fhir.Model.Period EffectivePeriod
        {
            get { return _EffectivePeriod; }
            set { _EffectivePeriod = value; OnPropertyChanged("EffectivePeriod"); }
        }
        
        private Hl7.Fhir.Model.Period _EffectivePeriod;
        
        /// <summary>
        /// Desired kind of performer for such kind of observation
        /// </summary>
        [FhirElement("performerType", InSummary=true, Order=290)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept PerformerType
        {
            get { return _PerformerType; }
            set { _PerformerType = value; OnPropertyChanged("PerformerType"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _PerformerType;
        
        /// <summary>
        /// Category of observation
        /// </summary>
        [FhirElement("category", InSummary=true, Order=300)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> Category
        {
            get { if(_Category==null) _Category = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Category; }
            set { _Category = value; OnPropertyChanged("Category"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _Category;
        
        /// <summary>
        /// Type of observation
        /// </summary>
        [FhirElement("code", InSummary=true, Order=310)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Code
        {
            get { return _Code; }
            set { _Code = value; OnPropertyChanged("Code"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Code;
        
        /// <summary>
        /// Quantity | CodeableConcept | string | boolean | integer | Range | Ratio | SampledData | time | dateTime | Period
        /// </summary>
        [FhirElement("permittedDataType", Order=320)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Code<Hl7.Fhir.Model.ObservationDefinition.ObservationDataType>> PermittedDataTypeElement
        {
            get { if(_PermittedDataTypeElement==null) _PermittedDataTypeElement = new List<Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ObservationDefinition.ObservationDataType>>(); return _PermittedDataTypeElement; }
            set { _PermittedDataTypeElement = value; OnPropertyChanged("PermittedDataTypeElement"); }
        }
        
        private List<Code<Hl7.Fhir.Model.ObservationDefinition.ObservationDataType>> _PermittedDataTypeElement;
        
        /// <summary>
        /// Quantity | CodeableConcept | string | boolean | integer | Range | Ratio | SampledData | time | dateTime | Period
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public IEnumerable<Hl7.Fhir.Model.ObservationDefinition.ObservationDataType?> PermittedDataType
        {
            get { return PermittedDataTypeElement != null ? PermittedDataTypeElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                  PermittedDataTypeElement = null; 
                else
                  PermittedDataTypeElement = new List<Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ObservationDefinition.ObservationDataType>>(value.Select(elem=>new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ObservationDefinition.ObservationDataType>(elem)));
                OnPropertyChanged("PermittedDataType");
            }
        }
        
        /// <summary>
        /// Multiple results allowed
        /// </summary>
        [FhirElement("multipleResultsAllowed", Order=330)]
        [DataMember]
        public Hl7.Fhir.Model.FhirBoolean MultipleResultsAllowedElement
        {
            get { return _MultipleResultsAllowedElement; }
            set { _MultipleResultsAllowedElement = value; OnPropertyChanged("MultipleResultsAllowedElement"); }
        }
        
        private Hl7.Fhir.Model.FhirBoolean _MultipleResultsAllowedElement;
        
        /// <summary>
        /// Multiple results allowed
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public bool? MultipleResultsAllowed
        {
            get { return MultipleResultsAllowedElement != null ? MultipleResultsAllowedElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  MultipleResultsAllowedElement = null; 
                else
                  MultipleResultsAllowedElement = new Hl7.Fhir.Model.FhirBoolean(value);
                OnPropertyChanged("MultipleResultsAllowed");
            }
        }
        
        /// <summary>
        /// Body part to be observed
        /// </summary>
        [FhirElement("bodySite", Order=340)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept BodySite
        {
            get { return _BodySite; }
            set { _BodySite = value; OnPropertyChanged("BodySite"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _BodySite;
        
        /// <summary>
        /// Method used to produce the observation
        /// </summary>
        [FhirElement("method", Order=350)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Method
        {
            get { return _Method; }
            set { _Method = value; OnPropertyChanged("Method"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Method;
        
        /// <summary>
        /// Kind of specimen used by this type of observation
        /// </summary>
        [FhirElement("specimen", Order=360)]
        [CLSCompliant(false)]
		[References("SpecimenDefinition")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Specimen
        {
            get { return _Specimen; }
            set { _Specimen = value; OnPropertyChanged("Specimen"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Specimen;
        
        /// <summary>
        /// Measurement device
        /// </summary>
        [FhirElement("device", Order=370)]
        [CLSCompliant(false)]
		[References("Device")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Device
        {
            get { return _Device; }
            set { _Device = value; OnPropertyChanged("Device"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Device;
        
        /// <summary>
        /// Preferred report name
        /// </summary>
        [FhirElement("preferredReportName", Order=380)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString PreferredReportNameElement
        {
            get { return _PreferredReportNameElement; }
            set { _PreferredReportNameElement = value; OnPropertyChanged("PreferredReportNameElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _PreferredReportNameElement;
        
        /// <summary>
        /// Preferred report name
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string PreferredReportName
        {
            get { return PreferredReportNameElement != null ? PreferredReportNameElement.Value : null; }
            set
            {
                if (value == null)
                  PreferredReportNameElement = null; 
                else
                  PreferredReportNameElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("PreferredReportName");
            }
        }
        
        /// <summary>
        /// Characteristics of quantitative results
        /// </summary>
        [FhirElement("quantitativeDetails", Order=390)]
        [DataMember]
        public Hl7.Fhir.Model.ObservationDefinition.QuantitativeDetailsComponent QuantitativeDetails
        {
            get { return _QuantitativeDetails; }
            set { _QuantitativeDetails = value; OnPropertyChanged("QuantitativeDetails"); }
        }
        
        private Hl7.Fhir.Model.ObservationDefinition.QuantitativeDetailsComponent _QuantitativeDetails;
        
        /// <summary>
        /// Qualified range for continuous and ordinal observation results
        /// </summary>
        [FhirElement("qualifiedInterval", Order=400)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ObservationDefinition.QualifiedIntervalComponent> QualifiedInterval
        {
            get { if(_QualifiedInterval==null) _QualifiedInterval = new List<Hl7.Fhir.Model.ObservationDefinition.QualifiedIntervalComponent>(); return _QualifiedInterval; }
            set { _QualifiedInterval = value; OnPropertyChanged("QualifiedInterval"); }
        }
        
        private List<Hl7.Fhir.Model.ObservationDefinition.QualifiedIntervalComponent> _QualifiedInterval;
        
        /// <summary>
        /// Value set of valid coded values for the observations conforming to this ObservationDefinition
        /// </summary>
        [FhirElement("validCodedValueSet", Order=410)]
        [CLSCompliant(false)]
		[References("ValueSet")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference ValidCodedValueSet
        {
            get { return _ValidCodedValueSet; }
            set { _ValidCodedValueSet = value; OnPropertyChanged("ValidCodedValueSet"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _ValidCodedValueSet;
        
        /// <summary>
        /// Value set of normal coded values for the observations conforming to this ObservationDefinition
        /// </summary>
        [FhirElement("normalCodedValueSet", Order=420)]
        [CLSCompliant(false)]
		[References("ValueSet")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference NormalCodedValueSet
        {
            get { return _NormalCodedValueSet; }
            set { _NormalCodedValueSet = value; OnPropertyChanged("NormalCodedValueSet"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _NormalCodedValueSet;
        
        /// <summary>
        /// Value set of abnormal coded values for the observations conforming to this ObservationDefinition
        /// </summary>
        [FhirElement("abnormalCodedValueSet", Order=430)]
        [CLSCompliant(false)]
		[References("ValueSet")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference AbnormalCodedValueSet
        {
            get { return _AbnormalCodedValueSet; }
            set { _AbnormalCodedValueSet = value; OnPropertyChanged("AbnormalCodedValueSet"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _AbnormalCodedValueSet;
        
        /// <summary>
        /// Value set of critical coded values for the observations conforming to this ObservationDefinition
        /// </summary>
        [FhirElement("criticalCodedValueSet", Order=440)]
        [CLSCompliant(false)]
		[References("ValueSet")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference CriticalCodedValueSet
        {
            get { return _CriticalCodedValueSet; }
            set { _CriticalCodedValueSet = value; OnPropertyChanged("CriticalCodedValueSet"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _CriticalCodedValueSet;
        
        /// <summary>
        /// Definitions of related resources belonging to this kind of observation group
        /// </summary>
        [FhirElement("hasMember", Order=450)]
        [CLSCompliant(false)]
		[References("ObservationDefinition","Questionnaire")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ResourceReference> HasMember
        {
            get { if(_HasMember==null) _HasMember = new List<Hl7.Fhir.Model.ResourceReference>(); return _HasMember; }
            set { _HasMember = value; OnPropertyChanged("HasMember"); }
        }
        
        private List<Hl7.Fhir.Model.ResourceReference> _HasMember;
        
        /// <summary>
        /// Component results
        /// </summary>
        [FhirElement("component", Order=460)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ObservationDefinition.ComponentComponent> Component
        {
            get { if(_Component==null) _Component = new List<Hl7.Fhir.Model.ObservationDefinition.ComponentComponent>(); return _Component; }
            set { _Component = value; OnPropertyChanged("Component"); }
        }
        
        private List<Hl7.Fhir.Model.ObservationDefinition.ComponentComponent> _Component;
        

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ObservationDefinition;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(UrlElement != null) dest.UrlElement = (Hl7.Fhir.Model.FhirUri)UrlElement.DeepCopy();
                if(Identifier != null) dest.Identifier = (Hl7.Fhir.Model.Identifier)Identifier.DeepCopy();
                if(VersionElement != null) dest.VersionElement = (Hl7.Fhir.Model.FhirString)VersionElement.DeepCopy();
                if(TitleElement != null) dest.TitleElement = (Hl7.Fhir.Model.FhirString)TitleElement.DeepCopy();
                if(DerivedFromCanonicalElement != null) dest.DerivedFromCanonicalElement = new List<Hl7.Fhir.Model.Canonical>(DerivedFromCanonicalElement.DeepCopy());
                if(DerivedFromUriElement != null) dest.DerivedFromUriElement = new List<Hl7.Fhir.Model.FhirUri>(DerivedFromUriElement.DeepCopy());
                if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.PublicationStatus>)StatusElement.DeepCopy();
                if(ExperimentalElement != null) dest.ExperimentalElement = (Hl7.Fhir.Model.FhirBoolean)ExperimentalElement.DeepCopy();
                if(Subject != null) dest.Subject = (Hl7.Fhir.Model.Element)Subject.DeepCopy();
                if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.FhirDateTime)DateElement.DeepCopy();
                if(Publisher != null) dest.Publisher = (Hl7.Fhir.Model.ResourceReference)Publisher.DeepCopy();
                if(Contact != null) dest.Contact = new List<ContactDetail>(Contact.DeepCopy());
                if(Description != null) dest.Description = (Hl7.Fhir.Model.Markdown)Description.DeepCopy();
                if(UseContext != null) dest.UseContext = new List<UsageContext>(UseContext.DeepCopy());
                if(Jurisdiction != null) dest.Jurisdiction = new List<Hl7.Fhir.Model.CodeableConcept>(Jurisdiction.DeepCopy());
                if(Purpose != null) dest.Purpose = (Hl7.Fhir.Model.Markdown)Purpose.DeepCopy();
                if(Copyright != null) dest.Copyright = (Hl7.Fhir.Model.Markdown)Copyright.DeepCopy();
                if(ApprovalDateElement != null) dest.ApprovalDateElement = (Hl7.Fhir.Model.Date)ApprovalDateElement.DeepCopy();
                if(LastReviewDateElement != null) dest.LastReviewDateElement = (Hl7.Fhir.Model.Date)LastReviewDateElement.DeepCopy();
                if(EffectivePeriod != null) dest.EffectivePeriod = (Hl7.Fhir.Model.Period)EffectivePeriod.DeepCopy();
                if(PerformerType != null) dest.PerformerType = (Hl7.Fhir.Model.CodeableConcept)PerformerType.DeepCopy();
                if(Category != null) dest.Category = new List<Hl7.Fhir.Model.CodeableConcept>(Category.DeepCopy());
                if(Code != null) dest.Code = (Hl7.Fhir.Model.CodeableConcept)Code.DeepCopy();
                if(PermittedDataTypeElement != null) dest.PermittedDataTypeElement = new List<Code<Hl7.Fhir.Model.ObservationDefinition.ObservationDataType>>(PermittedDataTypeElement.DeepCopy());
                if(MultipleResultsAllowedElement != null) dest.MultipleResultsAllowedElement = (Hl7.Fhir.Model.FhirBoolean)MultipleResultsAllowedElement.DeepCopy();
                if(BodySite != null) dest.BodySite = (Hl7.Fhir.Model.CodeableConcept)BodySite.DeepCopy();
                if(Method != null) dest.Method = (Hl7.Fhir.Model.CodeableConcept)Method.DeepCopy();
                if(Specimen != null) dest.Specimen = (Hl7.Fhir.Model.ResourceReference)Specimen.DeepCopy();
                if(Device != null) dest.Device = (Hl7.Fhir.Model.ResourceReference)Device.DeepCopy();
                if(PreferredReportNameElement != null) dest.PreferredReportNameElement = (Hl7.Fhir.Model.FhirString)PreferredReportNameElement.DeepCopy();
                if(QuantitativeDetails != null) dest.QuantitativeDetails = (Hl7.Fhir.Model.ObservationDefinition.QuantitativeDetailsComponent)QuantitativeDetails.DeepCopy();
                if(QualifiedInterval != null) dest.QualifiedInterval = new List<Hl7.Fhir.Model.ObservationDefinition.QualifiedIntervalComponent>(QualifiedInterval.DeepCopy());
                if(ValidCodedValueSet != null) dest.ValidCodedValueSet = (Hl7.Fhir.Model.ResourceReference)ValidCodedValueSet.DeepCopy();
                if(NormalCodedValueSet != null) dest.NormalCodedValueSet = (Hl7.Fhir.Model.ResourceReference)NormalCodedValueSet.DeepCopy();
                if(AbnormalCodedValueSet != null) dest.AbnormalCodedValueSet = (Hl7.Fhir.Model.ResourceReference)AbnormalCodedValueSet.DeepCopy();
                if(CriticalCodedValueSet != null) dest.CriticalCodedValueSet = (Hl7.Fhir.Model.ResourceReference)CriticalCodedValueSet.DeepCopy();
                if(HasMember != null) dest.HasMember = new List<Hl7.Fhir.Model.ResourceReference>(HasMember.DeepCopy());
                if(Component != null) dest.Component = new List<Hl7.Fhir.Model.ObservationDefinition.ComponentComponent>(Component.DeepCopy());
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new ObservationDefinition());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ObservationDefinition;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
            if( !DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;
            if( !DeepComparable.Matches(DerivedFromCanonicalElement, otherT.DerivedFromCanonicalElement)) return false;
            if( !DeepComparable.Matches(DerivedFromUriElement, otherT.DerivedFromUriElement)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if( !DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.Matches(Publisher, otherT.Publisher)) return false;
            if( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if( !DeepComparable.Matches(Description, otherT.Description)) return false;
            if( !DeepComparable.Matches(UseContext, otherT.UseContext)) return false;
            if( !DeepComparable.Matches(Jurisdiction, otherT.Jurisdiction)) return false;
            if( !DeepComparable.Matches(Purpose, otherT.Purpose)) return false;
            if( !DeepComparable.Matches(Copyright, otherT.Copyright)) return false;
            if( !DeepComparable.Matches(ApprovalDateElement, otherT.ApprovalDateElement)) return false;
            if( !DeepComparable.Matches(LastReviewDateElement, otherT.LastReviewDateElement)) return false;
            if( !DeepComparable.Matches(EffectivePeriod, otherT.EffectivePeriod)) return false;
            if( !DeepComparable.Matches(PerformerType, otherT.PerformerType)) return false;
            if( !DeepComparable.Matches(Category, otherT.Category)) return false;
            if( !DeepComparable.Matches(Code, otherT.Code)) return false;
            if( !DeepComparable.Matches(PermittedDataTypeElement, otherT.PermittedDataTypeElement)) return false;
            if( !DeepComparable.Matches(MultipleResultsAllowedElement, otherT.MultipleResultsAllowedElement)) return false;
            if( !DeepComparable.Matches(BodySite, otherT.BodySite)) return false;
            if( !DeepComparable.Matches(Method, otherT.Method)) return false;
            if( !DeepComparable.Matches(Specimen, otherT.Specimen)) return false;
            if( !DeepComparable.Matches(Device, otherT.Device)) return false;
            if( !DeepComparable.Matches(PreferredReportNameElement, otherT.PreferredReportNameElement)) return false;
            if( !DeepComparable.Matches(QuantitativeDetails, otherT.QuantitativeDetails)) return false;
            if( !DeepComparable.Matches(QualifiedInterval, otherT.QualifiedInterval)) return false;
            if( !DeepComparable.Matches(ValidCodedValueSet, otherT.ValidCodedValueSet)) return false;
            if( !DeepComparable.Matches(NormalCodedValueSet, otherT.NormalCodedValueSet)) return false;
            if( !DeepComparable.Matches(AbnormalCodedValueSet, otherT.AbnormalCodedValueSet)) return false;
            if( !DeepComparable.Matches(CriticalCodedValueSet, otherT.CriticalCodedValueSet)) return false;
            if( !DeepComparable.Matches(HasMember, otherT.HasMember)) return false;
            if( !DeepComparable.Matches(Component, otherT.Component)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ObservationDefinition;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
            if( !DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;
            if( !DeepComparable.IsExactly(DerivedFromCanonicalElement, otherT.DerivedFromCanonicalElement)) return false;
            if( !DeepComparable.IsExactly(DerivedFromUriElement, otherT.DerivedFromUriElement)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if( !DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if( !DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.IsExactly(Publisher, otherT.Publisher)) return false;
            if( !DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if( !DeepComparable.IsExactly(Description, otherT.Description)) return false;
            if( !DeepComparable.IsExactly(UseContext, otherT.UseContext)) return false;
            if( !DeepComparable.IsExactly(Jurisdiction, otherT.Jurisdiction)) return false;
            if( !DeepComparable.IsExactly(Purpose, otherT.Purpose)) return false;
            if( !DeepComparable.IsExactly(Copyright, otherT.Copyright)) return false;
            if( !DeepComparable.IsExactly(ApprovalDateElement, otherT.ApprovalDateElement)) return false;
            if( !DeepComparable.IsExactly(LastReviewDateElement, otherT.LastReviewDateElement)) return false;
            if( !DeepComparable.IsExactly(EffectivePeriod, otherT.EffectivePeriod)) return false;
            if( !DeepComparable.IsExactly(PerformerType, otherT.PerformerType)) return false;
            if( !DeepComparable.IsExactly(Category, otherT.Category)) return false;
            if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if( !DeepComparable.IsExactly(PermittedDataTypeElement, otherT.PermittedDataTypeElement)) return false;
            if( !DeepComparable.IsExactly(MultipleResultsAllowedElement, otherT.MultipleResultsAllowedElement)) return false;
            if( !DeepComparable.IsExactly(BodySite, otherT.BodySite)) return false;
            if( !DeepComparable.IsExactly(Method, otherT.Method)) return false;
            if( !DeepComparable.IsExactly(Specimen, otherT.Specimen)) return false;
            if( !DeepComparable.IsExactly(Device, otherT.Device)) return false;
            if( !DeepComparable.IsExactly(PreferredReportNameElement, otherT.PreferredReportNameElement)) return false;
            if( !DeepComparable.IsExactly(QuantitativeDetails, otherT.QuantitativeDetails)) return false;
            if( !DeepComparable.IsExactly(QualifiedInterval, otherT.QualifiedInterval)) return false;
            if( !DeepComparable.IsExactly(ValidCodedValueSet, otherT.ValidCodedValueSet)) return false;
            if( !DeepComparable.IsExactly(NormalCodedValueSet, otherT.NormalCodedValueSet)) return false;
            if( !DeepComparable.IsExactly(AbnormalCodedValueSet, otherT.AbnormalCodedValueSet)) return false;
            if( !DeepComparable.IsExactly(CriticalCodedValueSet, otherT.CriticalCodedValueSet)) return false;
            if( !DeepComparable.IsExactly(HasMember, otherT.HasMember)) return false;
            if( !DeepComparable.IsExactly(Component, otherT.Component)) return false;
            
            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
				if (UrlElement != null) yield return UrlElement;
				if (Identifier != null) yield return Identifier;
				if (VersionElement != null) yield return VersionElement;
				if (TitleElement != null) yield return TitleElement;
				foreach (var elem in DerivedFromCanonicalElement) { if (elem != null) yield return elem; }
				foreach (var elem in DerivedFromUriElement) { if (elem != null) yield return elem; }
				if (StatusElement != null) yield return StatusElement;
				if (ExperimentalElement != null) yield return ExperimentalElement;
				if (Subject != null) yield return Subject;
				if (DateElement != null) yield return DateElement;
				if (Publisher != null) yield return Publisher;
				foreach (var elem in Contact) { if (elem != null) yield return elem; }
				if (Description != null) yield return Description;
				foreach (var elem in UseContext) { if (elem != null) yield return elem; }
				foreach (var elem in Jurisdiction) { if (elem != null) yield return elem; }
				if (Purpose != null) yield return Purpose;
				if (Copyright != null) yield return Copyright;
				if (ApprovalDateElement != null) yield return ApprovalDateElement;
				if (LastReviewDateElement != null) yield return LastReviewDateElement;
				if (EffectivePeriod != null) yield return EffectivePeriod;
				if (PerformerType != null) yield return PerformerType;
				foreach (var elem in Category) { if (elem != null) yield return elem; }
				if (Code != null) yield return Code;
				foreach (var elem in PermittedDataTypeElement) { if (elem != null) yield return elem; }
				if (MultipleResultsAllowedElement != null) yield return MultipleResultsAllowedElement;
				if (BodySite != null) yield return BodySite;
				if (Method != null) yield return Method;
				if (Specimen != null) yield return Specimen;
				if (Device != null) yield return Device;
				if (PreferredReportNameElement != null) yield return PreferredReportNameElement;
				if (QuantitativeDetails != null) yield return QuantitativeDetails;
				foreach (var elem in QualifiedInterval) { if (elem != null) yield return elem; }
				if (ValidCodedValueSet != null) yield return ValidCodedValueSet;
				if (NormalCodedValueSet != null) yield return NormalCodedValueSet;
				if (AbnormalCodedValueSet != null) yield return AbnormalCodedValueSet;
				if (CriticalCodedValueSet != null) yield return CriticalCodedValueSet;
				foreach (var elem in HasMember) { if (elem != null) yield return elem; }
				foreach (var elem in Component) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        public override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (UrlElement != null) yield return new ElementValue("url", UrlElement);
                if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                if (VersionElement != null) yield return new ElementValue("version", VersionElement);
                if (TitleElement != null) yield return new ElementValue("title", TitleElement);
                foreach (var elem in DerivedFromCanonicalElement) { if (elem != null) yield return new ElementValue("derivedFromCanonical", elem); }
                foreach (var elem in DerivedFromUriElement) { if (elem != null) yield return new ElementValue("derivedFromUri", elem); }
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (ExperimentalElement != null) yield return new ElementValue("experimental", ExperimentalElement);
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (Publisher != null) yield return new ElementValue("publisher", Publisher);
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
                if (Description != null) yield return new ElementValue("description", Description);
                foreach (var elem in UseContext) { if (elem != null) yield return new ElementValue("useContext", elem); }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return new ElementValue("jurisdiction", elem); }
                if (Purpose != null) yield return new ElementValue("purpose", Purpose);
                if (Copyright != null) yield return new ElementValue("copyright", Copyright);
                if (ApprovalDateElement != null) yield return new ElementValue("approvalDate", ApprovalDateElement);
                if (LastReviewDateElement != null) yield return new ElementValue("lastReviewDate", LastReviewDateElement);
                if (EffectivePeriod != null) yield return new ElementValue("effectivePeriod", EffectivePeriod);
                if (PerformerType != null) yield return new ElementValue("performerType", PerformerType);
                foreach (var elem in Category) { if (elem != null) yield return new ElementValue("category", elem); }
                if (Code != null) yield return new ElementValue("code", Code);
                foreach (var elem in PermittedDataTypeElement) { if (elem != null) yield return new ElementValue("permittedDataType", elem); }
                if (MultipleResultsAllowedElement != null) yield return new ElementValue("multipleResultsAllowed", MultipleResultsAllowedElement);
                if (BodySite != null) yield return new ElementValue("bodySite", BodySite);
                if (Method != null) yield return new ElementValue("method", Method);
                if (Specimen != null) yield return new ElementValue("specimen", Specimen);
                if (Device != null) yield return new ElementValue("device", Device);
                if (PreferredReportNameElement != null) yield return new ElementValue("preferredReportName", PreferredReportNameElement);
                if (QuantitativeDetails != null) yield return new ElementValue("quantitativeDetails", QuantitativeDetails);
                foreach (var elem in QualifiedInterval) { if (elem != null) yield return new ElementValue("qualifiedInterval", elem); }
                if (ValidCodedValueSet != null) yield return new ElementValue("validCodedValueSet", ValidCodedValueSet);
                if (NormalCodedValueSet != null) yield return new ElementValue("normalCodedValueSet", NormalCodedValueSet);
                if (AbnormalCodedValueSet != null) yield return new ElementValue("abnormalCodedValueSet", AbnormalCodedValueSet);
                if (CriticalCodedValueSet != null) yield return new ElementValue("criticalCodedValueSet", CriticalCodedValueSet);
                foreach (var elem in HasMember) { if (elem != null) yield return new ElementValue("hasMember", elem); }
                foreach (var elem in Component) { if (elem != null) yield return new ElementValue("component", elem); }
            }
        }

    }
    
}
