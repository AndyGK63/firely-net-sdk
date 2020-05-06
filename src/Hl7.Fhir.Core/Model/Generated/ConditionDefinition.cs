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
// Generated for FHIR v4.4.0
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// A definition of a condition
    /// </summary>
    [FhirType("ConditionDefinition", IsResource=true)]
    [DataContract]
    public partial class ConditionDefinition : Hl7.Fhir.Model.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ConditionDefinition; } }
        [NotMapped]
        public override string TypeName { get { return "ConditionDefinition"; } }
        
        /// <summary>
        /// Kind of precondition for the condition.
        /// (url: http://hl7.org/fhir/ValueSet/condition-precondition-type)
        /// </summary>
        [FhirEnumeration("ConditionPreconditionType")]
        public enum ConditionPreconditionType
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/condition-precondition-type)
            /// </summary>
            [EnumLiteral("sensitive", "http://hl7.org/fhir/condition-precondition-type"), Description("Sensitive")]
            Sensitive,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/condition-precondition-type)
            /// </summary>
            [EnumLiteral("specific", "http://hl7.org/fhir/condition-precondition-type"), Description("Specific")]
            Specific,
        }

        /// <summary>
        /// The use of a questionnaire.
        /// (url: http://hl7.org/fhir/ValueSet/condition-questionnaire-purpose)
        /// </summary>
        [FhirEnumeration("ConditionQuestionnairePurpose")]
        public enum ConditionQuestionnairePurpose
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/condition-questionnaire-purpose)
            /// </summary>
            [EnumLiteral("preadmit", "http://hl7.org/fhir/condition-questionnaire-purpose"), Description("Pre-admit")]
            Preadmit,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/condition-questionnaire-purpose)
            /// </summary>
            [EnumLiteral("diff-diagnosis", "http://hl7.org/fhir/condition-questionnaire-purpose"), Description("Diff Diagnosis")]
            DiffDiagnosis,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/condition-questionnaire-purpose)
            /// </summary>
            [EnumLiteral("outcome", "http://hl7.org/fhir/condition-questionnaire-purpose"), Description("Outcome")]
            Outcome,
        }

        [FhirType("ObservationComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class ObservationComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ObservationComponent"; } }
            
            /// <summary>
            /// Category that is relevant
            /// </summary>
            [FhirElement("category", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Category
            {
                get { return _Category; }
                set { _Category = value; OnPropertyChanged("Category"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Category;
            
            /// <summary>
            /// Code for relevant Observation
            /// </summary>
            [FhirElement("code", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Code
            {
                get { return _Code; }
                set { _Code = value; OnPropertyChanged("Code"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Code;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ObservationComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Category != null) dest.Category = (Hl7.Fhir.Model.CodeableConcept)Category.DeepCopy();
                    if(Code != null) dest.Code = (Hl7.Fhir.Model.CodeableConcept)Code.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ObservationComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ObservationComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Category, otherT.Category)) return false;
                if( !DeepComparable.Matches(Code, otherT.Code)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ObservationComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Category, otherT.Category)) return false;
                if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Category != null) yield return Category;
                    if (Code != null) yield return Code;
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Category != null) yield return new ElementValue("category", Category);
                    if (Code != null) yield return new ElementValue("code", Code);
                }
            }

            
        }
        
        
        [FhirType("MedicationComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class MedicationComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "MedicationComponent"; } }
            
            /// <summary>
            /// Category that is relevant
            /// </summary>
            [FhirElement("category", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Category
            {
                get { return _Category; }
                set { _Category = value; OnPropertyChanged("Category"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Category;
            
            /// <summary>
            /// Code for relevant Medication
            /// </summary>
            [FhirElement("code", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Code
            {
                get { return _Code; }
                set { _Code = value; OnPropertyChanged("Code"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Code;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as MedicationComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Category != null) dest.Category = (Hl7.Fhir.Model.CodeableConcept)Category.DeepCopy();
                    if(Code != null) dest.Code = (Hl7.Fhir.Model.CodeableConcept)Code.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new MedicationComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as MedicationComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Category, otherT.Category)) return false;
                if( !DeepComparable.Matches(Code, otherT.Code)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as MedicationComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Category, otherT.Category)) return false;
                if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Category != null) yield return Category;
                    if (Code != null) yield return Code;
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Category != null) yield return new ElementValue("category", Category);
                    if (Code != null) yield return new ElementValue("code", Code);
                }
            }

            
        }
        
        
        [FhirType("PreconditionComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class PreconditionComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "PreconditionComponent"; } }
            
            /// <summary>
            /// sensitive | specific
            /// </summary>
            [FhirElement("type", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<Hl7.Fhir.Model.ConditionDefinition.ConditionPreconditionType> TypeElement
            {
                get { return _TypeElement; }
                set { _TypeElement = value; OnPropertyChanged("TypeElement"); }
            }
            
            private Code<Hl7.Fhir.Model.ConditionDefinition.ConditionPreconditionType> _TypeElement;
            
            /// <summary>
            /// sensitive | specific
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public Hl7.Fhir.Model.ConditionDefinition.ConditionPreconditionType? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        TypeElement = null; 
                    else
                        TypeElement = new Code<Hl7.Fhir.Model.ConditionDefinition.ConditionPreconditionType>(value);
                    OnPropertyChanged("Type");
                }
            }
            
            /// <summary>
            /// Code for relevant Observation
            /// </summary>
            [FhirElement("code", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Code
            {
                get { return _Code; }
                set { _Code = value; OnPropertyChanged("Code"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Code;
            
            /// <summary>
            /// Value of Observation
            /// </summary>
            [FhirElement("value", Order=60, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
			[AllowedTypes(typeof(Hl7.Fhir.Model.CodeableConcept),typeof(Quantity))]
            [DataMember]
            public Hl7.Fhir.Model.Element Value
            {
                get { return _Value; }
                set { _Value = value; OnPropertyChanged("Value"); }
            }
            
            private Hl7.Fhir.Model.Element _Value;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PreconditionComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(TypeElement != null) dest.TypeElement = (Code<Hl7.Fhir.Model.ConditionDefinition.ConditionPreconditionType>)TypeElement.DeepCopy();
                    if(Code != null) dest.Code = (Hl7.Fhir.Model.CodeableConcept)Code.DeepCopy();
                    if(Value != null) dest.Value = (Hl7.Fhir.Model.Element)Value.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new PreconditionComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PreconditionComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if( !DeepComparable.Matches(Code, otherT.Code)) return false;
                if( !DeepComparable.Matches(Value, otherT.Value)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PreconditionComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if( !DeepComparable.IsExactly(Value, otherT.Value)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (TypeElement != null) yield return TypeElement;
                    if (Code != null) yield return Code;
                    if (Value != null) yield return Value;
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                    if (Code != null) yield return new ElementValue("code", Code);
                    if (Value != null) yield return new ElementValue("value", Value);
                }
            }

            
        }
        
        
        [FhirType("QuestionnaireComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class QuestionnaireComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "QuestionnaireComponent"; } }
            
            /// <summary>
            /// preadmit | diff-diagnosis | outcome
            /// </summary>
            [FhirElement("purpose", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<Hl7.Fhir.Model.ConditionDefinition.ConditionQuestionnairePurpose> PurposeElement
            {
                get { return _PurposeElement; }
                set { _PurposeElement = value; OnPropertyChanged("PurposeElement"); }
            }
            
            private Code<Hl7.Fhir.Model.ConditionDefinition.ConditionQuestionnairePurpose> _PurposeElement;
            
            /// <summary>
            /// preadmit | diff-diagnosis | outcome
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public Hl7.Fhir.Model.ConditionDefinition.ConditionQuestionnairePurpose? Purpose
            {
                get { return PurposeElement != null ? PurposeElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        PurposeElement = null; 
                    else
                        PurposeElement = new Code<Hl7.Fhir.Model.ConditionDefinition.ConditionQuestionnairePurpose>(value);
                    OnPropertyChanged("Purpose");
                }
            }
            
            /// <summary>
            /// Specific Questionnaire
            /// </summary>
            [FhirElement("reference", Order=50)]
            [CLSCompliant(false)]
			[References("Questionnaire")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference Reference
            {
                get { return _Reference; }
                set { _Reference = value; OnPropertyChanged("Reference"); }
            }
            
            private Hl7.Fhir.Model.ResourceReference _Reference;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as QuestionnaireComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(PurposeElement != null) dest.PurposeElement = (Code<Hl7.Fhir.Model.ConditionDefinition.ConditionQuestionnairePurpose>)PurposeElement.DeepCopy();
                    if(Reference != null) dest.Reference = (Hl7.Fhir.Model.ResourceReference)Reference.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new QuestionnaireComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as QuestionnaireComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(PurposeElement, otherT.PurposeElement)) return false;
                if( !DeepComparable.Matches(Reference, otherT.Reference)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as QuestionnaireComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(PurposeElement, otherT.PurposeElement)) return false;
                if( !DeepComparable.IsExactly(Reference, otherT.Reference)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (PurposeElement != null) yield return PurposeElement;
                    if (Reference != null) yield return Reference;
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (PurposeElement != null) yield return new ElementValue("purpose", PurposeElement);
                    if (Reference != null) yield return new ElementValue("reference", Reference);
                }
            }

            
        }
        
        
        [FhirType("PlanComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class PlanComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "PlanComponent"; } }
            
            /// <summary>
            /// Use for the plan
            /// </summary>
            [FhirElement("role", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Role
            {
                get { return _Role; }
                set { _Role = value; OnPropertyChanged("Role"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Role;
            
            /// <summary>
            /// The actual plan
            /// </summary>
            [FhirElement("reference", Order=50)]
            [CLSCompliant(false)]
			[References("PlanDefinition")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference Reference
            {
                get { return _Reference; }
                set { _Reference = value; OnPropertyChanged("Reference"); }
            }
            
            private Hl7.Fhir.Model.ResourceReference _Reference;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PlanComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Role != null) dest.Role = (Hl7.Fhir.Model.CodeableConcept)Role.DeepCopy();
                    if(Reference != null) dest.Reference = (Hl7.Fhir.Model.ResourceReference)Reference.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new PlanComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PlanComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Role, otherT.Role)) return false;
                if( !DeepComparable.Matches(Reference, otherT.Reference)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PlanComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Role, otherT.Role)) return false;
                if( !DeepComparable.IsExactly(Reference, otherT.Reference)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Role != null) yield return Role;
                    if (Reference != null) yield return Reference;
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Role != null) yield return new ElementValue("role", Role);
                    if (Reference != null) yield return new ElementValue("reference", Reference);
                }
            }

            
        }
        
        
        /// <summary>
        /// Canonical identifier for this condition definition, represented as a URI (globally unique)
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
        /// Canonical identifier for this condition definition, represented as a URI (globally unique)
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
        /// Additional identifier for the condition definition
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=100)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Identifier> Identifier
        {
            get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private List<Hl7.Fhir.Model.Identifier> _Identifier;
        
        /// <summary>
        /// Business version of the condition definition
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
        /// Business version of the condition definition
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
        /// Name for this condition definition (computer friendly)
        /// </summary>
        [FhirElement("name", InSummary=true, Order=120)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString NameElement
        {
            get { return _NameElement; }
            set { _NameElement = value; OnPropertyChanged("NameElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _NameElement;
        
        /// <summary>
        /// Name for this condition definition (computer friendly)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Name
        {
            get { return NameElement != null ? NameElement.Value : null; }
            set
            {
                if (value == null)
                  NameElement = null; 
                else
                  NameElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Name");
            }
        }
        
        /// <summary>
        /// Name for this condition definition (human friendly)
        /// </summary>
        [FhirElement("title", InSummary=true, Order=130)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString TitleElement
        {
            get { return _TitleElement; }
            set { _TitleElement = value; OnPropertyChanged("TitleElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _TitleElement;
        
        /// <summary>
        /// Name for this condition definition (human friendly)
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
        /// Subordinate title of the event definition
        /// </summary>
        [FhirElement("subtitle", Order=140)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString SubtitleElement
        {
            get { return _SubtitleElement; }
            set { _SubtitleElement = value; OnPropertyChanged("SubtitleElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _SubtitleElement;
        
        /// <summary>
        /// Subordinate title of the event definition
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Subtitle
        {
            get { return SubtitleElement != null ? SubtitleElement.Value : null; }
            set
            {
                if (value == null)
                  SubtitleElement = null; 
                else
                  SubtitleElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Subtitle");
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
        /// For testing purposes, not real usage
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
        /// For testing purposes, not real usage
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
        /// Date last changed
        /// </summary>
        [FhirElement("date", InSummary=true, Order=170)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime DateElement
        {
            get { return _DateElement; }
            set { _DateElement = value; OnPropertyChanged("DateElement"); }
        }
        
        private Hl7.Fhir.Model.FhirDateTime _DateElement;
        
        /// <summary>
        /// Date last changed
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
        /// Name of the publisher (organization or individual)
        /// </summary>
        [FhirElement("publisher", InSummary=true, Order=180)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString PublisherElement
        {
            get { return _PublisherElement; }
            set { _PublisherElement = value; OnPropertyChanged("PublisherElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _PublisherElement;
        
        /// <summary>
        /// Name of the publisher (organization or individual)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Publisher
        {
            get { return PublisherElement != null ? PublisherElement.Value : null; }
            set
            {
                if (value == null)
                  PublisherElement = null; 
                else
                  PublisherElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Publisher");
            }
        }
        
        /// <summary>
        /// Contact details for the publisher
        /// </summary>
        [FhirElement("contact", InSummary=true, Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactDetail> Contact
        {
            get { if(_Contact==null) _Contact = new List<ContactDetail>(); return _Contact; }
            set { _Contact = value; OnPropertyChanged("Contact"); }
        }
        
        private List<ContactDetail> _Contact;
        
        /// <summary>
        /// Natural language description of the condition definition
        /// </summary>
        [FhirElement("description", Order=200)]
        [DataMember]
        public Hl7.Fhir.Model.Markdown Description
        {
            get { return _Description; }
            set { _Description = value; OnPropertyChanged("Description"); }
        }
        
        private Hl7.Fhir.Model.Markdown _Description;
        
        /// <summary>
        /// The context that the content is intended to support
        /// </summary>
        [FhirElement("useContext", InSummary=true, Order=210)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<UsageContext> UseContext
        {
            get { if(_UseContext==null) _UseContext = new List<UsageContext>(); return _UseContext; }
            set { _UseContext = value; OnPropertyChanged("UseContext"); }
        }
        
        private List<UsageContext> _UseContext;
        
        /// <summary>
        /// Intended jurisdiction for condition definition (if applicable)
        /// </summary>
        [FhirElement("jurisdiction", InSummary=true, Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> Jurisdiction
        {
            get { if(_Jurisdiction==null) _Jurisdiction = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Jurisdiction; }
            set { _Jurisdiction = value; OnPropertyChanged("Jurisdiction"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _Jurisdiction;
        
        /// <summary>
        /// Identification of the condition, problem or diagnosis
        /// </summary>
        [FhirElement("code", InSummary=true, Order=230)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Code
        {
            get { return _Code; }
            set { _Code = value; OnPropertyChanged("Code"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Code;
        
        /// <summary>
        /// Subjective severity of condition
        /// </summary>
        [FhirElement("severity", InSummary=true, Order=240)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Severity
        {
            get { return _Severity; }
            set { _Severity = value; OnPropertyChanged("Severity"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Severity;
        
        /// <summary>
        /// Anatomical location, if relevant
        /// </summary>
        [FhirElement("bodySite", InSummary=true, Order=250)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept BodySite
        {
            get { return _BodySite; }
            set { _BodySite = value; OnPropertyChanged("BodySite"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _BodySite;
        
        /// <summary>
        /// Stage/grade, usually assessed formally
        /// </summary>
        [FhirElement("stage", InSummary=true, Order=260)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Stage
        {
            get { return _Stage; }
            set { _Stage = value; OnPropertyChanged("Stage"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Stage;
        
        /// <summary>
        /// Whether Severity is appropriate
        /// </summary>
        [FhirElement("hasSeverity", Order=270)]
        [DataMember]
        public Hl7.Fhir.Model.FhirBoolean HasSeverityElement
        {
            get { return _HasSeverityElement; }
            set { _HasSeverityElement = value; OnPropertyChanged("HasSeverityElement"); }
        }
        
        private Hl7.Fhir.Model.FhirBoolean _HasSeverityElement;
        
        /// <summary>
        /// Whether Severity is appropriate
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public bool? HasSeverity
        {
            get { return HasSeverityElement != null ? HasSeverityElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  HasSeverityElement = null; 
                else
                  HasSeverityElement = new Hl7.Fhir.Model.FhirBoolean(value);
                OnPropertyChanged("HasSeverity");
            }
        }
        
        /// <summary>
        /// Whether bodySite is appropriate
        /// </summary>
        [FhirElement("hasBodySite", Order=280)]
        [DataMember]
        public Hl7.Fhir.Model.FhirBoolean HasBodySiteElement
        {
            get { return _HasBodySiteElement; }
            set { _HasBodySiteElement = value; OnPropertyChanged("HasBodySiteElement"); }
        }
        
        private Hl7.Fhir.Model.FhirBoolean _HasBodySiteElement;
        
        /// <summary>
        /// Whether bodySite is appropriate
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public bool? HasBodySite
        {
            get { return HasBodySiteElement != null ? HasBodySiteElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  HasBodySiteElement = null; 
                else
                  HasBodySiteElement = new Hl7.Fhir.Model.FhirBoolean(value);
                OnPropertyChanged("HasBodySite");
            }
        }
        
        /// <summary>
        /// Whether stage is appropriate
        /// </summary>
        [FhirElement("hasStage", Order=290)]
        [DataMember]
        public Hl7.Fhir.Model.FhirBoolean HasStageElement
        {
            get { return _HasStageElement; }
            set { _HasStageElement = value; OnPropertyChanged("HasStageElement"); }
        }
        
        private Hl7.Fhir.Model.FhirBoolean _HasStageElement;
        
        /// <summary>
        /// Whether stage is appropriate
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public bool? HasStage
        {
            get { return HasStageElement != null ? HasStageElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  HasStageElement = null; 
                else
                  HasStageElement = new Hl7.Fhir.Model.FhirBoolean(value);
                OnPropertyChanged("HasStage");
            }
        }
        
        /// <summary>
        /// Formal Definition for the condition
        /// </summary>
        [FhirElement("definition", Order=300)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.FhirUri> DefinitionElement
        {
            get { if(_DefinitionElement==null) _DefinitionElement = new List<Hl7.Fhir.Model.FhirUri>(); return _DefinitionElement; }
            set { _DefinitionElement = value; OnPropertyChanged("DefinitionElement"); }
        }
        
        private List<Hl7.Fhir.Model.FhirUri> _DefinitionElement;
        
        /// <summary>
        /// Formal Definition for the condition
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public IEnumerable<string> Definition
        {
            get { return DefinitionElement != null ? DefinitionElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                  DefinitionElement = null; 
                else
                  DefinitionElement = new List<Hl7.Fhir.Model.FhirUri>(value.Select(elem=>new Hl7.Fhir.Model.FhirUri(elem)));
                OnPropertyChanged("Definition");
            }
        }
        
        /// <summary>
        /// Observations particularly relevant to this condition
        /// </summary>
        [FhirElement("observation", Order=310)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ConditionDefinition.ObservationComponent> Observation
        {
            get { if(_Observation==null) _Observation = new List<Hl7.Fhir.Model.ConditionDefinition.ObservationComponent>(); return _Observation; }
            set { _Observation = value; OnPropertyChanged("Observation"); }
        }
        
        private List<Hl7.Fhir.Model.ConditionDefinition.ObservationComponent> _Observation;
        
        /// <summary>
        /// Medications particularly relevant for this condition
        /// </summary>
        [FhirElement("medication", Order=320)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ConditionDefinition.MedicationComponent> Medication
        {
            get { if(_Medication==null) _Medication = new List<Hl7.Fhir.Model.ConditionDefinition.MedicationComponent>(); return _Medication; }
            set { _Medication = value; OnPropertyChanged("Medication"); }
        }
        
        private List<Hl7.Fhir.Model.ConditionDefinition.MedicationComponent> _Medication;
        
        /// <summary>
        /// Observation that suggets this condition
        /// </summary>
        [FhirElement("precondition", Order=330)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ConditionDefinition.PreconditionComponent> Precondition
        {
            get { if(_Precondition==null) _Precondition = new List<Hl7.Fhir.Model.ConditionDefinition.PreconditionComponent>(); return _Precondition; }
            set { _Precondition = value; OnPropertyChanged("Precondition"); }
        }
        
        private List<Hl7.Fhir.Model.ConditionDefinition.PreconditionComponent> _Precondition;
        
        /// <summary>
        /// Appropriate team for this condition
        /// </summary>
        [FhirElement("team", Order=340)]
        [CLSCompliant(false)]
		[References("CareTeam")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ResourceReference> Team
        {
            get { if(_Team==null) _Team = new List<Hl7.Fhir.Model.ResourceReference>(); return _Team; }
            set { _Team = value; OnPropertyChanged("Team"); }
        }
        
        private List<Hl7.Fhir.Model.ResourceReference> _Team;
        
        /// <summary>
        /// Questionnaire for this condition
        /// </summary>
        [FhirElement("questionnaire", Order=350)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ConditionDefinition.QuestionnaireComponent> Questionnaire
        {
            get { if(_Questionnaire==null) _Questionnaire = new List<Hl7.Fhir.Model.ConditionDefinition.QuestionnaireComponent>(); return _Questionnaire; }
            set { _Questionnaire = value; OnPropertyChanged("Questionnaire"); }
        }
        
        private List<Hl7.Fhir.Model.ConditionDefinition.QuestionnaireComponent> _Questionnaire;
        
        /// <summary>
        /// Plan that is appropriate
        /// </summary>
        [FhirElement("plan", Order=360)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ConditionDefinition.PlanComponent> Plan
        {
            get { if(_Plan==null) _Plan = new List<Hl7.Fhir.Model.ConditionDefinition.PlanComponent>(); return _Plan; }
            set { _Plan = value; OnPropertyChanged("Plan"); }
        }
        
        private List<Hl7.Fhir.Model.ConditionDefinition.PlanComponent> _Plan;
        

        public static ElementDefinition.ConstraintComponent ConditionDefinition_CNL_0 = new ElementDefinition.ConstraintComponent()
        { 
            Expression = "name.matches('[A-Z]([A-Za-z0-9_]){0,254}')",
            Key = "cnl-0",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Name should be usable as an identifier for the module by machine processing applications such as code generation",
            Xpath = "not(exists(f:name/@value)) or matches(f:name/@value, '[A-Z]([A-Za-z0-9_]){0,254}')"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(ConditionDefinition_CNL_0);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ConditionDefinition;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(UrlElement != null) dest.UrlElement = (Hl7.Fhir.Model.FhirUri)UrlElement.DeepCopy();
                if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
                if(VersionElement != null) dest.VersionElement = (Hl7.Fhir.Model.FhirString)VersionElement.DeepCopy();
                if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
                if(TitleElement != null) dest.TitleElement = (Hl7.Fhir.Model.FhirString)TitleElement.DeepCopy();
                if(SubtitleElement != null) dest.SubtitleElement = (Hl7.Fhir.Model.FhirString)SubtitleElement.DeepCopy();
                if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.PublicationStatus>)StatusElement.DeepCopy();
                if(ExperimentalElement != null) dest.ExperimentalElement = (Hl7.Fhir.Model.FhirBoolean)ExperimentalElement.DeepCopy();
                if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.FhirDateTime)DateElement.DeepCopy();
                if(PublisherElement != null) dest.PublisherElement = (Hl7.Fhir.Model.FhirString)PublisherElement.DeepCopy();
                if(Contact != null) dest.Contact = new List<ContactDetail>(Contact.DeepCopy());
                if(Description != null) dest.Description = (Hl7.Fhir.Model.Markdown)Description.DeepCopy();
                if(UseContext != null) dest.UseContext = new List<UsageContext>(UseContext.DeepCopy());
                if(Jurisdiction != null) dest.Jurisdiction = new List<Hl7.Fhir.Model.CodeableConcept>(Jurisdiction.DeepCopy());
                if(Code != null) dest.Code = (Hl7.Fhir.Model.CodeableConcept)Code.DeepCopy();
                if(Severity != null) dest.Severity = (Hl7.Fhir.Model.CodeableConcept)Severity.DeepCopy();
                if(BodySite != null) dest.BodySite = (Hl7.Fhir.Model.CodeableConcept)BodySite.DeepCopy();
                if(Stage != null) dest.Stage = (Hl7.Fhir.Model.CodeableConcept)Stage.DeepCopy();
                if(HasSeverityElement != null) dest.HasSeverityElement = (Hl7.Fhir.Model.FhirBoolean)HasSeverityElement.DeepCopy();
                if(HasBodySiteElement != null) dest.HasBodySiteElement = (Hl7.Fhir.Model.FhirBoolean)HasBodySiteElement.DeepCopy();
                if(HasStageElement != null) dest.HasStageElement = (Hl7.Fhir.Model.FhirBoolean)HasStageElement.DeepCopy();
                if(DefinitionElement != null) dest.DefinitionElement = new List<Hl7.Fhir.Model.FhirUri>(DefinitionElement.DeepCopy());
                if(Observation != null) dest.Observation = new List<Hl7.Fhir.Model.ConditionDefinition.ObservationComponent>(Observation.DeepCopy());
                if(Medication != null) dest.Medication = new List<Hl7.Fhir.Model.ConditionDefinition.MedicationComponent>(Medication.DeepCopy());
                if(Precondition != null) dest.Precondition = new List<Hl7.Fhir.Model.ConditionDefinition.PreconditionComponent>(Precondition.DeepCopy());
                if(Team != null) dest.Team = new List<Hl7.Fhir.Model.ResourceReference>(Team.DeepCopy());
                if(Questionnaire != null) dest.Questionnaire = new List<Hl7.Fhir.Model.ConditionDefinition.QuestionnaireComponent>(Questionnaire.DeepCopy());
                if(Plan != null) dest.Plan = new List<Hl7.Fhir.Model.ConditionDefinition.PlanComponent>(Plan.DeepCopy());
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new ConditionDefinition());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ConditionDefinition;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
            if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if( !DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;
            if( !DeepComparable.Matches(SubtitleElement, otherT.SubtitleElement)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if( !DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.Matches(PublisherElement, otherT.PublisherElement)) return false;
            if( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if( !DeepComparable.Matches(Description, otherT.Description)) return false;
            if( !DeepComparable.Matches(UseContext, otherT.UseContext)) return false;
            if( !DeepComparable.Matches(Jurisdiction, otherT.Jurisdiction)) return false;
            if( !DeepComparable.Matches(Code, otherT.Code)) return false;
            if( !DeepComparable.Matches(Severity, otherT.Severity)) return false;
            if( !DeepComparable.Matches(BodySite, otherT.BodySite)) return false;
            if( !DeepComparable.Matches(Stage, otherT.Stage)) return false;
            if( !DeepComparable.Matches(HasSeverityElement, otherT.HasSeverityElement)) return false;
            if( !DeepComparable.Matches(HasBodySiteElement, otherT.HasBodySiteElement)) return false;
            if( !DeepComparable.Matches(HasStageElement, otherT.HasStageElement)) return false;
            if( !DeepComparable.Matches(DefinitionElement, otherT.DefinitionElement)) return false;
            if( !DeepComparable.Matches(Observation, otherT.Observation)) return false;
            if( !DeepComparable.Matches(Medication, otherT.Medication)) return false;
            if( !DeepComparable.Matches(Precondition, otherT.Precondition)) return false;
            if( !DeepComparable.Matches(Team, otherT.Team)) return false;
            if( !DeepComparable.Matches(Questionnaire, otherT.Questionnaire)) return false;
            if( !DeepComparable.Matches(Plan, otherT.Plan)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ConditionDefinition;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
            if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if( !DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;
            if( !DeepComparable.IsExactly(SubtitleElement, otherT.SubtitleElement)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if( !DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.IsExactly(PublisherElement, otherT.PublisherElement)) return false;
            if( !DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if( !DeepComparable.IsExactly(Description, otherT.Description)) return false;
            if( !DeepComparable.IsExactly(UseContext, otherT.UseContext)) return false;
            if( !DeepComparable.IsExactly(Jurisdiction, otherT.Jurisdiction)) return false;
            if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if( !DeepComparable.IsExactly(Severity, otherT.Severity)) return false;
            if( !DeepComparable.IsExactly(BodySite, otherT.BodySite)) return false;
            if( !DeepComparable.IsExactly(Stage, otherT.Stage)) return false;
            if( !DeepComparable.IsExactly(HasSeverityElement, otherT.HasSeverityElement)) return false;
            if( !DeepComparable.IsExactly(HasBodySiteElement, otherT.HasBodySiteElement)) return false;
            if( !DeepComparable.IsExactly(HasStageElement, otherT.HasStageElement)) return false;
            if( !DeepComparable.IsExactly(DefinitionElement, otherT.DefinitionElement)) return false;
            if( !DeepComparable.IsExactly(Observation, otherT.Observation)) return false;
            if( !DeepComparable.IsExactly(Medication, otherT.Medication)) return false;
            if( !DeepComparable.IsExactly(Precondition, otherT.Precondition)) return false;
            if( !DeepComparable.IsExactly(Team, otherT.Team)) return false;
            if( !DeepComparable.IsExactly(Questionnaire, otherT.Questionnaire)) return false;
            if( !DeepComparable.IsExactly(Plan, otherT.Plan)) return false;
            
            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
				if (UrlElement != null) yield return UrlElement;
				foreach (var elem in Identifier) { if (elem != null) yield return elem; }
				if (VersionElement != null) yield return VersionElement;
				if (NameElement != null) yield return NameElement;
				if (TitleElement != null) yield return TitleElement;
				if (SubtitleElement != null) yield return SubtitleElement;
				if (StatusElement != null) yield return StatusElement;
				if (ExperimentalElement != null) yield return ExperimentalElement;
				if (DateElement != null) yield return DateElement;
				if (PublisherElement != null) yield return PublisherElement;
				foreach (var elem in Contact) { if (elem != null) yield return elem; }
				if (Description != null) yield return Description;
				foreach (var elem in UseContext) { if (elem != null) yield return elem; }
				foreach (var elem in Jurisdiction) { if (elem != null) yield return elem; }
				if (Code != null) yield return Code;
				if (Severity != null) yield return Severity;
				if (BodySite != null) yield return BodySite;
				if (Stage != null) yield return Stage;
				if (HasSeverityElement != null) yield return HasSeverityElement;
				if (HasBodySiteElement != null) yield return HasBodySiteElement;
				if (HasStageElement != null) yield return HasStageElement;
				foreach (var elem in DefinitionElement) { if (elem != null) yield return elem; }
				foreach (var elem in Observation) { if (elem != null) yield return elem; }
				foreach (var elem in Medication) { if (elem != null) yield return elem; }
				foreach (var elem in Precondition) { if (elem != null) yield return elem; }
				foreach (var elem in Team) { if (elem != null) yield return elem; }
				foreach (var elem in Questionnaire) { if (elem != null) yield return elem; }
				foreach (var elem in Plan) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        public override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (UrlElement != null) yield return new ElementValue("url", UrlElement);
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (VersionElement != null) yield return new ElementValue("version", VersionElement);
                if (NameElement != null) yield return new ElementValue("name", NameElement);
                if (TitleElement != null) yield return new ElementValue("title", TitleElement);
                if (SubtitleElement != null) yield return new ElementValue("subtitle", SubtitleElement);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (ExperimentalElement != null) yield return new ElementValue("experimental", ExperimentalElement);
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (PublisherElement != null) yield return new ElementValue("publisher", PublisherElement);
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
                if (Description != null) yield return new ElementValue("description", Description);
                foreach (var elem in UseContext) { if (elem != null) yield return new ElementValue("useContext", elem); }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return new ElementValue("jurisdiction", elem); }
                if (Code != null) yield return new ElementValue("code", Code);
                if (Severity != null) yield return new ElementValue("severity", Severity);
                if (BodySite != null) yield return new ElementValue("bodySite", BodySite);
                if (Stage != null) yield return new ElementValue("stage", Stage);
                if (HasSeverityElement != null) yield return new ElementValue("hasSeverity", HasSeverityElement);
                if (HasBodySiteElement != null) yield return new ElementValue("hasBodySite", HasBodySiteElement);
                if (HasStageElement != null) yield return new ElementValue("hasStage", HasStageElement);
                foreach (var elem in DefinitionElement) { if (elem != null) yield return new ElementValue("definition", elem); }
                foreach (var elem in Observation) { if (elem != null) yield return new ElementValue("observation", elem); }
                foreach (var elem in Medication) { if (elem != null) yield return new ElementValue("medication", elem); }
                foreach (var elem in Precondition) { if (elem != null) yield return new ElementValue("precondition", elem); }
                foreach (var elem in Team) { if (elem != null) yield return new ElementValue("team", elem); }
                foreach (var elem in Questionnaire) { if (elem != null) yield return new ElementValue("questionnaire", elem); }
                foreach (var elem in Plan) { if (elem != null) yield return new ElementValue("plan", elem); }
            }
        }

    }
    
}
