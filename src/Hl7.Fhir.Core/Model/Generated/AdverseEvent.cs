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
    /// Medical care, research study or other healthcare event causing physical injury
    /// </summary>
    [FhirType("AdverseEvent", IsResource=true)]
    [DataContract]
    public partial class AdverseEvent : Hl7.Fhir.Model.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.AdverseEvent; } }
        [NotMapped]
        public override string TypeName { get { return "AdverseEvent"; } }
        
        /// <summary>
        /// Codes identifying the lifecycle stage of an adverse event.
        /// (url: http://hl7.org/fhir/ValueSet/adverse-event-status)
        /// </summary>
        [FhirEnumeration("AdverseEventStatus")]
        public enum AdverseEventStatus
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/event-status)
            /// </summary>
            [EnumLiteral("in-progress", "http://hl7.org/fhir/event-status"), Description("In Progress")]
            InProgress,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/event-status)
            /// </summary>
            [EnumLiteral("completed", "http://hl7.org/fhir/event-status"), Description("Completed")]
            Completed,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/event-status)
            /// </summary>
            [EnumLiteral("entered-in-error", "http://hl7.org/fhir/event-status"), Description("Entered in Error")]
            EnteredInError,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/event-status)
            /// </summary>
            [EnumLiteral("unknown", "http://hl7.org/fhir/event-status"), Description("Unknown")]
            Unknown,
        }

        /// <summary>
        /// Overall nature of the adverse event, e.g. real or potential.
        /// (url: http://hl7.org/fhir/ValueSet/adverse-event-actuality)
        /// </summary>
        [FhirEnumeration("AdverseEventActuality")]
        public enum AdverseEventActuality
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/adverse-event-actuality)
            /// </summary>
            [EnumLiteral("actual", "http://hl7.org/fhir/adverse-event-actuality"), Description("Adverse Event")]
            Actual,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/adverse-event-actuality)
            /// </summary>
            [EnumLiteral("potential", "http://hl7.org/fhir/adverse-event-actuality"), Description("Potential Adverse Event")]
            Potential,
        }

        [FhirType("ParticipantComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class ParticipantComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ParticipantComponent"; } }
            
            /// <summary>
            /// Type of involvement
            /// </summary>
            [FhirElement("function", InSummary=true, Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Function
            {
                get { return _Function; }
                set { _Function = value; OnPropertyChanged("Function"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Function;
            
            /// <summary>
            /// Who was involved in the adverse event or the potential adverse event
            /// </summary>
            [FhirElement("actor", InSummary=true, Order=50)]
            [CLSCompliant(false)]
			[References("Practitioner","PractitionerRole","Organization","CareTeam","Patient","Device","RelatedPerson")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference Actor
            {
                get { return _Actor; }
                set { _Actor = value; OnPropertyChanged("Actor"); }
            }
            
            private Hl7.Fhir.Model.ResourceReference _Actor;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ParticipantComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Function != null) dest.Function = (Hl7.Fhir.Model.CodeableConcept)Function.DeepCopy();
                    if(Actor != null) dest.Actor = (Hl7.Fhir.Model.ResourceReference)Actor.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ParticipantComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ParticipantComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Function, otherT.Function)) return false;
                if( !DeepComparable.Matches(Actor, otherT.Actor)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ParticipantComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Function, otherT.Function)) return false;
                if( !DeepComparable.IsExactly(Actor, otherT.Actor)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Function != null) yield return Function;
                    if (Actor != null) yield return Actor;
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Function != null) yield return new ElementValue("function", Function);
                    if (Actor != null) yield return new ElementValue("actor", Actor);
                }
            }

            
        }
        
        
        [FhirType("SuspectEntityComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class SuspectEntityComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "SuspectEntityComponent"; } }
            
            /// <summary>
            /// Refers to the specific entity that caused the adverse event
            /// </summary>
            [FhirElement("instance", InSummary=true, Order=40, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
			[AllowedTypes(typeof(Hl7.Fhir.Model.CodeableConcept),typeof(Hl7.Fhir.Model.ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Element Instance
            {
                get { return _Instance; }
                set { _Instance = value; OnPropertyChanged("Instance"); }
            }
            
            private Hl7.Fhir.Model.Element _Instance;
            
            /// <summary>
            /// Information on the possible cause of the event
            /// </summary>
            [FhirElement("causality", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.AdverseEvent.CausalityComponent Causality
            {
                get { return _Causality; }
                set { _Causality = value; OnPropertyChanged("Causality"); }
            }
            
            private Hl7.Fhir.Model.AdverseEvent.CausalityComponent _Causality;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SuspectEntityComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Instance != null) dest.Instance = (Hl7.Fhir.Model.Element)Instance.DeepCopy();
                    if(Causality != null) dest.Causality = (Hl7.Fhir.Model.AdverseEvent.CausalityComponent)Causality.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new SuspectEntityComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SuspectEntityComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Instance, otherT.Instance)) return false;
                if( !DeepComparable.Matches(Causality, otherT.Causality)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SuspectEntityComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Instance, otherT.Instance)) return false;
                if( !DeepComparable.IsExactly(Causality, otherT.Causality)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Instance != null) yield return Instance;
                    if (Causality != null) yield return Causality;
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Instance != null) yield return new ElementValue("instance", Instance);
                    if (Causality != null) yield return new ElementValue("causality", Causality);
                }
            }

            
        }
        
        
        [FhirType("CausalityComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class CausalityComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "CausalityComponent"; } }
            
            /// <summary>
            /// Method of evaluating the relatedness of the suspected entity to the event
            /// </summary>
            [FhirElement("assessmentMethod", InSummary=true, Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept AssessmentMethod
            {
                get { return _AssessmentMethod; }
                set { _AssessmentMethod = value; OnPropertyChanged("AssessmentMethod"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _AssessmentMethod;
            
            /// <summary>
            /// Result of the assessment regarding the relatedness of the suspected entity to the event
            /// </summary>
            [FhirElement("entityRelatedness", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept EntityRelatedness
            {
                get { return _EntityRelatedness; }
                set { _EntityRelatedness = value; OnPropertyChanged("EntityRelatedness"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _EntityRelatedness;
            
            /// <summary>
            /// Author of the information on the possible cause of the event
            /// </summary>
            [FhirElement("author", InSummary=true, Order=60)]
            [CLSCompliant(false)]
			[References("Practitioner","PractitionerRole","Patient","RelatedPerson")]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference Author
            {
                get { return _Author; }
                set { _Author = value; OnPropertyChanged("Author"); }
            }
            
            private Hl7.Fhir.Model.ResourceReference _Author;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CausalityComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(AssessmentMethod != null) dest.AssessmentMethod = (Hl7.Fhir.Model.CodeableConcept)AssessmentMethod.DeepCopy();
                    if(EntityRelatedness != null) dest.EntityRelatedness = (Hl7.Fhir.Model.CodeableConcept)EntityRelatedness.DeepCopy();
                    if(Author != null) dest.Author = (Hl7.Fhir.Model.ResourceReference)Author.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new CausalityComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as CausalityComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(AssessmentMethod, otherT.AssessmentMethod)) return false;
                if( !DeepComparable.Matches(EntityRelatedness, otherT.EntityRelatedness)) return false;
                if( !DeepComparable.Matches(Author, otherT.Author)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CausalityComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(AssessmentMethod, otherT.AssessmentMethod)) return false;
                if( !DeepComparable.IsExactly(EntityRelatedness, otherT.EntityRelatedness)) return false;
                if( !DeepComparable.IsExactly(Author, otherT.Author)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (AssessmentMethod != null) yield return AssessmentMethod;
                    if (EntityRelatedness != null) yield return EntityRelatedness;
                    if (Author != null) yield return Author;
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (AssessmentMethod != null) yield return new ElementValue("assessmentMethod", AssessmentMethod);
                    if (EntityRelatedness != null) yield return new ElementValue("entityRelatedness", EntityRelatedness);
                    if (Author != null) yield return new ElementValue("author", Author);
                }
            }

            
        }
        
        
        [FhirType("ContributingFactorComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class ContributingFactorComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ContributingFactorComponent"; } }
            
            /// <summary>
            /// Item suspected to have increased the probability or severity of the adverse event
            /// </summary>
            [FhirElement("item", InSummary=true, Order=40, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
			[AllowedTypes(typeof(Hl7.Fhir.Model.ResourceReference),typeof(Hl7.Fhir.Model.CodeableConcept))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Element Item
            {
                get { return _Item; }
                set { _Item = value; OnPropertyChanged("Item"); }
            }
            
            private Hl7.Fhir.Model.Element _Item;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ContributingFactorComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Item != null) dest.Item = (Hl7.Fhir.Model.Element)Item.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ContributingFactorComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ContributingFactorComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Item, otherT.Item)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ContributingFactorComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Item, otherT.Item)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Item != null) yield return Item;
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Item != null) yield return new ElementValue("item", Item);
                }
            }

            
        }
        
        
        [FhirType("PreventiveActionComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class PreventiveActionComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "PreventiveActionComponent"; } }
            
            /// <summary>
            /// Action that contributed to avoiding the adverse event
            /// </summary>
            [FhirElement("item", InSummary=true, Order=40, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
			[AllowedTypes(typeof(Hl7.Fhir.Model.ResourceReference),typeof(Hl7.Fhir.Model.CodeableConcept))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Element Item
            {
                get { return _Item; }
                set { _Item = value; OnPropertyChanged("Item"); }
            }
            
            private Hl7.Fhir.Model.Element _Item;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PreventiveActionComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Item != null) dest.Item = (Hl7.Fhir.Model.Element)Item.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new PreventiveActionComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PreventiveActionComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Item, otherT.Item)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PreventiveActionComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Item, otherT.Item)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Item != null) yield return Item;
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Item != null) yield return new ElementValue("item", Item);
                }
            }

            
        }
        
        
        [FhirType("MitigatingActionComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class MitigatingActionComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "MitigatingActionComponent"; } }
            
            /// <summary>
            /// Ameliorating action taken after the adverse event occured in order to reduce the extent of harm
            /// </summary>
            [FhirElement("item", InSummary=true, Order=40, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
			[AllowedTypes(typeof(Hl7.Fhir.Model.ResourceReference),typeof(Hl7.Fhir.Model.CodeableConcept))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Element Item
            {
                get { return _Item; }
                set { _Item = value; OnPropertyChanged("Item"); }
            }
            
            private Hl7.Fhir.Model.Element _Item;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as MitigatingActionComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Item != null) dest.Item = (Hl7.Fhir.Model.Element)Item.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new MitigatingActionComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as MitigatingActionComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Item, otherT.Item)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as MitigatingActionComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Item, otherT.Item)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Item != null) yield return Item;
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Item != null) yield return new ElementValue("item", Item);
                }
            }

            
        }
        
        
        [FhirType("SupportingInfoComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class SupportingInfoComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "SupportingInfoComponent"; } }
            
            /// <summary>
            /// Subject medical history or document relevant to this adverse event
            /// </summary>
            [FhirElement("item", InSummary=true, Order=40, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
			[AllowedTypes(typeof(Hl7.Fhir.Model.ResourceReference),typeof(Hl7.Fhir.Model.CodeableConcept))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Element Item
            {
                get { return _Item; }
                set { _Item = value; OnPropertyChanged("Item"); }
            }
            
            private Hl7.Fhir.Model.Element _Item;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SupportingInfoComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Item != null) dest.Item = (Hl7.Fhir.Model.Element)Item.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new SupportingInfoComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SupportingInfoComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Item, otherT.Item)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SupportingInfoComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Item, otherT.Item)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Item != null) yield return Item;
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Item != null) yield return new ElementValue("item", Item);
                }
            }

            
        }
        
        
        /// <summary>
        /// Business identifier for the event
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=90)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Identifier> Identifier
        {
            get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private List<Hl7.Fhir.Model.Identifier> _Identifier;
        
        /// <summary>
        /// in-progress | completed | entered-in-error | unknown
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<Hl7.Fhir.Model.AdverseEvent.AdverseEventStatus> StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        
        private Code<Hl7.Fhir.Model.AdverseEvent.AdverseEventStatus> _StatusElement;
        
        /// <summary>
        /// in-progress | completed | entered-in-error | unknown
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.AdverseEvent.AdverseEventStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.AdverseEvent.AdverseEventStatus>(value);
                OnPropertyChanged("Status");
            }
        }
        
        /// <summary>
        /// actual | potential
        /// </summary>
        [FhirElement("actuality", InSummary=true, Order=110)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<Hl7.Fhir.Model.AdverseEvent.AdverseEventActuality> ActualityElement
        {
            get { return _ActualityElement; }
            set { _ActualityElement = value; OnPropertyChanged("ActualityElement"); }
        }
        
        private Code<Hl7.Fhir.Model.AdverseEvent.AdverseEventActuality> _ActualityElement;
        
        /// <summary>
        /// actual | potential
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.AdverseEvent.AdverseEventActuality? Actuality
        {
            get { return ActualityElement != null ? ActualityElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  ActualityElement = null; 
                else
                  ActualityElement = new Code<Hl7.Fhir.Model.AdverseEvent.AdverseEventActuality>(value);
                OnPropertyChanged("Actuality");
            }
        }
        
        /// <summary>
        /// wrong-patient | procedure-mishap | medication-mishap | device | unsafe-physical-environment | hospital-aquired-infection | wrong-body-site
        /// </summary>
        [FhirElement("category", InSummary=true, Order=120)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> Category
        {
            get { if(_Category==null) _Category = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Category; }
            set { _Category = value; OnPropertyChanged("Category"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _Category;
        
        /// <summary>
        /// Event or incident that occurred or was averted
        /// </summary>
        [FhirElement("code", InSummary=true, Order=130)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Code
        {
            get { return _Code; }
            set { _Code = value; OnPropertyChanged("Code"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Code;
        
        /// <summary>
        /// Subject impacted by event
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=140)]
        [CLSCompliant(false)]
		[References("Patient","Group","Practitioner","RelatedPerson")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Subject
        {
            get { return _Subject; }
            set { _Subject = value; OnPropertyChanged("Subject"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Subject;
        
        /// <summary>
        /// The Encounter associated with the start of the AdverseEvent
        /// </summary>
        [FhirElement("encounter", InSummary=true, Order=150)]
        [CLSCompliant(false)]
		[References("Encounter")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Encounter
        {
            get { return _Encounter; }
            set { _Encounter = value; OnPropertyChanged("Encounter"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Encounter;
        
        /// <summary>
        /// When the event occurred
        /// </summary>
        [FhirElement("occurrence", InSummary=true, Order=160, Choice=ChoiceType.DatatypeChoice)]
        [CLSCompliant(false)]
		[AllowedTypes(typeof(Hl7.Fhir.Model.FhirDateTime),typeof(Hl7.Fhir.Model.Period),typeof(Hl7.Fhir.Model.Timing))]
        [DataMember]
        public Hl7.Fhir.Model.Element Occurrence
        {
            get { return _Occurrence; }
            set { _Occurrence = value; OnPropertyChanged("Occurrence"); }
        }
        
        private Hl7.Fhir.Model.Element _Occurrence;
        
        /// <summary>
        /// When the event was detected
        /// </summary>
        [FhirElement("detected", InSummary=true, Order=170)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime DetectedElement
        {
            get { return _DetectedElement; }
            set { _DetectedElement = value; OnPropertyChanged("DetectedElement"); }
        }
        
        private Hl7.Fhir.Model.FhirDateTime _DetectedElement;
        
        /// <summary>
        /// When the event was detected
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Detected
        {
            get { return DetectedElement != null ? DetectedElement.Value : null; }
            set
            {
                if (value == null)
                  DetectedElement = null; 
                else
                  DetectedElement = new Hl7.Fhir.Model.FhirDateTime(value);
                OnPropertyChanged("Detected");
            }
        }
        
        /// <summary>
        /// When the event was recorded
        /// </summary>
        [FhirElement("recordedDate", InSummary=true, Order=180)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime RecordedDateElement
        {
            get { return _RecordedDateElement; }
            set { _RecordedDateElement = value; OnPropertyChanged("RecordedDateElement"); }
        }
        
        private Hl7.Fhir.Model.FhirDateTime _RecordedDateElement;
        
        /// <summary>
        /// When the event was recorded
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string RecordedDate
        {
            get { return RecordedDateElement != null ? RecordedDateElement.Value : null; }
            set
            {
                if (value == null)
                  RecordedDateElement = null; 
                else
                  RecordedDateElement = new Hl7.Fhir.Model.FhirDateTime(value);
                OnPropertyChanged("RecordedDate");
            }
        }
        
        /// <summary>
        /// Effect on the subject due to this event
        /// </summary>
        [FhirElement("resultingCondition", InSummary=true, Order=190)]
        [CLSCompliant(false)]
		[References("Condition")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ResourceReference> ResultingCondition
        {
            get { if(_ResultingCondition==null) _ResultingCondition = new List<Hl7.Fhir.Model.ResourceReference>(); return _ResultingCondition; }
            set { _ResultingCondition = value; OnPropertyChanged("ResultingCondition"); }
        }
        
        private List<Hl7.Fhir.Model.ResourceReference> _ResultingCondition;
        
        /// <summary>
        /// Location where adverse event occurred
        /// </summary>
        [FhirElement("location", InSummary=true, Order=200)]
        [CLSCompliant(false)]
		[References("Location")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Location
        {
            get { return _Location; }
            set { _Location = value; OnPropertyChanged("Location"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Location;
        
        /// <summary>
        /// Seriousness or gravity of the event
        /// </summary>
        [FhirElement("seriousness", InSummary=true, Order=210)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Seriousness
        {
            get { return _Seriousness; }
            set { _Seriousness = value; OnPropertyChanged("Seriousness"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Seriousness;
        
        /// <summary>
        /// Type of outcome from the adverse event
        /// </summary>
        [FhirElement("outcome", InSummary=true, Order=220)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Outcome
        {
            get { return _Outcome; }
            set { _Outcome = value; OnPropertyChanged("Outcome"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Outcome;
        
        /// <summary>
        /// Who recorded the adverse event
        /// </summary>
        [FhirElement("recorder", InSummary=true, Order=230)]
        [CLSCompliant(false)]
		[References("Patient","Practitioner","PractitionerRole","RelatedPerson")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Recorder
        {
            get { return _Recorder; }
            set { _Recorder = value; OnPropertyChanged("Recorder"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Recorder;
        
        /// <summary>
        /// Who was involved in the adverse event or the potential adverse event and what they did
        /// </summary>
        [FhirElement("participant", InSummary=true, Order=240)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.AdverseEvent.ParticipantComponent> Participant
        {
            get { if(_Participant==null) _Participant = new List<Hl7.Fhir.Model.AdverseEvent.ParticipantComponent>(); return _Participant; }
            set { _Participant = value; OnPropertyChanged("Participant"); }
        }
        
        private List<Hl7.Fhir.Model.AdverseEvent.ParticipantComponent> _Participant;
        
        /// <summary>
        /// The suspected agent causing the adverse event
        /// </summary>
        [FhirElement("suspectEntity", InSummary=true, Order=250)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.AdverseEvent.SuspectEntityComponent> SuspectEntity
        {
            get { if(_SuspectEntity==null) _SuspectEntity = new List<Hl7.Fhir.Model.AdverseEvent.SuspectEntityComponent>(); return _SuspectEntity; }
            set { _SuspectEntity = value; OnPropertyChanged("SuspectEntity"); }
        }
        
        private List<Hl7.Fhir.Model.AdverseEvent.SuspectEntityComponent> _SuspectEntity;
        
        /// <summary>
        /// Contributing factors suspected to have increased the probability or severity of the adverse event
        /// </summary>
        [FhirElement("contributingFactor", InSummary=true, Order=260)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.AdverseEvent.ContributingFactorComponent> ContributingFactor
        {
            get { if(_ContributingFactor==null) _ContributingFactor = new List<Hl7.Fhir.Model.AdverseEvent.ContributingFactorComponent>(); return _ContributingFactor; }
            set { _ContributingFactor = value; OnPropertyChanged("ContributingFactor"); }
        }
        
        private List<Hl7.Fhir.Model.AdverseEvent.ContributingFactorComponent> _ContributingFactor;
        
        /// <summary>
        /// Preventive actions that contributed to avoiding the adverse event
        /// </summary>
        [FhirElement("preventiveAction", InSummary=true, Order=270)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.AdverseEvent.PreventiveActionComponent> PreventiveAction
        {
            get { if(_PreventiveAction==null) _PreventiveAction = new List<Hl7.Fhir.Model.AdverseEvent.PreventiveActionComponent>(); return _PreventiveAction; }
            set { _PreventiveAction = value; OnPropertyChanged("PreventiveAction"); }
        }
        
        private List<Hl7.Fhir.Model.AdverseEvent.PreventiveActionComponent> _PreventiveAction;
        
        /// <summary>
        /// Ameliorating actions taken after the adverse event occured in order to reduce the extent of harm
        /// </summary>
        [FhirElement("mitigatingAction", InSummary=true, Order=280)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.AdverseEvent.MitigatingActionComponent> MitigatingAction
        {
            get { if(_MitigatingAction==null) _MitigatingAction = new List<Hl7.Fhir.Model.AdverseEvent.MitigatingActionComponent>(); return _MitigatingAction; }
            set { _MitigatingAction = value; OnPropertyChanged("MitigatingAction"); }
        }
        
        private List<Hl7.Fhir.Model.AdverseEvent.MitigatingActionComponent> _MitigatingAction;
        
        /// <summary>
        /// Supporting information relevant to the event
        /// </summary>
        [FhirElement("supportingInfo", InSummary=true, Order=290)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.AdverseEvent.SupportingInfoComponent> SupportingInfo
        {
            get { if(_SupportingInfo==null) _SupportingInfo = new List<Hl7.Fhir.Model.AdverseEvent.SupportingInfoComponent>(); return _SupportingInfo; }
            set { _SupportingInfo = value; OnPropertyChanged("SupportingInfo"); }
        }
        
        private List<Hl7.Fhir.Model.AdverseEvent.SupportingInfoComponent> _SupportingInfo;
        
        /// <summary>
        /// Research study that the subject is enrolled in
        /// </summary>
        [FhirElement("study", InSummary=true, Order=300)]
        [CLSCompliant(false)]
		[References("ResearchStudy")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ResourceReference> Study
        {
            get { if(_Study==null) _Study = new List<Hl7.Fhir.Model.ResourceReference>(); return _Study; }
            set { _Study = value; OnPropertyChanged("Study"); }
        }
        
        private List<Hl7.Fhir.Model.ResourceReference> _Study;
        

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as AdverseEvent;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
                if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.AdverseEvent.AdverseEventStatus>)StatusElement.DeepCopy();
                if(ActualityElement != null) dest.ActualityElement = (Code<Hl7.Fhir.Model.AdverseEvent.AdverseEventActuality>)ActualityElement.DeepCopy();
                if(Category != null) dest.Category = new List<Hl7.Fhir.Model.CodeableConcept>(Category.DeepCopy());
                if(Code != null) dest.Code = (Hl7.Fhir.Model.CodeableConcept)Code.DeepCopy();
                if(Subject != null) dest.Subject = (Hl7.Fhir.Model.ResourceReference)Subject.DeepCopy();
                if(Encounter != null) dest.Encounter = (Hl7.Fhir.Model.ResourceReference)Encounter.DeepCopy();
                if(Occurrence != null) dest.Occurrence = (Hl7.Fhir.Model.Element)Occurrence.DeepCopy();
                if(DetectedElement != null) dest.DetectedElement = (Hl7.Fhir.Model.FhirDateTime)DetectedElement.DeepCopy();
                if(RecordedDateElement != null) dest.RecordedDateElement = (Hl7.Fhir.Model.FhirDateTime)RecordedDateElement.DeepCopy();
                if(ResultingCondition != null) dest.ResultingCondition = new List<Hl7.Fhir.Model.ResourceReference>(ResultingCondition.DeepCopy());
                if(Location != null) dest.Location = (Hl7.Fhir.Model.ResourceReference)Location.DeepCopy();
                if(Seriousness != null) dest.Seriousness = (Hl7.Fhir.Model.CodeableConcept)Seriousness.DeepCopy();
                if(Outcome != null) dest.Outcome = (Hl7.Fhir.Model.CodeableConcept)Outcome.DeepCopy();
                if(Recorder != null) dest.Recorder = (Hl7.Fhir.Model.ResourceReference)Recorder.DeepCopy();
                if(Participant != null) dest.Participant = new List<Hl7.Fhir.Model.AdverseEvent.ParticipantComponent>(Participant.DeepCopy());
                if(SuspectEntity != null) dest.SuspectEntity = new List<Hl7.Fhir.Model.AdverseEvent.SuspectEntityComponent>(SuspectEntity.DeepCopy());
                if(ContributingFactor != null) dest.ContributingFactor = new List<Hl7.Fhir.Model.AdverseEvent.ContributingFactorComponent>(ContributingFactor.DeepCopy());
                if(PreventiveAction != null) dest.PreventiveAction = new List<Hl7.Fhir.Model.AdverseEvent.PreventiveActionComponent>(PreventiveAction.DeepCopy());
                if(MitigatingAction != null) dest.MitigatingAction = new List<Hl7.Fhir.Model.AdverseEvent.MitigatingActionComponent>(MitigatingAction.DeepCopy());
                if(SupportingInfo != null) dest.SupportingInfo = new List<Hl7.Fhir.Model.AdverseEvent.SupportingInfoComponent>(SupportingInfo.DeepCopy());
                if(Study != null) dest.Study = new List<Hl7.Fhir.Model.ResourceReference>(Study.DeepCopy());
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new AdverseEvent());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as AdverseEvent;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(ActualityElement, otherT.ActualityElement)) return false;
            if( !DeepComparable.Matches(Category, otherT.Category)) return false;
            if( !DeepComparable.Matches(Code, otherT.Code)) return false;
            if( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if( !DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
            if( !DeepComparable.Matches(Occurrence, otherT.Occurrence)) return false;
            if( !DeepComparable.Matches(DetectedElement, otherT.DetectedElement)) return false;
            if( !DeepComparable.Matches(RecordedDateElement, otherT.RecordedDateElement)) return false;
            if( !DeepComparable.Matches(ResultingCondition, otherT.ResultingCondition)) return false;
            if( !DeepComparable.Matches(Location, otherT.Location)) return false;
            if( !DeepComparable.Matches(Seriousness, otherT.Seriousness)) return false;
            if( !DeepComparable.Matches(Outcome, otherT.Outcome)) return false;
            if( !DeepComparable.Matches(Recorder, otherT.Recorder)) return false;
            if( !DeepComparable.Matches(Participant, otherT.Participant)) return false;
            if( !DeepComparable.Matches(SuspectEntity, otherT.SuspectEntity)) return false;
            if( !DeepComparable.Matches(ContributingFactor, otherT.ContributingFactor)) return false;
            if( !DeepComparable.Matches(PreventiveAction, otherT.PreventiveAction)) return false;
            if( !DeepComparable.Matches(MitigatingAction, otherT.MitigatingAction)) return false;
            if( !DeepComparable.Matches(SupportingInfo, otherT.SupportingInfo)) return false;
            if( !DeepComparable.Matches(Study, otherT.Study)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as AdverseEvent;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(ActualityElement, otherT.ActualityElement)) return false;
            if( !DeepComparable.IsExactly(Category, otherT.Category)) return false;
            if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if( !DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if( !DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
            if( !DeepComparable.IsExactly(Occurrence, otherT.Occurrence)) return false;
            if( !DeepComparable.IsExactly(DetectedElement, otherT.DetectedElement)) return false;
            if( !DeepComparable.IsExactly(RecordedDateElement, otherT.RecordedDateElement)) return false;
            if( !DeepComparable.IsExactly(ResultingCondition, otherT.ResultingCondition)) return false;
            if( !DeepComparable.IsExactly(Location, otherT.Location)) return false;
            if( !DeepComparable.IsExactly(Seriousness, otherT.Seriousness)) return false;
            if( !DeepComparable.IsExactly(Outcome, otherT.Outcome)) return false;
            if( !DeepComparable.IsExactly(Recorder, otherT.Recorder)) return false;
            if( !DeepComparable.IsExactly(Participant, otherT.Participant)) return false;
            if( !DeepComparable.IsExactly(SuspectEntity, otherT.SuspectEntity)) return false;
            if( !DeepComparable.IsExactly(ContributingFactor, otherT.ContributingFactor)) return false;
            if( !DeepComparable.IsExactly(PreventiveAction, otherT.PreventiveAction)) return false;
            if( !DeepComparable.IsExactly(MitigatingAction, otherT.MitigatingAction)) return false;
            if( !DeepComparable.IsExactly(SupportingInfo, otherT.SupportingInfo)) return false;
            if( !DeepComparable.IsExactly(Study, otherT.Study)) return false;
            
            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
				foreach (var elem in Identifier) { if (elem != null) yield return elem; }
				if (StatusElement != null) yield return StatusElement;
				if (ActualityElement != null) yield return ActualityElement;
				foreach (var elem in Category) { if (elem != null) yield return elem; }
				if (Code != null) yield return Code;
				if (Subject != null) yield return Subject;
				if (Encounter != null) yield return Encounter;
				if (Occurrence != null) yield return Occurrence;
				if (DetectedElement != null) yield return DetectedElement;
				if (RecordedDateElement != null) yield return RecordedDateElement;
				foreach (var elem in ResultingCondition) { if (elem != null) yield return elem; }
				if (Location != null) yield return Location;
				if (Seriousness != null) yield return Seriousness;
				if (Outcome != null) yield return Outcome;
				if (Recorder != null) yield return Recorder;
				foreach (var elem in Participant) { if (elem != null) yield return elem; }
				foreach (var elem in SuspectEntity) { if (elem != null) yield return elem; }
				foreach (var elem in ContributingFactor) { if (elem != null) yield return elem; }
				foreach (var elem in PreventiveAction) { if (elem != null) yield return elem; }
				foreach (var elem in MitigatingAction) { if (elem != null) yield return elem; }
				foreach (var elem in SupportingInfo) { if (elem != null) yield return elem; }
				foreach (var elem in Study) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        public override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (ActualityElement != null) yield return new ElementValue("actuality", ActualityElement);
                foreach (var elem in Category) { if (elem != null) yield return new ElementValue("category", elem); }
                if (Code != null) yield return new ElementValue("code", Code);
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (Encounter != null) yield return new ElementValue("encounter", Encounter);
                if (Occurrence != null) yield return new ElementValue("occurrence", Occurrence);
                if (DetectedElement != null) yield return new ElementValue("detected", DetectedElement);
                if (RecordedDateElement != null) yield return new ElementValue("recordedDate", RecordedDateElement);
                foreach (var elem in ResultingCondition) { if (elem != null) yield return new ElementValue("resultingCondition", elem); }
                if (Location != null) yield return new ElementValue("location", Location);
                if (Seriousness != null) yield return new ElementValue("seriousness", Seriousness);
                if (Outcome != null) yield return new ElementValue("outcome", Outcome);
                if (Recorder != null) yield return new ElementValue("recorder", Recorder);
                foreach (var elem in Participant) { if (elem != null) yield return new ElementValue("participant", elem); }
                foreach (var elem in SuspectEntity) { if (elem != null) yield return new ElementValue("suspectEntity", elem); }
                foreach (var elem in ContributingFactor) { if (elem != null) yield return new ElementValue("contributingFactor", elem); }
                foreach (var elem in PreventiveAction) { if (elem != null) yield return new ElementValue("preventiveAction", elem); }
                foreach (var elem in MitigatingAction) { if (elem != null) yield return new ElementValue("mitigatingAction", elem); }
                foreach (var elem in SupportingInfo) { if (elem != null) yield return new ElementValue("supportingInfo", elem); }
                foreach (var elem in Study) { if (elem != null) yield return new ElementValue("study", elem); }
            }
        }

    }
    
}
