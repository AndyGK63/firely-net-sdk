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
    /// Kind of specimen
    /// </summary>
    [FhirType("SpecimenDefinition", IsResource=true)]
    [DataContract]
    public partial class SpecimenDefinition : Hl7.Fhir.Model.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.SpecimenDefinition; } }
        [NotMapped]
        public override string TypeName { get { return "SpecimenDefinition"; } }
        
        /// <summary>
        /// Degree of preference of a type of conditioned specimen.
        /// (url: http://hl7.org/fhir/ValueSet/specimen-contained-preference)
        /// </summary>
        [FhirEnumeration("SpecimenContainedPreference")]
        public enum SpecimenContainedPreference
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/specimen-contained-preference)
            /// </summary>
            [EnumLiteral("preferred", "http://hl7.org/fhir/specimen-contained-preference"), Description("Preferred")]
            Preferred,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/specimen-contained-preference)
            /// </summary>
            [EnumLiteral("alternate", "http://hl7.org/fhir/specimen-contained-preference"), Description("Alternate")]
            Alternate,
        }

        [FhirType("TypeTestedComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class TypeTestedComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "TypeTestedComponent"; } }
            
            /// <summary>
            /// Primary or secondary specimen
            /// </summary>
            [FhirElement("isDerived", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.FhirBoolean IsDerivedElement
            {
                get { return _IsDerivedElement; }
                set { _IsDerivedElement = value; OnPropertyChanged("IsDerivedElement"); }
            }
            
            private Hl7.Fhir.Model.FhirBoolean _IsDerivedElement;
            
            /// <summary>
            /// Primary or secondary specimen
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public bool? IsDerived
            {
                get { return IsDerivedElement != null ? IsDerivedElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        IsDerivedElement = null; 
                    else
                        IsDerivedElement = new Hl7.Fhir.Model.FhirBoolean(value);
                    OnPropertyChanged("IsDerived");
                }
            }
            
            /// <summary>
            /// Type of intended specimen
            /// </summary>
            [FhirElement("type", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Type;
            
            /// <summary>
            /// preferred | alternate
            /// </summary>
            [FhirElement("preference", Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<Hl7.Fhir.Model.SpecimenDefinition.SpecimenContainedPreference> PreferenceElement
            {
                get { return _PreferenceElement; }
                set { _PreferenceElement = value; OnPropertyChanged("PreferenceElement"); }
            }
            
            private Code<Hl7.Fhir.Model.SpecimenDefinition.SpecimenContainedPreference> _PreferenceElement;
            
            /// <summary>
            /// preferred | alternate
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public Hl7.Fhir.Model.SpecimenDefinition.SpecimenContainedPreference? Preference
            {
                get { return PreferenceElement != null ? PreferenceElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        PreferenceElement = null; 
                    else
                        PreferenceElement = new Code<Hl7.Fhir.Model.SpecimenDefinition.SpecimenContainedPreference>(value);
                    OnPropertyChanged("Preference");
                }
            }
            
            /// <summary>
            /// The specimen's container
            /// </summary>
            [FhirElement("container", Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.SpecimenDefinition.ContainerComponent Container
            {
                get { return _Container; }
                set { _Container = value; OnPropertyChanged("Container"); }
            }
            
            private Hl7.Fhir.Model.SpecimenDefinition.ContainerComponent _Container;
            
            /// <summary>
            /// Requirements for specimen delivery and special handling
            /// </summary>
            [FhirElement("requirement", Order=80)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString RequirementElement
            {
                get { return _RequirementElement; }
                set { _RequirementElement = value; OnPropertyChanged("RequirementElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _RequirementElement;
            
            /// <summary>
            /// Requirements for specimen delivery and special handling
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Requirement
            {
                get { return RequirementElement != null ? RequirementElement.Value : null; }
                set
                {
                    if (value == null)
                        RequirementElement = null; 
                    else
                        RequirementElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Requirement");
                }
            }
            
            /// <summary>
            /// The usual time for retaining this kind of specimen
            /// </summary>
            [FhirElement("retentionTime", Order=90)]
            [DataMember]
            public Duration RetentionTime
            {
                get { return _RetentionTime; }
                set { _RetentionTime = value; OnPropertyChanged("RetentionTime"); }
            }
            
            private Duration _RetentionTime;
            
            /// <summary>
            /// Specimen for single use only
            /// </summary>
            [FhirElement("singleUse", Order=100)]
            [DataMember]
            public Hl7.Fhir.Model.FhirBoolean SingleUseElement
            {
                get { return _SingleUseElement; }
                set { _SingleUseElement = value; OnPropertyChanged("SingleUseElement"); }
            }
            
            private Hl7.Fhir.Model.FhirBoolean _SingleUseElement;
            
            /// <summary>
            /// Specimen for single use only
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public bool? SingleUse
            {
                get { return SingleUseElement != null ? SingleUseElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        SingleUseElement = null; 
                    else
                        SingleUseElement = new Hl7.Fhir.Model.FhirBoolean(value);
                    OnPropertyChanged("SingleUse");
                }
            }
            
            /// <summary>
            /// Criterion specified for specimen rejection
            /// </summary>
            [FhirElement("rejectionCriterion", Order=110)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.CodeableConcept> RejectionCriterion
            {
                get { if(_RejectionCriterion==null) _RejectionCriterion = new List<Hl7.Fhir.Model.CodeableConcept>(); return _RejectionCriterion; }
                set { _RejectionCriterion = value; OnPropertyChanged("RejectionCriterion"); }
            }
            
            private List<Hl7.Fhir.Model.CodeableConcept> _RejectionCriterion;
            
            /// <summary>
            /// Specimen handling before testing
            /// </summary>
            [FhirElement("handling", Order=120)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.SpecimenDefinition.HandlingComponent> Handling
            {
                get { if(_Handling==null) _Handling = new List<Hl7.Fhir.Model.SpecimenDefinition.HandlingComponent>(); return _Handling; }
                set { _Handling = value; OnPropertyChanged("Handling"); }
            }
            
            private List<Hl7.Fhir.Model.SpecimenDefinition.HandlingComponent> _Handling;
            
            /// <summary>
            /// Where the specimen will be tested
            /// </summary>
            [FhirElement("testingDestination", Order=130)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.CodeableConcept> TestingDestination
            {
                get { if(_TestingDestination==null) _TestingDestination = new List<Hl7.Fhir.Model.CodeableConcept>(); return _TestingDestination; }
                set { _TestingDestination = value; OnPropertyChanged("TestingDestination"); }
            }
            
            private List<Hl7.Fhir.Model.CodeableConcept> _TestingDestination;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TypeTestedComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(IsDerivedElement != null) dest.IsDerivedElement = (Hl7.Fhir.Model.FhirBoolean)IsDerivedElement.DeepCopy();
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
                    if(PreferenceElement != null) dest.PreferenceElement = (Code<Hl7.Fhir.Model.SpecimenDefinition.SpecimenContainedPreference>)PreferenceElement.DeepCopy();
                    if(Container != null) dest.Container = (Hl7.Fhir.Model.SpecimenDefinition.ContainerComponent)Container.DeepCopy();
                    if(RequirementElement != null) dest.RequirementElement = (Hl7.Fhir.Model.FhirString)RequirementElement.DeepCopy();
                    if(RetentionTime != null) dest.RetentionTime = (Duration)RetentionTime.DeepCopy();
                    if(SingleUseElement != null) dest.SingleUseElement = (Hl7.Fhir.Model.FhirBoolean)SingleUseElement.DeepCopy();
                    if(RejectionCriterion != null) dest.RejectionCriterion = new List<Hl7.Fhir.Model.CodeableConcept>(RejectionCriterion.DeepCopy());
                    if(Handling != null) dest.Handling = new List<Hl7.Fhir.Model.SpecimenDefinition.HandlingComponent>(Handling.DeepCopy());
                    if(TestingDestination != null) dest.TestingDestination = new List<Hl7.Fhir.Model.CodeableConcept>(TestingDestination.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new TypeTestedComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as TypeTestedComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(IsDerivedElement, otherT.IsDerivedElement)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(PreferenceElement, otherT.PreferenceElement)) return false;
                if( !DeepComparable.Matches(Container, otherT.Container)) return false;
                if( !DeepComparable.Matches(RequirementElement, otherT.RequirementElement)) return false;
                if( !DeepComparable.Matches(RetentionTime, otherT.RetentionTime)) return false;
                if( !DeepComparable.Matches(SingleUseElement, otherT.SingleUseElement)) return false;
                if( !DeepComparable.Matches(RejectionCriterion, otherT.RejectionCriterion)) return false;
                if( !DeepComparable.Matches(Handling, otherT.Handling)) return false;
                if( !DeepComparable.Matches(TestingDestination, otherT.TestingDestination)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TypeTestedComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(IsDerivedElement, otherT.IsDerivedElement)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(PreferenceElement, otherT.PreferenceElement)) return false;
                if( !DeepComparable.IsExactly(Container, otherT.Container)) return false;
                if( !DeepComparable.IsExactly(RequirementElement, otherT.RequirementElement)) return false;
                if( !DeepComparable.IsExactly(RetentionTime, otherT.RetentionTime)) return false;
                if( !DeepComparable.IsExactly(SingleUseElement, otherT.SingleUseElement)) return false;
                if( !DeepComparable.IsExactly(RejectionCriterion, otherT.RejectionCriterion)) return false;
                if( !DeepComparable.IsExactly(Handling, otherT.Handling)) return false;
                if( !DeepComparable.IsExactly(TestingDestination, otherT.TestingDestination)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (IsDerivedElement != null) yield return IsDerivedElement;
                    if (Type != null) yield return Type;
                    if (PreferenceElement != null) yield return PreferenceElement;
                    if (Container != null) yield return Container;
                    if (RequirementElement != null) yield return RequirementElement;
                    if (RetentionTime != null) yield return RetentionTime;
                    if (SingleUseElement != null) yield return SingleUseElement;
                    foreach (var elem in RejectionCriterion) { if (elem != null) yield return elem; }
                    foreach (var elem in Handling) { if (elem != null) yield return elem; }
                    foreach (var elem in TestingDestination) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (IsDerivedElement != null) yield return new ElementValue("isDerived", IsDerivedElement);
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (PreferenceElement != null) yield return new ElementValue("preference", PreferenceElement);
                    if (Container != null) yield return new ElementValue("container", Container);
                    if (RequirementElement != null) yield return new ElementValue("requirement", RequirementElement);
                    if (RetentionTime != null) yield return new ElementValue("retentionTime", RetentionTime);
                    if (SingleUseElement != null) yield return new ElementValue("singleUse", SingleUseElement);
                    foreach (var elem in RejectionCriterion) { if (elem != null) yield return new ElementValue("rejectionCriterion", elem); }
                    foreach (var elem in Handling) { if (elem != null) yield return new ElementValue("handling", elem); }
                    foreach (var elem in TestingDestination) { if (elem != null) yield return new ElementValue("testingDestination", elem); }
                }
            }

            
        }
        
        
        [FhirType("ContainerComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class ContainerComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ContainerComponent"; } }
            
            /// <summary>
            /// The material type used for the container
            /// </summary>
            [FhirElement("material", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Material
            {
                get { return _Material; }
                set { _Material = value; OnPropertyChanged("Material"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Material;
            
            /// <summary>
            /// Kind of container associated with the kind of specimen
            /// </summary>
            [FhirElement("type", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Type;
            
            /// <summary>
            /// Color of container cap
            /// </summary>
            [FhirElement("cap", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Cap
            {
                get { return _Cap; }
                set { _Cap = value; OnPropertyChanged("Cap"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Cap;
            
            /// <summary>
            /// The description of the kind of container
            /// </summary>
            [FhirElement("description", Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString DescriptionElement
            {
                get { return _DescriptionElement; }
                set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _DescriptionElement;
            
            /// <summary>
            /// The description of the kind of container
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Description
            {
                get { return DescriptionElement != null ? DescriptionElement.Value : null; }
                set
                {
                    if (value == null)
                        DescriptionElement = null; 
                    else
                        DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Description");
                }
            }
            
            /// <summary>
            /// The capacity of this kind of container
            /// </summary>
            [FhirElement("capacity", Order=80)]
            [DataMember]
            public Hl7.Fhir.Model.SimpleQuantity Capacity
            {
                get { return _Capacity; }
                set { _Capacity = value; OnPropertyChanged("Capacity"); }
            }
            
            private Hl7.Fhir.Model.SimpleQuantity _Capacity;
            
            /// <summary>
            /// Minimum volume
            /// </summary>
            [FhirElement("minimumVolume", Order=90, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
			[AllowedTypes(typeof(Hl7.Fhir.Model.SimpleQuantity),typeof(Hl7.Fhir.Model.FhirString))]
            [DataMember]
            public Hl7.Fhir.Model.Element MinimumVolume
            {
                get { return _MinimumVolume; }
                set { _MinimumVolume = value; OnPropertyChanged("MinimumVolume"); }
            }
            
            private Hl7.Fhir.Model.Element _MinimumVolume;
            
            /// <summary>
            /// Additive associated with container
            /// </summary>
            [FhirElement("additive", Order=100)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.SpecimenDefinition.AdditiveComponent> Additive
            {
                get { if(_Additive==null) _Additive = new List<Hl7.Fhir.Model.SpecimenDefinition.AdditiveComponent>(); return _Additive; }
                set { _Additive = value; OnPropertyChanged("Additive"); }
            }
            
            private List<Hl7.Fhir.Model.SpecimenDefinition.AdditiveComponent> _Additive;
            
            /// <summary>
            /// Special processing applied to the container for this specimen type
            /// </summary>
            [FhirElement("preparation", Order=110)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString PreparationElement
            {
                get { return _PreparationElement; }
                set { _PreparationElement = value; OnPropertyChanged("PreparationElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _PreparationElement;
            
            /// <summary>
            /// Special processing applied to the container for this specimen type
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Preparation
            {
                get { return PreparationElement != null ? PreparationElement.Value : null; }
                set
                {
                    if (value == null)
                        PreparationElement = null; 
                    else
                        PreparationElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Preparation");
                }
            }
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ContainerComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Material != null) dest.Material = (Hl7.Fhir.Model.CodeableConcept)Material.DeepCopy();
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
                    if(Cap != null) dest.Cap = (Hl7.Fhir.Model.CodeableConcept)Cap.DeepCopy();
                    if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.FhirString)DescriptionElement.DeepCopy();
                    if(Capacity != null) dest.Capacity = (Hl7.Fhir.Model.SimpleQuantity)Capacity.DeepCopy();
                    if(MinimumVolume != null) dest.MinimumVolume = (Hl7.Fhir.Model.Element)MinimumVolume.DeepCopy();
                    if(Additive != null) dest.Additive = new List<Hl7.Fhir.Model.SpecimenDefinition.AdditiveComponent>(Additive.DeepCopy());
                    if(PreparationElement != null) dest.PreparationElement = (Hl7.Fhir.Model.FhirString)PreparationElement.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ContainerComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ContainerComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Material, otherT.Material)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(Cap, otherT.Cap)) return false;
                if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if( !DeepComparable.Matches(Capacity, otherT.Capacity)) return false;
                if( !DeepComparable.Matches(MinimumVolume, otherT.MinimumVolume)) return false;
                if( !DeepComparable.Matches(Additive, otherT.Additive)) return false;
                if( !DeepComparable.Matches(PreparationElement, otherT.PreparationElement)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ContainerComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Material, otherT.Material)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(Cap, otherT.Cap)) return false;
                if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if( !DeepComparable.IsExactly(Capacity, otherT.Capacity)) return false;
                if( !DeepComparable.IsExactly(MinimumVolume, otherT.MinimumVolume)) return false;
                if( !DeepComparable.IsExactly(Additive, otherT.Additive)) return false;
                if( !DeepComparable.IsExactly(PreparationElement, otherT.PreparationElement)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Material != null) yield return Material;
                    if (Type != null) yield return Type;
                    if (Cap != null) yield return Cap;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (Capacity != null) yield return Capacity;
                    if (MinimumVolume != null) yield return MinimumVolume;
                    foreach (var elem in Additive) { if (elem != null) yield return elem; }
                    if (PreparationElement != null) yield return PreparationElement;
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Material != null) yield return new ElementValue("material", Material);
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (Cap != null) yield return new ElementValue("cap", Cap);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    if (Capacity != null) yield return new ElementValue("capacity", Capacity);
                    if (MinimumVolume != null) yield return new ElementValue("minimumVolume", MinimumVolume);
                    foreach (var elem in Additive) { if (elem != null) yield return new ElementValue("additive", elem); }
                    if (PreparationElement != null) yield return new ElementValue("preparation", PreparationElement);
                }
            }

            
        }
        
        
        [FhirType("AdditiveComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class AdditiveComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "AdditiveComponent"; } }
            
            /// <summary>
            /// Additive associated with container
            /// </summary>
            [FhirElement("additive", Order=40, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
			[AllowedTypes(typeof(Hl7.Fhir.Model.CodeableConcept),typeof(Hl7.Fhir.Model.ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Element Additive
            {
                get { return _Additive; }
                set { _Additive = value; OnPropertyChanged("Additive"); }
            }
            
            private Hl7.Fhir.Model.Element _Additive;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AdditiveComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Additive != null) dest.Additive = (Hl7.Fhir.Model.Element)Additive.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new AdditiveComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as AdditiveComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Additive, otherT.Additive)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AdditiveComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Additive, otherT.Additive)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Additive != null) yield return Additive;
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Additive != null) yield return new ElementValue("additive", Additive);
                }
            }

            
        }
        
        
        [FhirType("HandlingComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class HandlingComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "HandlingComponent"; } }
            
            /// <summary>
            /// Qualifies the interval of temperature
            /// </summary>
            [FhirElement("temperatureQualifier", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept TemperatureQualifier
            {
                get { return _TemperatureQualifier; }
                set { _TemperatureQualifier = value; OnPropertyChanged("TemperatureQualifier"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _TemperatureQualifier;
            
            /// <summary>
            /// Temperature range for these handling instructions
            /// </summary>
            [FhirElement("temperatureRange", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.Range TemperatureRange
            {
                get { return _TemperatureRange; }
                set { _TemperatureRange = value; OnPropertyChanged("TemperatureRange"); }
            }
            
            private Hl7.Fhir.Model.Range _TemperatureRange;
            
            /// <summary>
            /// Maximum preservation time
            /// </summary>
            [FhirElement("maxDuration", Order=60)]
            [DataMember]
            public Duration MaxDuration
            {
                get { return _MaxDuration; }
                set { _MaxDuration = value; OnPropertyChanged("MaxDuration"); }
            }
            
            private Duration _MaxDuration;
            
            /// <summary>
            /// Preservation instruction
            /// </summary>
            [FhirElement("instruction", Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString InstructionElement
            {
                get { return _InstructionElement; }
                set { _InstructionElement = value; OnPropertyChanged("InstructionElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _InstructionElement;
            
            /// <summary>
            /// Preservation instruction
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Instruction
            {
                get { return InstructionElement != null ? InstructionElement.Value : null; }
                set
                {
                    if (value == null)
                        InstructionElement = null; 
                    else
                        InstructionElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Instruction");
                }
            }
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as HandlingComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(TemperatureQualifier != null) dest.TemperatureQualifier = (Hl7.Fhir.Model.CodeableConcept)TemperatureQualifier.DeepCopy();
                    if(TemperatureRange != null) dest.TemperatureRange = (Hl7.Fhir.Model.Range)TemperatureRange.DeepCopy();
                    if(MaxDuration != null) dest.MaxDuration = (Duration)MaxDuration.DeepCopy();
                    if(InstructionElement != null) dest.InstructionElement = (Hl7.Fhir.Model.FhirString)InstructionElement.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new HandlingComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as HandlingComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(TemperatureQualifier, otherT.TemperatureQualifier)) return false;
                if( !DeepComparable.Matches(TemperatureRange, otherT.TemperatureRange)) return false;
                if( !DeepComparable.Matches(MaxDuration, otherT.MaxDuration)) return false;
                if( !DeepComparable.Matches(InstructionElement, otherT.InstructionElement)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as HandlingComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(TemperatureQualifier, otherT.TemperatureQualifier)) return false;
                if( !DeepComparable.IsExactly(TemperatureRange, otherT.TemperatureRange)) return false;
                if( !DeepComparable.IsExactly(MaxDuration, otherT.MaxDuration)) return false;
                if( !DeepComparable.IsExactly(InstructionElement, otherT.InstructionElement)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (TemperatureQualifier != null) yield return TemperatureQualifier;
                    if (TemperatureRange != null) yield return TemperatureRange;
                    if (MaxDuration != null) yield return MaxDuration;
                    if (InstructionElement != null) yield return InstructionElement;
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (TemperatureQualifier != null) yield return new ElementValue("temperatureQualifier", TemperatureQualifier);
                    if (TemperatureRange != null) yield return new ElementValue("temperatureRange", TemperatureRange);
                    if (MaxDuration != null) yield return new ElementValue("maxDuration", MaxDuration);
                    if (InstructionElement != null) yield return new ElementValue("instruction", InstructionElement);
                }
            }

            
        }
        
        
        /// <summary>
        /// Logical canonical URL to reference this SpecimenDefinition (globally unique)
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
        /// Logical canonical URL to reference this SpecimenDefinition (globally unique)
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
        /// Business identifier
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
        /// Business version of the SpecimenDefinition
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
        /// Business version of the SpecimenDefinition
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
        /// Name for this SpecimenDefinition (Human friendly)
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
        /// Name for this SpecimenDefinition (Human friendly)
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
        /// Based on FHIR definition of another SpecimenDefinition
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
        /// Based on FHIR definition of another SpecimenDefinition
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
        /// If this SpecimenDefinition is not for real usage
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
        /// If this SpecimenDefinition is not for real usage
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
        /// Type of subject for specimen collection
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
        /// The name of the individual or organization that published the SpecimenDefinition
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
        /// Natural language description of the SpecimenDefinition
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
        /// Intended jurisdiction for this SpecimenDefinition (if applicable)
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
        /// Why this SpecimenDefinition is defined
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
        /// When SpecimenDefinition was approved by publisher
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
        /// When SpecimenDefinition was approved by publisher
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
        /// The date on which the asset content was last reviewed
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
        /// The date on which the asset content was last reviewed
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
        /// The effective date range for the SpecimenDefinition
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
        /// Kind of material to collect
        /// </summary>
        [FhirElement("typeCollected", InSummary=true, Order=290)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept TypeCollected
        {
            get { return _TypeCollected; }
            set { _TypeCollected = value; OnPropertyChanged("TypeCollected"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _TypeCollected;
        
        /// <summary>
        /// Patient preparation for collection
        /// </summary>
        [FhirElement("patientPreparation", InSummary=true, Order=300)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> PatientPreparation
        {
            get { if(_PatientPreparation==null) _PatientPreparation = new List<Hl7.Fhir.Model.CodeableConcept>(); return _PatientPreparation; }
            set { _PatientPreparation = value; OnPropertyChanged("PatientPreparation"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _PatientPreparation;
        
        /// <summary>
        /// Time aspect for collection
        /// </summary>
        [FhirElement("timeAspect", InSummary=true, Order=310)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString TimeAspectElement
        {
            get { return _TimeAspectElement; }
            set { _TimeAspectElement = value; OnPropertyChanged("TimeAspectElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _TimeAspectElement;
        
        /// <summary>
        /// Time aspect for collection
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string TimeAspect
        {
            get { return TimeAspectElement != null ? TimeAspectElement.Value : null; }
            set
            {
                if (value == null)
                  TimeAspectElement = null; 
                else
                  TimeAspectElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("TimeAspect");
            }
        }
        
        /// <summary>
        /// Specimen collection procedure
        /// </summary>
        [FhirElement("collection", InSummary=true, Order=320)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> Collection
        {
            get { if(_Collection==null) _Collection = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Collection; }
            set { _Collection = value; OnPropertyChanged("Collection"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _Collection;
        
        /// <summary>
        /// Specimen in container intended for testing by lab
        /// </summary>
        [FhirElement("typeTested", Order=330)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.SpecimenDefinition.TypeTestedComponent> TypeTested
        {
            get { if(_TypeTested==null) _TypeTested = new List<Hl7.Fhir.Model.SpecimenDefinition.TypeTestedComponent>(); return _TypeTested; }
            set { _TypeTested = value; OnPropertyChanged("TypeTested"); }
        }
        
        private List<Hl7.Fhir.Model.SpecimenDefinition.TypeTestedComponent> _TypeTested;
        

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as SpecimenDefinition;
            
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
                if(TypeCollected != null) dest.TypeCollected = (Hl7.Fhir.Model.CodeableConcept)TypeCollected.DeepCopy();
                if(PatientPreparation != null) dest.PatientPreparation = new List<Hl7.Fhir.Model.CodeableConcept>(PatientPreparation.DeepCopy());
                if(TimeAspectElement != null) dest.TimeAspectElement = (Hl7.Fhir.Model.FhirString)TimeAspectElement.DeepCopy();
                if(Collection != null) dest.Collection = new List<Hl7.Fhir.Model.CodeableConcept>(Collection.DeepCopy());
                if(TypeTested != null) dest.TypeTested = new List<Hl7.Fhir.Model.SpecimenDefinition.TypeTestedComponent>(TypeTested.DeepCopy());
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new SpecimenDefinition());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as SpecimenDefinition;
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
            if( !DeepComparable.Matches(TypeCollected, otherT.TypeCollected)) return false;
            if( !DeepComparable.Matches(PatientPreparation, otherT.PatientPreparation)) return false;
            if( !DeepComparable.Matches(TimeAspectElement, otherT.TimeAspectElement)) return false;
            if( !DeepComparable.Matches(Collection, otherT.Collection)) return false;
            if( !DeepComparable.Matches(TypeTested, otherT.TypeTested)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as SpecimenDefinition;
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
            if( !DeepComparable.IsExactly(TypeCollected, otherT.TypeCollected)) return false;
            if( !DeepComparable.IsExactly(PatientPreparation, otherT.PatientPreparation)) return false;
            if( !DeepComparable.IsExactly(TimeAspectElement, otherT.TimeAspectElement)) return false;
            if( !DeepComparable.IsExactly(Collection, otherT.Collection)) return false;
            if( !DeepComparable.IsExactly(TypeTested, otherT.TypeTested)) return false;
            
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
				if (TypeCollected != null) yield return TypeCollected;
				foreach (var elem in PatientPreparation) { if (elem != null) yield return elem; }
				if (TimeAspectElement != null) yield return TimeAspectElement;
				foreach (var elem in Collection) { if (elem != null) yield return elem; }
				foreach (var elem in TypeTested) { if (elem != null) yield return elem; }
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
                if (TypeCollected != null) yield return new ElementValue("typeCollected", TypeCollected);
                foreach (var elem in PatientPreparation) { if (elem != null) yield return new ElementValue("patientPreparation", elem); }
                if (TimeAspectElement != null) yield return new ElementValue("timeAspect", TimeAspectElement);
                foreach (var elem in Collection) { if (elem != null) yield return new ElementValue("collection", elem); }
                foreach (var elem in TypeTested) { if (elem != null) yield return new ElementValue("typeTested", elem); }
            }
        }

    }
    
}
