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
    /// Single evidence bit
    /// </summary>
    [FhirType("Evidence", IsResource=true)]
    [DataContract]
    public partial class Evidence : Hl7.Fhir.Model.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Evidence; } }
        [NotMapped]
        public override string TypeName { get { return "Evidence"; } }
        
        [FhirType("ReferentGroupComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class ReferentGroupComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ReferentGroupComponent"; } }
            
            /// <summary>
            /// Textual description of referent group
            /// </summary>
            [FhirElement("description", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.Markdown Description
            {
                get { return _Description; }
                set { _Description = value; OnPropertyChanged("Description"); }
            }
            
            private Hl7.Fhir.Model.Markdown _Description;
            
            /// <summary>
            /// Footnotes and/or explanatory notes
            /// </summary>
            [FhirElement("note", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.Annotation> Note
            {
                get { if(_Note==null) _Note = new List<Hl7.Fhir.Model.Annotation>(); return _Note; }
                set { _Note = value; OnPropertyChanged("Note"); }
            }
            
            private List<Hl7.Fhir.Model.Annotation> _Note;
            
            /// <summary>
            /// Various information categories of group
            /// </summary>
            [FhirElement("evidenceSource", Order=60)]
            [CLSCompliant(false)]
			[References("Group")]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference EvidenceSource
            {
                get { return _EvidenceSource; }
                set { _EvidenceSource = value; OnPropertyChanged("EvidenceSource"); }
            }
            
            private Hl7.Fhir.Model.ResourceReference _EvidenceSource;
            
            /// <summary>
            /// Non-actual group that is a set of characteristics
            /// </summary>
            [FhirElement("intendedGroup", Order=70)]
            [CLSCompliant(false)]
			[References("Group")]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference IntendedGroup
            {
                get { return _IntendedGroup; }
                set { _IntendedGroup = value; OnPropertyChanged("IntendedGroup"); }
            }
            
            private Hl7.Fhir.Model.ResourceReference _IntendedGroup;
            
            /// <summary>
            /// low | moderate | high | exact
            /// </summary>
            [FhirElement("directnessMatch", Order=80)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept DirectnessMatch
            {
                get { return _DirectnessMatch; }
                set { _DirectnessMatch = value; OnPropertyChanged("DirectnessMatch"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _DirectnessMatch;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ReferentGroupComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Description != null) dest.Description = (Hl7.Fhir.Model.Markdown)Description.DeepCopy();
                    if(Note != null) dest.Note = new List<Hl7.Fhir.Model.Annotation>(Note.DeepCopy());
                    if(EvidenceSource != null) dest.EvidenceSource = (Hl7.Fhir.Model.ResourceReference)EvidenceSource.DeepCopy();
                    if(IntendedGroup != null) dest.IntendedGroup = (Hl7.Fhir.Model.ResourceReference)IntendedGroup.DeepCopy();
                    if(DirectnessMatch != null) dest.DirectnessMatch = (Hl7.Fhir.Model.CodeableConcept)DirectnessMatch.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ReferentGroupComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ReferentGroupComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Description, otherT.Description)) return false;
                if( !DeepComparable.Matches(Note, otherT.Note)) return false;
                if( !DeepComparable.Matches(EvidenceSource, otherT.EvidenceSource)) return false;
                if( !DeepComparable.Matches(IntendedGroup, otherT.IntendedGroup)) return false;
                if( !DeepComparable.Matches(DirectnessMatch, otherT.DirectnessMatch)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ReferentGroupComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Description, otherT.Description)) return false;
                if( !DeepComparable.IsExactly(Note, otherT.Note)) return false;
                if( !DeepComparable.IsExactly(EvidenceSource, otherT.EvidenceSource)) return false;
                if( !DeepComparable.IsExactly(IntendedGroup, otherT.IntendedGroup)) return false;
                if( !DeepComparable.IsExactly(DirectnessMatch, otherT.DirectnessMatch)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Description != null) yield return Description;
                    foreach (var elem in Note) { if (elem != null) yield return elem; }
                    if (EvidenceSource != null) yield return EvidenceSource;
                    if (IntendedGroup != null) yield return IntendedGroup;
                    if (DirectnessMatch != null) yield return DirectnessMatch;
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Description != null) yield return new ElementValue("description", Description);
                    foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
                    if (EvidenceSource != null) yield return new ElementValue("evidenceSource", EvidenceSource);
                    if (IntendedGroup != null) yield return new ElementValue("intendedGroup", IntendedGroup);
                    if (DirectnessMatch != null) yield return new ElementValue("directnessMatch", DirectnessMatch);
                }
            }

            
        }
        
        
        [FhirType("VariableDefinitionComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class VariableDefinitionComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "VariableDefinitionComponent"; } }
            
            /// <summary>
            /// Description of the variable
            /// </summary>
            [FhirElement("description", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.Markdown Description
            {
                get { return _Description; }
                set { _Description = value; OnPropertyChanged("Description"); }
            }
            
            private Hl7.Fhir.Model.Markdown _Description;
            
            /// <summary>
            /// Footnotes and/or explanatory notes
            /// </summary>
            [FhirElement("note", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.Annotation> Note
            {
                get { if(_Note==null) _Note = new List<Hl7.Fhir.Model.Annotation>(); return _Note; }
                set { _Note = value; OnPropertyChanged("Note"); }
            }
            
            private List<Hl7.Fhir.Model.Annotation> _Note;
            
            /// <summary>
            /// exposure | referenceExposure | measuredVariable | confounder
            /// </summary>
            [FhirElement("variableRole", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept VariableRole
            {
                get { return _VariableRole; }
                set { _VariableRole = value; OnPropertyChanged("VariableRole"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _VariableRole;
            
            /// <summary>
            /// Definition of the actual variable related to the statistic(s)
            /// </summary>
            [FhirElement("actualDefinition", InSummary=true, Order=70)]
            [CLSCompliant(false)]
			[References("EvidenceVariable")]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference ActualDefinition
            {
                get { return _ActualDefinition; }
                set { _ActualDefinition = value; OnPropertyChanged("ActualDefinition"); }
            }
            
            private Hl7.Fhir.Model.ResourceReference _ActualDefinition;
            
            /// <summary>
            /// Definition of the intended variable related to the Evidence
            /// </summary>
            [FhirElement("intendedDefinition", Order=80)]
            [CLSCompliant(false)]
			[References("EvidenceVariable")]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference IntendedDefinition
            {
                get { return _IntendedDefinition; }
                set { _IntendedDefinition = value; OnPropertyChanged("IntendedDefinition"); }
            }
            
            private Hl7.Fhir.Model.ResourceReference _IntendedDefinition;
            
            /// <summary>
            /// low | moderate | high | exact
            /// </summary>
            [FhirElement("directnessMatch", Order=90)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept DirectnessMatch
            {
                get { return _DirectnessMatch; }
                set { _DirectnessMatch = value; OnPropertyChanged("DirectnessMatch"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _DirectnessMatch;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as VariableDefinitionComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Description != null) dest.Description = (Hl7.Fhir.Model.Markdown)Description.DeepCopy();
                    if(Note != null) dest.Note = new List<Hl7.Fhir.Model.Annotation>(Note.DeepCopy());
                    if(VariableRole != null) dest.VariableRole = (Hl7.Fhir.Model.CodeableConcept)VariableRole.DeepCopy();
                    if(ActualDefinition != null) dest.ActualDefinition = (Hl7.Fhir.Model.ResourceReference)ActualDefinition.DeepCopy();
                    if(IntendedDefinition != null) dest.IntendedDefinition = (Hl7.Fhir.Model.ResourceReference)IntendedDefinition.DeepCopy();
                    if(DirectnessMatch != null) dest.DirectnessMatch = (Hl7.Fhir.Model.CodeableConcept)DirectnessMatch.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new VariableDefinitionComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as VariableDefinitionComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Description, otherT.Description)) return false;
                if( !DeepComparable.Matches(Note, otherT.Note)) return false;
                if( !DeepComparable.Matches(VariableRole, otherT.VariableRole)) return false;
                if( !DeepComparable.Matches(ActualDefinition, otherT.ActualDefinition)) return false;
                if( !DeepComparable.Matches(IntendedDefinition, otherT.IntendedDefinition)) return false;
                if( !DeepComparable.Matches(DirectnessMatch, otherT.DirectnessMatch)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as VariableDefinitionComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Description, otherT.Description)) return false;
                if( !DeepComparable.IsExactly(Note, otherT.Note)) return false;
                if( !DeepComparable.IsExactly(VariableRole, otherT.VariableRole)) return false;
                if( !DeepComparable.IsExactly(ActualDefinition, otherT.ActualDefinition)) return false;
                if( !DeepComparable.IsExactly(IntendedDefinition, otherT.IntendedDefinition)) return false;
                if( !DeepComparable.IsExactly(DirectnessMatch, otherT.DirectnessMatch)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Description != null) yield return Description;
                    foreach (var elem in Note) { if (elem != null) yield return elem; }
                    if (VariableRole != null) yield return VariableRole;
                    if (ActualDefinition != null) yield return ActualDefinition;
                    if (IntendedDefinition != null) yield return IntendedDefinition;
                    if (DirectnessMatch != null) yield return DirectnessMatch;
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Description != null) yield return new ElementValue("description", Description);
                    foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
                    if (VariableRole != null) yield return new ElementValue("variableRole", VariableRole);
                    if (ActualDefinition != null) yield return new ElementValue("actualDefinition", ActualDefinition);
                    if (IntendedDefinition != null) yield return new ElementValue("intendedDefinition", IntendedDefinition);
                    if (DirectnessMatch != null) yield return new ElementValue("directnessMatch", DirectnessMatch);
                }
            }

            
        }
        
        
        [FhirType("CertaintyComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class CertaintyComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "CertaintyComponent"; } }
            
            /// <summary>
            /// Textual description of certainty
            /// </summary>
            [FhirElement("description", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString DescriptionElement
            {
                get { return _DescriptionElement; }
                set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _DescriptionElement;
            
            /// <summary>
            /// Textual description of certainty
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
            /// Footnotes and/or explanatory notes
            /// </summary>
            [FhirElement("note", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.Annotation Note
            {
                get { return _Note; }
                set { _Note = value; OnPropertyChanged("Note"); }
            }
            
            private Hl7.Fhir.Model.Annotation _Note;
            
            /// <summary>
            /// Rating of certainty
            /// </summary>
            [FhirElement("rating", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.CodeableConcept> Rating
            {
                get { if(_Rating==null) _Rating = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Rating; }
                set { _Rating = value; OnPropertyChanged("Rating"); }
            }
            
            private List<Hl7.Fhir.Model.CodeableConcept> _Rating;
            
            /// <summary>
            /// Subcomponent of certainty
            /// </summary>
            [FhirElement("certaintySubcomponent", Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.Evidence.CertaintySubcomponentComponent> CertaintySubcomponent
            {
                get { if(_CertaintySubcomponent==null) _CertaintySubcomponent = new List<Hl7.Fhir.Model.Evidence.CertaintySubcomponentComponent>(); return _CertaintySubcomponent; }
                set { _CertaintySubcomponent = value; OnPropertyChanged("CertaintySubcomponent"); }
            }
            
            private List<Hl7.Fhir.Model.Evidence.CertaintySubcomponentComponent> _CertaintySubcomponent;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CertaintyComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.FhirString)DescriptionElement.DeepCopy();
                    if(Note != null) dest.Note = (Hl7.Fhir.Model.Annotation)Note.DeepCopy();
                    if(Rating != null) dest.Rating = new List<Hl7.Fhir.Model.CodeableConcept>(Rating.DeepCopy());
                    if(CertaintySubcomponent != null) dest.CertaintySubcomponent = new List<Hl7.Fhir.Model.Evidence.CertaintySubcomponentComponent>(CertaintySubcomponent.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new CertaintyComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as CertaintyComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if( !DeepComparable.Matches(Note, otherT.Note)) return false;
                if( !DeepComparable.Matches(Rating, otherT.Rating)) return false;
                if( !DeepComparable.Matches(CertaintySubcomponent, otherT.CertaintySubcomponent)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CertaintyComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if( !DeepComparable.IsExactly(Note, otherT.Note)) return false;
                if( !DeepComparable.IsExactly(Rating, otherT.Rating)) return false;
                if( !DeepComparable.IsExactly(CertaintySubcomponent, otherT.CertaintySubcomponent)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (Note != null) yield return Note;
                    foreach (var elem in Rating) { if (elem != null) yield return elem; }
                    foreach (var elem in CertaintySubcomponent) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    if (Note != null) yield return new ElementValue("note", Note);
                    foreach (var elem in Rating) { if (elem != null) yield return new ElementValue("rating", elem); }
                    foreach (var elem in CertaintySubcomponent) { if (elem != null) yield return new ElementValue("certaintySubcomponent", elem); }
                }
            }

            
        }
        
        
        [FhirType("CertaintySubcomponentComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class CertaintySubcomponentComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "CertaintySubcomponentComponent"; } }
            
            /// <summary>
            /// Textual description of certainty subcomponent
            /// </summary>
            [FhirElement("description", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString DescriptionElement
            {
                get { return _DescriptionElement; }
                set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _DescriptionElement;
            
            /// <summary>
            /// Textual description of certainty subcomponent
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
            /// Textual note of certainty subcomponent
            /// </summary>
            [FhirElement("note", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.Annotation Note
            {
                get { return _Note; }
                set { _Note = value; OnPropertyChanged("Note"); }
            }
            
            private Hl7.Fhir.Model.Annotation _Note;
            
            /// <summary>
            /// Footnotes and/or explanatory notes
            /// </summary>
            [FhirElement("type", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.CodeableConcept> Type
            {
                get { if(_Type==null) _Type = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private List<Hl7.Fhir.Model.CodeableConcept> _Type;
            
            /// <summary>
            /// Rating of certainty subcomponent
            /// </summary>
            [FhirElement("rating", Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.CodeableConcept> Rating
            {
                get { if(_Rating==null) _Rating = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Rating; }
                set { _Rating = value; OnPropertyChanged("Rating"); }
            }
            
            private List<Hl7.Fhir.Model.CodeableConcept> _Rating;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CertaintySubcomponentComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.FhirString)DescriptionElement.DeepCopy();
                    if(Note != null) dest.Note = (Hl7.Fhir.Model.Annotation)Note.DeepCopy();
                    if(Type != null) dest.Type = new List<Hl7.Fhir.Model.CodeableConcept>(Type.DeepCopy());
                    if(Rating != null) dest.Rating = new List<Hl7.Fhir.Model.CodeableConcept>(Rating.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new CertaintySubcomponentComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as CertaintySubcomponentComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if( !DeepComparable.Matches(Note, otherT.Note)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(Rating, otherT.Rating)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CertaintySubcomponentComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if( !DeepComparable.IsExactly(Note, otherT.Note)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(Rating, otherT.Rating)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (Note != null) yield return Note;
                    foreach (var elem in Type) { if (elem != null) yield return elem; }
                    foreach (var elem in Rating) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    if (Note != null) yield return new ElementValue("note", Note);
                    foreach (var elem in Type) { if (elem != null) yield return new ElementValue("type", elem); }
                    foreach (var elem in Rating) { if (elem != null) yield return new ElementValue("rating", elem); }
                }
            }

            
        }
        
        
        /// <summary>
        /// Canonical identifier for this evidence, represented as a globally unique URI
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
        /// Canonical identifier for this evidence, represented as a globally unique URI
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
        /// Additional identifier for the summary
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
        /// Business version of this summary
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
        /// Business version of this summary
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
        /// Name for this summary (human friendly)
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
        /// Name for this summary (human friendly)
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
        /// draft | active | retired | unknown
        /// </summary>
        [FhirElement("status", InSummary=true, Order=130)]
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
        /// Date last changed
        /// </summary>
        [FhirElement("date", InSummary=true, Order=140)]
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
        /// Use context
        /// </summary>
        [FhirElement("useContext", InSummary=true, Order=150)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<UsageContext> UseContext
        {
            get { if(_UseContext==null) _UseContext = new List<UsageContext>(); return _UseContext; }
            set { _UseContext = value; OnPropertyChanged("UseContext"); }
        }
        
        private List<UsageContext> _UseContext;
        
        /// <summary>
        /// When the summary was approved by publisher
        /// </summary>
        [FhirElement("approvalDate", Order=160)]
        [DataMember]
        public Hl7.Fhir.Model.Date ApprovalDateElement
        {
            get { return _ApprovalDateElement; }
            set { _ApprovalDateElement = value; OnPropertyChanged("ApprovalDateElement"); }
        }
        
        private Hl7.Fhir.Model.Date _ApprovalDateElement;
        
        /// <summary>
        /// When the summary was approved by publisher
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
        /// When the summary was last reviewed
        /// </summary>
        [FhirElement("lastReviewDate", Order=170)]
        [DataMember]
        public Hl7.Fhir.Model.Date LastReviewDateElement
        {
            get { return _LastReviewDateElement; }
            set { _LastReviewDateElement = value; OnPropertyChanged("LastReviewDateElement"); }
        }
        
        private Hl7.Fhir.Model.Date _LastReviewDateElement;
        
        /// <summary>
        /// When the summary was last reviewed
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
        /// Contact detail and role for contributor to summary
        /// </summary>
        [FhirElement("contributor", Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Contributor> Contributor
        {
            get { if(_Contributor==null) _Contributor = new List<Contributor>(); return _Contributor; }
            set { _Contributor = value; OnPropertyChanged("Contributor"); }
        }
        
        private List<Contributor> _Contributor;
        
        /// <summary>
        /// Link or citation to artifact associated with the summary
        /// </summary>
        [FhirElement("relatedArtifact", Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<RelatedArtifact> RelatedArtifact
        {
            get { if(_RelatedArtifact==null) _RelatedArtifact = new List<RelatedArtifact>(); return _RelatedArtifact; }
            set { _RelatedArtifact = value; OnPropertyChanged("RelatedArtifact"); }
        }
        
        private List<RelatedArtifact> _RelatedArtifact;
        
        /// <summary>
        /// Description of the particular summary
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
        /// Declarative description of the Evidence
        /// </summary>
        [FhirElement("assertion", Order=210)]
        [DataMember]
        public Hl7.Fhir.Model.Markdown Assertion
        {
            get { return _Assertion; }
            set { _Assertion = value; OnPropertyChanged("Assertion"); }
        }
        
        private Hl7.Fhir.Model.Markdown _Assertion;
        
        /// <summary>
        /// Footnotes and/or explanatory notes
        /// </summary>
        [FhirElement("note", Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Annotation> Note
        {
            get { if(_Note==null) _Note = new List<Hl7.Fhir.Model.Annotation>(); return _Note; }
            set { _Note = value; OnPropertyChanged("Note"); }
        }
        
        private List<Hl7.Fhir.Model.Annotation> _Note;
        
        /// <summary>
        /// Group being referenced
        /// </summary>
        [FhirElement("referentGroup", InSummary=true, Order=230)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.Evidence.ReferentGroupComponent ReferentGroup
        {
            get { return _ReferentGroup; }
            set { _ReferentGroup = value; OnPropertyChanged("ReferentGroup"); }
        }
        
        private Hl7.Fhir.Model.Evidence.ReferentGroupComponent _ReferentGroup;
        
        /// <summary>
        /// Evidence variable
        /// </summary>
        [FhirElement("variableDefinition", Order=240)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Evidence.VariableDefinitionComponent> VariableDefinition
        {
            get { if(_VariableDefinition==null) _VariableDefinition = new List<Hl7.Fhir.Model.Evidence.VariableDefinitionComponent>(); return _VariableDefinition; }
            set { _VariableDefinition = value; OnPropertyChanged("VariableDefinition"); }
        }
        
        private List<Hl7.Fhir.Model.Evidence.VariableDefinitionComponent> _VariableDefinition;
        
        /// <summary>
        /// The particular type of synthesis if this is a synthesis summary
        /// </summary>
        [FhirElement("synthesisType", Order=250)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept SynthesisType
        {
            get { return _SynthesisType; }
            set { _SynthesisType = value; OnPropertyChanged("SynthesisType"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _SynthesisType;
        
        /// <summary>
        /// The type of study that produced this summary
        /// </summary>
        [FhirElement("studyType", Order=260)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept StudyType
        {
            get { return _StudyType; }
            set { _StudyType = value; OnPropertyChanged("StudyType"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _StudyType;
        
        /// <summary>
        /// Values and parameters for a single statistic
        /// </summary>
        [FhirElement("statistic", Order=270)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Statistic> Statistic
        {
            get { if(_Statistic==null) _Statistic = new List<Statistic>(); return _Statistic; }
            set { _Statistic = value; OnPropertyChanged("Statistic"); }
        }
        
        private List<Statistic> _Statistic;
        
        /// <summary>
        /// An ordered group of statistics
        /// </summary>
        [FhirElement("distribution", Order=280)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<OrderedDistribution> Distribution
        {
            get { if(_Distribution==null) _Distribution = new List<OrderedDistribution>(); return _Distribution; }
            set { _Distribution = value; OnPropertyChanged("Distribution"); }
        }
        
        private List<OrderedDistribution> _Distribution;
        
        /// <summary>
        /// Level of certainty
        /// </summary>
        [FhirElement("certainty", Order=290)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Evidence.CertaintyComponent> Certainty
        {
            get { if(_Certainty==null) _Certainty = new List<Hl7.Fhir.Model.Evidence.CertaintyComponent>(); return _Certainty; }
            set { _Certainty = value; OnPropertyChanged("Certainty"); }
        }
        
        private List<Hl7.Fhir.Model.Evidence.CertaintyComponent> _Certainty;
        

        public static ElementDefinition.ConstraintComponent Evidence_CNL_0 = new ElementDefinition.ConstraintComponent()
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

            InvariantConstraints.Add(Evidence_CNL_0);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Evidence;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(UrlElement != null) dest.UrlElement = (Hl7.Fhir.Model.FhirUri)UrlElement.DeepCopy();
                if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
                if(VersionElement != null) dest.VersionElement = (Hl7.Fhir.Model.FhirString)VersionElement.DeepCopy();
                if(TitleElement != null) dest.TitleElement = (Hl7.Fhir.Model.FhirString)TitleElement.DeepCopy();
                if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.PublicationStatus>)StatusElement.DeepCopy();
                if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.FhirDateTime)DateElement.DeepCopy();
                if(UseContext != null) dest.UseContext = new List<UsageContext>(UseContext.DeepCopy());
                if(ApprovalDateElement != null) dest.ApprovalDateElement = (Hl7.Fhir.Model.Date)ApprovalDateElement.DeepCopy();
                if(LastReviewDateElement != null) dest.LastReviewDateElement = (Hl7.Fhir.Model.Date)LastReviewDateElement.DeepCopy();
                if(Contributor != null) dest.Contributor = new List<Contributor>(Contributor.DeepCopy());
                if(RelatedArtifact != null) dest.RelatedArtifact = new List<RelatedArtifact>(RelatedArtifact.DeepCopy());
                if(Description != null) dest.Description = (Hl7.Fhir.Model.Markdown)Description.DeepCopy();
                if(Assertion != null) dest.Assertion = (Hl7.Fhir.Model.Markdown)Assertion.DeepCopy();
                if(Note != null) dest.Note = new List<Hl7.Fhir.Model.Annotation>(Note.DeepCopy());
                if(ReferentGroup != null) dest.ReferentGroup = (Hl7.Fhir.Model.Evidence.ReferentGroupComponent)ReferentGroup.DeepCopy();
                if(VariableDefinition != null) dest.VariableDefinition = new List<Hl7.Fhir.Model.Evidence.VariableDefinitionComponent>(VariableDefinition.DeepCopy());
                if(SynthesisType != null) dest.SynthesisType = (Hl7.Fhir.Model.CodeableConcept)SynthesisType.DeepCopy();
                if(StudyType != null) dest.StudyType = (Hl7.Fhir.Model.CodeableConcept)StudyType.DeepCopy();
                if(Statistic != null) dest.Statistic = new List<Statistic>(Statistic.DeepCopy());
                if(Distribution != null) dest.Distribution = new List<OrderedDistribution>(Distribution.DeepCopy());
                if(Certainty != null) dest.Certainty = new List<Hl7.Fhir.Model.Evidence.CertaintyComponent>(Certainty.DeepCopy());
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new Evidence());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Evidence;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
            if( !DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.Matches(UseContext, otherT.UseContext)) return false;
            if( !DeepComparable.Matches(ApprovalDateElement, otherT.ApprovalDateElement)) return false;
            if( !DeepComparable.Matches(LastReviewDateElement, otherT.LastReviewDateElement)) return false;
            if( !DeepComparable.Matches(Contributor, otherT.Contributor)) return false;
            if( !DeepComparable.Matches(RelatedArtifact, otherT.RelatedArtifact)) return false;
            if( !DeepComparable.Matches(Description, otherT.Description)) return false;
            if( !DeepComparable.Matches(Assertion, otherT.Assertion)) return false;
            if( !DeepComparable.Matches(Note, otherT.Note)) return false;
            if( !DeepComparable.Matches(ReferentGroup, otherT.ReferentGroup)) return false;
            if( !DeepComparable.Matches(VariableDefinition, otherT.VariableDefinition)) return false;
            if( !DeepComparable.Matches(SynthesisType, otherT.SynthesisType)) return false;
            if( !DeepComparable.Matches(StudyType, otherT.StudyType)) return false;
            if( !DeepComparable.Matches(Statistic, otherT.Statistic)) return false;
            if( !DeepComparable.Matches(Distribution, otherT.Distribution)) return false;
            if( !DeepComparable.Matches(Certainty, otherT.Certainty)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Evidence;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
            if( !DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.IsExactly(UseContext, otherT.UseContext)) return false;
            if( !DeepComparable.IsExactly(ApprovalDateElement, otherT.ApprovalDateElement)) return false;
            if( !DeepComparable.IsExactly(LastReviewDateElement, otherT.LastReviewDateElement)) return false;
            if( !DeepComparable.IsExactly(Contributor, otherT.Contributor)) return false;
            if( !DeepComparable.IsExactly(RelatedArtifact, otherT.RelatedArtifact)) return false;
            if( !DeepComparable.IsExactly(Description, otherT.Description)) return false;
            if( !DeepComparable.IsExactly(Assertion, otherT.Assertion)) return false;
            if( !DeepComparable.IsExactly(Note, otherT.Note)) return false;
            if( !DeepComparable.IsExactly(ReferentGroup, otherT.ReferentGroup)) return false;
            if( !DeepComparable.IsExactly(VariableDefinition, otherT.VariableDefinition)) return false;
            if( !DeepComparable.IsExactly(SynthesisType, otherT.SynthesisType)) return false;
            if( !DeepComparable.IsExactly(StudyType, otherT.StudyType)) return false;
            if( !DeepComparable.IsExactly(Statistic, otherT.Statistic)) return false;
            if( !DeepComparable.IsExactly(Distribution, otherT.Distribution)) return false;
            if( !DeepComparable.IsExactly(Certainty, otherT.Certainty)) return false;
            
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
				if (TitleElement != null) yield return TitleElement;
				if (StatusElement != null) yield return StatusElement;
				if (DateElement != null) yield return DateElement;
				foreach (var elem in UseContext) { if (elem != null) yield return elem; }
				if (ApprovalDateElement != null) yield return ApprovalDateElement;
				if (LastReviewDateElement != null) yield return LastReviewDateElement;
				foreach (var elem in Contributor) { if (elem != null) yield return elem; }
				foreach (var elem in RelatedArtifact) { if (elem != null) yield return elem; }
				if (Description != null) yield return Description;
				if (Assertion != null) yield return Assertion;
				foreach (var elem in Note) { if (elem != null) yield return elem; }
				if (ReferentGroup != null) yield return ReferentGroup;
				foreach (var elem in VariableDefinition) { if (elem != null) yield return elem; }
				if (SynthesisType != null) yield return SynthesisType;
				if (StudyType != null) yield return StudyType;
				foreach (var elem in Statistic) { if (elem != null) yield return elem; }
				foreach (var elem in Distribution) { if (elem != null) yield return elem; }
				foreach (var elem in Certainty) { if (elem != null) yield return elem; }
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
                if (TitleElement != null) yield return new ElementValue("title", TitleElement);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                foreach (var elem in UseContext) { if (elem != null) yield return new ElementValue("useContext", elem); }
                if (ApprovalDateElement != null) yield return new ElementValue("approvalDate", ApprovalDateElement);
                if (LastReviewDateElement != null) yield return new ElementValue("lastReviewDate", LastReviewDateElement);
                foreach (var elem in Contributor) { if (elem != null) yield return new ElementValue("contributor", elem); }
                foreach (var elem in RelatedArtifact) { if (elem != null) yield return new ElementValue("relatedArtifact", elem); }
                if (Description != null) yield return new ElementValue("description", Description);
                if (Assertion != null) yield return new ElementValue("assertion", Assertion);
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
                if (ReferentGroup != null) yield return new ElementValue("referentGroup", ReferentGroup);
                foreach (var elem in VariableDefinition) { if (elem != null) yield return new ElementValue("variableDefinition", elem); }
                if (SynthesisType != null) yield return new ElementValue("synthesisType", SynthesisType);
                if (StudyType != null) yield return new ElementValue("studyType", StudyType);
                foreach (var elem in Statistic) { if (elem != null) yield return new ElementValue("statistic", elem); }
                foreach (var elem in Distribution) { if (elem != null) yield return new ElementValue("distribution", elem); }
                foreach (var elem in Certainty) { if (elem != null) yield return new ElementValue("certainty", elem); }
            }
        }

    }
    
}
