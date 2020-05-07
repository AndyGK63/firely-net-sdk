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
    /// The detailed description of a substance, typically at a level beyond what is used for prescribing
    /// </summary>
    [FhirType("SubstanceDefinition", IsResource=true)]
    [DataContract]
    public partial class SubstanceDefinition : Hl7.Fhir.Model.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.SubstanceDefinition; } }
        [NotMapped]
        public override string TypeName { get { return "SubstanceDefinition"; } }
        
        [FhirType("MoietyComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class MoietyComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "MoietyComponent"; } }
            
            /// <summary>
            /// Role that the moiety is playing
            /// </summary>
            [FhirElement("role", InSummary=true, Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Role
            {
                get { return _Role; }
                set { _Role = value; OnPropertyChanged("Role"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Role;
            
            /// <summary>
            /// Identifier by which this moiety substance is known
            /// </summary>
            [FhirElement("identifier", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.Identifier Identifier
            {
                get { return _Identifier; }
                set { _Identifier = value; OnPropertyChanged("Identifier"); }
            }
            
            private Hl7.Fhir.Model.Identifier _Identifier;
            
            /// <summary>
            /// Textual name for this moiety substance
            /// </summary>
            [FhirElement("name", InSummary=true, Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString NameElement
            {
                get { return _NameElement; }
                set { _NameElement = value; OnPropertyChanged("NameElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _NameElement;
            
            /// <summary>
            /// Textual name for this moiety substance
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
            /// Stereochemistry type
            /// </summary>
            [FhirElement("stereochemistry", InSummary=true, Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Stereochemistry
            {
                get { return _Stereochemistry; }
                set { _Stereochemistry = value; OnPropertyChanged("Stereochemistry"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Stereochemistry;
            
            /// <summary>
            /// Optical activity type
            /// </summary>
            [FhirElement("opticalActivity", InSummary=true, Order=80)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept OpticalActivity
            {
                get { return _OpticalActivity; }
                set { _OpticalActivity = value; OnPropertyChanged("OpticalActivity"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _OpticalActivity;
            
            /// <summary>
            /// Molecular formula for this moiety of this substance, typically using the Hill system
            /// </summary>
            [FhirElement("molecularFormula", InSummary=true, Order=90)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString MolecularFormulaElement
            {
                get { return _MolecularFormulaElement; }
                set { _MolecularFormulaElement = value; OnPropertyChanged("MolecularFormulaElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _MolecularFormulaElement;
            
            /// <summary>
            /// Molecular formula for this moiety of this substance, typically using the Hill system
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string MolecularFormula
            {
                get { return MolecularFormulaElement != null ? MolecularFormulaElement.Value : null; }
                set
                {
                    if (value == null)
                        MolecularFormulaElement = null; 
                    else
                        MolecularFormulaElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("MolecularFormula");
                }
            }
            
            /// <summary>
            /// Quantitative value for this moiety
            /// </summary>
            [FhirElement("amount", InSummary=true, Order=100, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
			[AllowedTypes(typeof(Quantity),typeof(Hl7.Fhir.Model.FhirString))]
            [DataMember]
            public Hl7.Fhir.Model.Element Amount
            {
                get { return _Amount; }
                set { _Amount = value; OnPropertyChanged("Amount"); }
            }
            
            private Hl7.Fhir.Model.Element _Amount;
            
            /// <summary>
            /// The measurement type of the quantitative value
            /// </summary>
            [FhirElement("amountType", InSummary=true, Order=110)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept AmountType
            {
                get { return _AmountType; }
                set { _AmountType = value; OnPropertyChanged("AmountType"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _AmountType;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as MoietyComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Role != null) dest.Role = (Hl7.Fhir.Model.CodeableConcept)Role.DeepCopy();
                    if(Identifier != null) dest.Identifier = (Hl7.Fhir.Model.Identifier)Identifier.DeepCopy();
                    if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
                    if(Stereochemistry != null) dest.Stereochemistry = (Hl7.Fhir.Model.CodeableConcept)Stereochemistry.DeepCopy();
                    if(OpticalActivity != null) dest.OpticalActivity = (Hl7.Fhir.Model.CodeableConcept)OpticalActivity.DeepCopy();
                    if(MolecularFormulaElement != null) dest.MolecularFormulaElement = (Hl7.Fhir.Model.FhirString)MolecularFormulaElement.DeepCopy();
                    if(Amount != null) dest.Amount = (Hl7.Fhir.Model.Element)Amount.DeepCopy();
                    if(AmountType != null) dest.AmountType = (Hl7.Fhir.Model.CodeableConcept)AmountType.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new MoietyComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as MoietyComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Role, otherT.Role)) return false;
                if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
                if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.Matches(Stereochemistry, otherT.Stereochemistry)) return false;
                if( !DeepComparable.Matches(OpticalActivity, otherT.OpticalActivity)) return false;
                if( !DeepComparable.Matches(MolecularFormulaElement, otherT.MolecularFormulaElement)) return false;
                if( !DeepComparable.Matches(Amount, otherT.Amount)) return false;
                if( !DeepComparable.Matches(AmountType, otherT.AmountType)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as MoietyComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Role, otherT.Role)) return false;
                if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
                if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.IsExactly(Stereochemistry, otherT.Stereochemistry)) return false;
                if( !DeepComparable.IsExactly(OpticalActivity, otherT.OpticalActivity)) return false;
                if( !DeepComparable.IsExactly(MolecularFormulaElement, otherT.MolecularFormulaElement)) return false;
                if( !DeepComparable.IsExactly(Amount, otherT.Amount)) return false;
                if( !DeepComparable.IsExactly(AmountType, otherT.AmountType)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Role != null) yield return Role;
                    if (Identifier != null) yield return Identifier;
                    if (NameElement != null) yield return NameElement;
                    if (Stereochemistry != null) yield return Stereochemistry;
                    if (OpticalActivity != null) yield return OpticalActivity;
                    if (MolecularFormulaElement != null) yield return MolecularFormulaElement;
                    if (Amount != null) yield return Amount;
                    if (AmountType != null) yield return AmountType;
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Role != null) yield return new ElementValue("role", Role);
                    if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (Stereochemistry != null) yield return new ElementValue("stereochemistry", Stereochemistry);
                    if (OpticalActivity != null) yield return new ElementValue("opticalActivity", OpticalActivity);
                    if (MolecularFormulaElement != null) yield return new ElementValue("molecularFormula", MolecularFormulaElement);
                    if (Amount != null) yield return new ElementValue("amount", Amount);
                    if (AmountType != null) yield return new ElementValue("amountType", AmountType);
                }
            }

            
        }
        
        
        [FhirType("PropertyComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class PropertyComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "PropertyComponent"; } }
            
            /// <summary>
            /// A category for this property, e.g. Physical, Chemical, Enzymatic
            /// </summary>
            [FhirElement("category", InSummary=true, Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Category
            {
                get { return _Category; }
                set { _Category = value; OnPropertyChanged("Category"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Category;
            
            /// <summary>
            /// Property type e.g. viscosity, pH, isoelectric point
            /// </summary>
            [FhirElement("code", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Code
            {
                get { return _Code; }
                set { _Code = value; OnPropertyChanged("Code"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Code;
            
            /// <summary>
            /// Parameters that were used in the measurement of a property (e.g. for viscosity: measured at 20C with a pH of 7.1)
            /// </summary>
            [FhirElement("parameters", InSummary=true, Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString ParametersElement
            {
                get { return _ParametersElement; }
                set { _ParametersElement = value; OnPropertyChanged("ParametersElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _ParametersElement;
            
            /// <summary>
            /// Parameters that were used in the measurement of a property (e.g. for viscosity: measured at 20C with a pH of 7.1)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Parameters
            {
                get { return ParametersElement != null ? ParametersElement.Value : null; }
                set
                {
                    if (value == null)
                        ParametersElement = null; 
                    else
                        ParametersElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Parameters");
                }
            }
            
            /// <summary>
            /// A substance upon which a defining property depends (e.g. for solubility: in water, in alcohol)
            /// </summary>
            [FhirElement("definingSubstance", InSummary=true, Order=70, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
			[AllowedTypes(typeof(Hl7.Fhir.Model.ResourceReference),typeof(Hl7.Fhir.Model.CodeableConcept))]
            [DataMember]
            public Hl7.Fhir.Model.Element DefiningSubstance
            {
                get { return _DefiningSubstance; }
                set { _DefiningSubstance = value; OnPropertyChanged("DefiningSubstance"); }
            }
            
            private Hl7.Fhir.Model.Element _DefiningSubstance;
            
            /// <summary>
            /// Quantitative value for this property
            /// </summary>
            [FhirElement("amount", InSummary=true, Order=80, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
			[AllowedTypes(typeof(Quantity),typeof(Hl7.Fhir.Model.FhirString))]
            [DataMember]
            public Hl7.Fhir.Model.Element Amount
            {
                get { return _Amount; }
                set { _Amount = value; OnPropertyChanged("Amount"); }
            }
            
            private Hl7.Fhir.Model.Element _Amount;
            
            /// <summary>
            /// Range of typical values
            /// </summary>
            [FhirElement("referenceRange", InSummary=true, Order=90)]
            [DataMember]
            public Hl7.Fhir.Model.Range ReferenceRange
            {
                get { return _ReferenceRange; }
                set { _ReferenceRange = value; OnPropertyChanged("ReferenceRange"); }
            }
            
            private Hl7.Fhir.Model.Range _ReferenceRange;
            
            /// <summary>
            /// Supporting literature
            /// </summary>
            [FhirElement("source", InSummary=true, Order=100)]
            [CLSCompliant(false)]
			[References("DocumentReference")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.ResourceReference> Source
            {
                get { if(_Source==null) _Source = new List<Hl7.Fhir.Model.ResourceReference>(); return _Source; }
                set { _Source = value; OnPropertyChanged("Source"); }
            }
            
            private List<Hl7.Fhir.Model.ResourceReference> _Source;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PropertyComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Category != null) dest.Category = (Hl7.Fhir.Model.CodeableConcept)Category.DeepCopy();
                    if(Code != null) dest.Code = (Hl7.Fhir.Model.CodeableConcept)Code.DeepCopy();
                    if(ParametersElement != null) dest.ParametersElement = (Hl7.Fhir.Model.FhirString)ParametersElement.DeepCopy();
                    if(DefiningSubstance != null) dest.DefiningSubstance = (Hl7.Fhir.Model.Element)DefiningSubstance.DeepCopy();
                    if(Amount != null) dest.Amount = (Hl7.Fhir.Model.Element)Amount.DeepCopy();
                    if(ReferenceRange != null) dest.ReferenceRange = (Hl7.Fhir.Model.Range)ReferenceRange.DeepCopy();
                    if(Source != null) dest.Source = new List<Hl7.Fhir.Model.ResourceReference>(Source.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new PropertyComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PropertyComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Category, otherT.Category)) return false;
                if( !DeepComparable.Matches(Code, otherT.Code)) return false;
                if( !DeepComparable.Matches(ParametersElement, otherT.ParametersElement)) return false;
                if( !DeepComparable.Matches(DefiningSubstance, otherT.DefiningSubstance)) return false;
                if( !DeepComparable.Matches(Amount, otherT.Amount)) return false;
                if( !DeepComparable.Matches(ReferenceRange, otherT.ReferenceRange)) return false;
                if( !DeepComparable.Matches(Source, otherT.Source)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PropertyComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Category, otherT.Category)) return false;
                if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if( !DeepComparable.IsExactly(ParametersElement, otherT.ParametersElement)) return false;
                if( !DeepComparable.IsExactly(DefiningSubstance, otherT.DefiningSubstance)) return false;
                if( !DeepComparable.IsExactly(Amount, otherT.Amount)) return false;
                if( !DeepComparable.IsExactly(ReferenceRange, otherT.ReferenceRange)) return false;
                if( !DeepComparable.IsExactly(Source, otherT.Source)) return false;
                
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
                    if (ParametersElement != null) yield return ParametersElement;
                    if (DefiningSubstance != null) yield return DefiningSubstance;
                    if (Amount != null) yield return Amount;
                    if (ReferenceRange != null) yield return ReferenceRange;
                    foreach (var elem in Source) { if (elem != null) yield return elem; }
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
                    if (ParametersElement != null) yield return new ElementValue("parameters", ParametersElement);
                    if (DefiningSubstance != null) yield return new ElementValue("definingSubstance", DefiningSubstance);
                    if (Amount != null) yield return new ElementValue("amount", Amount);
                    if (ReferenceRange != null) yield return new ElementValue("referenceRange", ReferenceRange);
                    foreach (var elem in Source) { if (elem != null) yield return new ElementValue("source", elem); }
                }
            }

            
        }
        
        
        [FhirType("StructureComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class StructureComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "StructureComponent"; } }
            
            /// <summary>
            /// Stereochemistry type
            /// </summary>
            [FhirElement("stereochemistry", InSummary=true, Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Stereochemistry
            {
                get { return _Stereochemistry; }
                set { _Stereochemistry = value; OnPropertyChanged("Stereochemistry"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Stereochemistry;
            
            /// <summary>
            /// Optical activity type
            /// </summary>
            [FhirElement("opticalActivity", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept OpticalActivity
            {
                get { return _OpticalActivity; }
                set { _OpticalActivity = value; OnPropertyChanged("OpticalActivity"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _OpticalActivity;
            
            /// <summary>
            /// Molecular formula of this substance, typically using the Hill system
            /// </summary>
            [FhirElement("molecularFormula", InSummary=true, Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString MolecularFormulaElement
            {
                get { return _MolecularFormulaElement; }
                set { _MolecularFormulaElement = value; OnPropertyChanged("MolecularFormulaElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _MolecularFormulaElement;
            
            /// <summary>
            /// Molecular formula of this substance, typically using the Hill system
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string MolecularFormula
            {
                get { return MolecularFormulaElement != null ? MolecularFormulaElement.Value : null; }
                set
                {
                    if (value == null)
                        MolecularFormulaElement = null; 
                    else
                        MolecularFormulaElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("MolecularFormula");
                }
            }
            
            /// <summary>
            /// Specified per moiety according to the Hill system, i.e. first C, then H, then alphabetical, each moiety separated by a dot
            /// </summary>
            [FhirElement("molecularFormulaByMoiety", InSummary=true, Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString MolecularFormulaByMoietyElement
            {
                get { return _MolecularFormulaByMoietyElement; }
                set { _MolecularFormulaByMoietyElement = value; OnPropertyChanged("MolecularFormulaByMoietyElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _MolecularFormulaByMoietyElement;
            
            /// <summary>
            /// Specified per moiety according to the Hill system, i.e. first C, then H, then alphabetical, each moiety separated by a dot
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string MolecularFormulaByMoiety
            {
                get { return MolecularFormulaByMoietyElement != null ? MolecularFormulaByMoietyElement.Value : null; }
                set
                {
                    if (value == null)
                        MolecularFormulaByMoietyElement = null; 
                    else
                        MolecularFormulaByMoietyElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("MolecularFormulaByMoiety");
                }
            }
            
            /// <summary>
            /// Applicable for single substances that contain a radionuclide or a non-natural isotopic ratio
            /// </summary>
            [FhirElement("isotope", InSummary=true, Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.SubstanceDefinition.IsotopeComponent> Isotope
            {
                get { if(_Isotope==null) _Isotope = new List<Hl7.Fhir.Model.SubstanceDefinition.IsotopeComponent>(); return _Isotope; }
                set { _Isotope = value; OnPropertyChanged("Isotope"); }
            }
            
            private List<Hl7.Fhir.Model.SubstanceDefinition.IsotopeComponent> _Isotope;
            
            /// <summary>
            /// The molecular weight or weight range (for proteins, polymers or nucleic acids)
            /// </summary>
            [FhirElement("molecularWeight", InSummary=true, Order=90)]
            [DataMember]
            public Hl7.Fhir.Model.SubstanceDefinition.MolecularWeightComponent MolecularWeight
            {
                get { return _MolecularWeight; }
                set { _MolecularWeight = value; OnPropertyChanged("MolecularWeight"); }
            }
            
            private Hl7.Fhir.Model.SubstanceDefinition.MolecularWeightComponent _MolecularWeight;
            
            /// <summary>
            /// The method used to elucidate the structure or characterization of the drug substance. Examples: X-ray, HPLC, NMR, Peptide mapping, Ligand binding assay
            /// </summary>
            [FhirElement("technique", InSummary=true, Order=100)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.CodeableConcept> Technique
            {
                get { if(_Technique==null) _Technique = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Technique; }
                set { _Technique = value; OnPropertyChanged("Technique"); }
            }
            
            private List<Hl7.Fhir.Model.CodeableConcept> _Technique;
            
            /// <summary>
            /// Supporting literature about the source of information
            /// </summary>
            [FhirElement("sourceDocument", InSummary=true, Order=110)]
            [CLSCompliant(false)]
			[References("DocumentReference")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.ResourceReference> SourceDocument
            {
                get { if(_SourceDocument==null) _SourceDocument = new List<Hl7.Fhir.Model.ResourceReference>(); return _SourceDocument; }
                set { _SourceDocument = value; OnPropertyChanged("SourceDocument"); }
            }
            
            private List<Hl7.Fhir.Model.ResourceReference> _SourceDocument;
            
            /// <summary>
            /// Molecular structural representation
            /// </summary>
            [FhirElement("representation", InSummary=true, Order=120)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.SubstanceDefinition.RepresentationComponent> Representation
            {
                get { if(_Representation==null) _Representation = new List<Hl7.Fhir.Model.SubstanceDefinition.RepresentationComponent>(); return _Representation; }
                set { _Representation = value; OnPropertyChanged("Representation"); }
            }
            
            private List<Hl7.Fhir.Model.SubstanceDefinition.RepresentationComponent> _Representation;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as StructureComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Stereochemistry != null) dest.Stereochemistry = (Hl7.Fhir.Model.CodeableConcept)Stereochemistry.DeepCopy();
                    if(OpticalActivity != null) dest.OpticalActivity = (Hl7.Fhir.Model.CodeableConcept)OpticalActivity.DeepCopy();
                    if(MolecularFormulaElement != null) dest.MolecularFormulaElement = (Hl7.Fhir.Model.FhirString)MolecularFormulaElement.DeepCopy();
                    if(MolecularFormulaByMoietyElement != null) dest.MolecularFormulaByMoietyElement = (Hl7.Fhir.Model.FhirString)MolecularFormulaByMoietyElement.DeepCopy();
                    if(Isotope != null) dest.Isotope = new List<Hl7.Fhir.Model.SubstanceDefinition.IsotopeComponent>(Isotope.DeepCopy());
                    if(MolecularWeight != null) dest.MolecularWeight = (Hl7.Fhir.Model.SubstanceDefinition.MolecularWeightComponent)MolecularWeight.DeepCopy();
                    if(Technique != null) dest.Technique = new List<Hl7.Fhir.Model.CodeableConcept>(Technique.DeepCopy());
                    if(SourceDocument != null) dest.SourceDocument = new List<Hl7.Fhir.Model.ResourceReference>(SourceDocument.DeepCopy());
                    if(Representation != null) dest.Representation = new List<Hl7.Fhir.Model.SubstanceDefinition.RepresentationComponent>(Representation.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new StructureComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as StructureComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Stereochemistry, otherT.Stereochemistry)) return false;
                if( !DeepComparable.Matches(OpticalActivity, otherT.OpticalActivity)) return false;
                if( !DeepComparable.Matches(MolecularFormulaElement, otherT.MolecularFormulaElement)) return false;
                if( !DeepComparable.Matches(MolecularFormulaByMoietyElement, otherT.MolecularFormulaByMoietyElement)) return false;
                if( !DeepComparable.Matches(Isotope, otherT.Isotope)) return false;
                if( !DeepComparable.Matches(MolecularWeight, otherT.MolecularWeight)) return false;
                if( !DeepComparable.Matches(Technique, otherT.Technique)) return false;
                if( !DeepComparable.Matches(SourceDocument, otherT.SourceDocument)) return false;
                if( !DeepComparable.Matches(Representation, otherT.Representation)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as StructureComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Stereochemistry, otherT.Stereochemistry)) return false;
                if( !DeepComparable.IsExactly(OpticalActivity, otherT.OpticalActivity)) return false;
                if( !DeepComparable.IsExactly(MolecularFormulaElement, otherT.MolecularFormulaElement)) return false;
                if( !DeepComparable.IsExactly(MolecularFormulaByMoietyElement, otherT.MolecularFormulaByMoietyElement)) return false;
                if( !DeepComparable.IsExactly(Isotope, otherT.Isotope)) return false;
                if( !DeepComparable.IsExactly(MolecularWeight, otherT.MolecularWeight)) return false;
                if( !DeepComparable.IsExactly(Technique, otherT.Technique)) return false;
                if( !DeepComparable.IsExactly(SourceDocument, otherT.SourceDocument)) return false;
                if( !DeepComparable.IsExactly(Representation, otherT.Representation)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Stereochemistry != null) yield return Stereochemistry;
                    if (OpticalActivity != null) yield return OpticalActivity;
                    if (MolecularFormulaElement != null) yield return MolecularFormulaElement;
                    if (MolecularFormulaByMoietyElement != null) yield return MolecularFormulaByMoietyElement;
                    foreach (var elem in Isotope) { if (elem != null) yield return elem; }
                    if (MolecularWeight != null) yield return MolecularWeight;
                    foreach (var elem in Technique) { if (elem != null) yield return elem; }
                    foreach (var elem in SourceDocument) { if (elem != null) yield return elem; }
                    foreach (var elem in Representation) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Stereochemistry != null) yield return new ElementValue("stereochemistry", Stereochemistry);
                    if (OpticalActivity != null) yield return new ElementValue("opticalActivity", OpticalActivity);
                    if (MolecularFormulaElement != null) yield return new ElementValue("molecularFormula", MolecularFormulaElement);
                    if (MolecularFormulaByMoietyElement != null) yield return new ElementValue("molecularFormulaByMoiety", MolecularFormulaByMoietyElement);
                    foreach (var elem in Isotope) { if (elem != null) yield return new ElementValue("isotope", elem); }
                    if (MolecularWeight != null) yield return new ElementValue("molecularWeight", MolecularWeight);
                    foreach (var elem in Technique) { if (elem != null) yield return new ElementValue("technique", elem); }
                    foreach (var elem in SourceDocument) { if (elem != null) yield return new ElementValue("sourceDocument", elem); }
                    foreach (var elem in Representation) { if (elem != null) yield return new ElementValue("representation", elem); }
                }
            }

            
        }
        
        
        [FhirType("IsotopeComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class IsotopeComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "IsotopeComponent"; } }
            
            /// <summary>
            /// Substance identifier for each non-natural or radioisotope
            /// </summary>
            [FhirElement("identifier", InSummary=true, Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.Identifier Identifier
            {
                get { return _Identifier; }
                set { _Identifier = value; OnPropertyChanged("Identifier"); }
            }
            
            private Hl7.Fhir.Model.Identifier _Identifier;
            
            /// <summary>
            /// Substance name for each non-natural or radioisotope
            /// </summary>
            [FhirElement("name", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Name
            {
                get { return _Name; }
                set { _Name = value; OnPropertyChanged("Name"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Name;
            
            /// <summary>
            /// The type of isotopic substitution present in a single substance
            /// </summary>
            [FhirElement("substitution", InSummary=true, Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Substitution
            {
                get { return _Substitution; }
                set { _Substitution = value; OnPropertyChanged("Substitution"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Substitution;
            
            /// <summary>
            /// Half life - for a non-natural nuclide
            /// </summary>
            [FhirElement("halfLife", InSummary=true, Order=70)]
            [DataMember]
            public Quantity HalfLife
            {
                get { return _HalfLife; }
                set { _HalfLife = value; OnPropertyChanged("HalfLife"); }
            }
            
            private Quantity _HalfLife;
            
            /// <summary>
            /// The molecular weight or weight range (for proteins, polymers or nucleic acids)
            /// </summary>
            [FhirElement("molecularWeight", InSummary=true, Order=80)]
            [DataMember]
            public Hl7.Fhir.Model.SubstanceDefinition.MolecularWeightComponent MolecularWeight
            {
                get { return _MolecularWeight; }
                set { _MolecularWeight = value; OnPropertyChanged("MolecularWeight"); }
            }
            
            private Hl7.Fhir.Model.SubstanceDefinition.MolecularWeightComponent _MolecularWeight;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as IsotopeComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Identifier != null) dest.Identifier = (Hl7.Fhir.Model.Identifier)Identifier.DeepCopy();
                    if(Name != null) dest.Name = (Hl7.Fhir.Model.CodeableConcept)Name.DeepCopy();
                    if(Substitution != null) dest.Substitution = (Hl7.Fhir.Model.CodeableConcept)Substitution.DeepCopy();
                    if(HalfLife != null) dest.HalfLife = (Quantity)HalfLife.DeepCopy();
                    if(MolecularWeight != null) dest.MolecularWeight = (Hl7.Fhir.Model.SubstanceDefinition.MolecularWeightComponent)MolecularWeight.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new IsotopeComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as IsotopeComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
                if( !DeepComparable.Matches(Name, otherT.Name)) return false;
                if( !DeepComparable.Matches(Substitution, otherT.Substitution)) return false;
                if( !DeepComparable.Matches(HalfLife, otherT.HalfLife)) return false;
                if( !DeepComparable.Matches(MolecularWeight, otherT.MolecularWeight)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as IsotopeComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
                if( !DeepComparable.IsExactly(Name, otherT.Name)) return false;
                if( !DeepComparable.IsExactly(Substitution, otherT.Substitution)) return false;
                if( !DeepComparable.IsExactly(HalfLife, otherT.HalfLife)) return false;
                if( !DeepComparable.IsExactly(MolecularWeight, otherT.MolecularWeight)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Identifier != null) yield return Identifier;
                    if (Name != null) yield return Name;
                    if (Substitution != null) yield return Substitution;
                    if (HalfLife != null) yield return HalfLife;
                    if (MolecularWeight != null) yield return MolecularWeight;
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                    if (Name != null) yield return new ElementValue("name", Name);
                    if (Substitution != null) yield return new ElementValue("substitution", Substitution);
                    if (HalfLife != null) yield return new ElementValue("halfLife", HalfLife);
                    if (MolecularWeight != null) yield return new ElementValue("molecularWeight", MolecularWeight);
                }
            }

            
        }
        
        
        [FhirType("MolecularWeightComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class MolecularWeightComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "MolecularWeightComponent"; } }
            
            /// <summary>
            /// The method by which the molecular weight was determined
            /// </summary>
            [FhirElement("method", InSummary=true, Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Method
            {
                get { return _Method; }
                set { _Method = value; OnPropertyChanged("Method"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Method;
            
            /// <summary>
            /// Type of molecular weight such as exact, average (also known as. number average), weight average
            /// </summary>
            [FhirElement("type", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Type;
            
            /// <summary>
            /// Used to capture quantitative values for a variety of elements. If only limits are given, the arithmetic mean would be the average. If only a single definite value for a given element is given, it would be captured in this field
            /// </summary>
            [FhirElement("amount", InSummary=true, Order=60)]
            [DataMember]
            public Quantity Amount
            {
                get { return _Amount; }
                set { _Amount = value; OnPropertyChanged("Amount"); }
            }
            
            private Quantity _Amount;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as MolecularWeightComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Method != null) dest.Method = (Hl7.Fhir.Model.CodeableConcept)Method.DeepCopy();
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
                    if(Amount != null) dest.Amount = (Quantity)Amount.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new MolecularWeightComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as MolecularWeightComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Method, otherT.Method)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(Amount, otherT.Amount)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as MolecularWeightComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Method, otherT.Method)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(Amount, otherT.Amount)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Method != null) yield return Method;
                    if (Type != null) yield return Type;
                    if (Amount != null) yield return Amount;
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Method != null) yield return new ElementValue("method", Method);
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (Amount != null) yield return new ElementValue("amount", Amount);
                }
            }

            
        }
        
        
        [FhirType("RepresentationComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class RepresentationComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "RepresentationComponent"; } }
            
            /// <summary>
            /// The type of structure (e.g. Full, Partial, Representative)
            /// </summary>
            [FhirElement("type", InSummary=true, Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Type;
            
            /// <summary>
            /// The structural representation as text string in a standard format e.g. InChI, SMILES, MOLFILE, CDX, SDF, PDB, mmCIF
            /// </summary>
            [FhirElement("representation", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString RepresentationElement
            {
                get { return _RepresentationElement; }
                set { _RepresentationElement = value; OnPropertyChanged("RepresentationElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _RepresentationElement;
            
            /// <summary>
            /// The structural representation as text string in a standard format e.g. InChI, SMILES, MOLFILE, CDX, SDF, PDB, mmCIF
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Representation
            {
                get { return RepresentationElement != null ? RepresentationElement.Value : null; }
                set
                {
                    if (value == null)
                        RepresentationElement = null; 
                    else
                        RepresentationElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Representation");
                }
            }
            
            /// <summary>
            /// The format of the representation e.g. InChI, SMILES, MOLFILE, CDX, SDF, PDB, mmCIF
            /// </summary>
            [FhirElement("format", InSummary=true, Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Format
            {
                get { return _Format; }
                set { _Format = value; OnPropertyChanged("Format"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Format;
            
            /// <summary>
            /// An attached file with the structural representation
            /// </summary>
            [FhirElement("attachment", InSummary=true, Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.Attachment Attachment
            {
                get { return _Attachment; }
                set { _Attachment = value; OnPropertyChanged("Attachment"); }
            }
            
            private Hl7.Fhir.Model.Attachment _Attachment;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RepresentationComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
                    if(RepresentationElement != null) dest.RepresentationElement = (Hl7.Fhir.Model.FhirString)RepresentationElement.DeepCopy();
                    if(Format != null) dest.Format = (Hl7.Fhir.Model.CodeableConcept)Format.DeepCopy();
                    if(Attachment != null) dest.Attachment = (Hl7.Fhir.Model.Attachment)Attachment.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new RepresentationComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RepresentationComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(RepresentationElement, otherT.RepresentationElement)) return false;
                if( !DeepComparable.Matches(Format, otherT.Format)) return false;
                if( !DeepComparable.Matches(Attachment, otherT.Attachment)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RepresentationComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(RepresentationElement, otherT.RepresentationElement)) return false;
                if( !DeepComparable.IsExactly(Format, otherT.Format)) return false;
                if( !DeepComparable.IsExactly(Attachment, otherT.Attachment)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (RepresentationElement != null) yield return RepresentationElement;
                    if (Format != null) yield return Format;
                    if (Attachment != null) yield return Attachment;
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (RepresentationElement != null) yield return new ElementValue("representation", RepresentationElement);
                    if (Format != null) yield return new ElementValue("format", Format);
                    if (Attachment != null) yield return new ElementValue("attachment", Attachment);
                }
            }

            
        }
        
        
        [FhirType("CodeComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class CodeComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "CodeComponent"; } }
            
            /// <summary>
            /// The specific code
            /// </summary>
            [FhirElement("code", InSummary=true, Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Code
            {
                get { return _Code; }
                set { _Code = value; OnPropertyChanged("Code"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Code;
            
            /// <summary>
            /// Status of the code assignment, for example 'provisional', 'approved'
            /// </summary>
            [FhirElement("status", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Status
            {
                get { return _Status; }
                set { _Status = value; OnPropertyChanged("Status"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Status;
            
            /// <summary>
            /// The date at which the code status is changed as part of the terminology maintenance
            /// </summary>
            [FhirElement("statusDate", InSummary=true, Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.FhirDateTime StatusDateElement
            {
                get { return _StatusDateElement; }
                set { _StatusDateElement = value; OnPropertyChanged("StatusDateElement"); }
            }
            
            private Hl7.Fhir.Model.FhirDateTime _StatusDateElement;
            
            /// <summary>
            /// The date at which the code status is changed as part of the terminology maintenance
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string StatusDate
            {
                get { return StatusDateElement != null ? StatusDateElement.Value : null; }
                set
                {
                    if (value == null)
                        StatusDateElement = null; 
                    else
                        StatusDateElement = new Hl7.Fhir.Model.FhirDateTime(value);
                    OnPropertyChanged("StatusDate");
                }
            }
            
            /// <summary>
            /// Any comment can be provided in this field, if necessary
            /// </summary>
            [FhirElement("note", InSummary=true, Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.Annotation> Note
            {
                get { if(_Note==null) _Note = new List<Hl7.Fhir.Model.Annotation>(); return _Note; }
                set { _Note = value; OnPropertyChanged("Note"); }
            }
            
            private List<Hl7.Fhir.Model.Annotation> _Note;
            
            /// <summary>
            /// Supporting literature
            /// </summary>
            [FhirElement("source", InSummary=true, Order=80)]
            [CLSCompliant(false)]
			[References("DocumentReference")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.ResourceReference> Source
            {
                get { if(_Source==null) _Source = new List<Hl7.Fhir.Model.ResourceReference>(); return _Source; }
                set { _Source = value; OnPropertyChanged("Source"); }
            }
            
            private List<Hl7.Fhir.Model.ResourceReference> _Source;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CodeComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Code != null) dest.Code = (Hl7.Fhir.Model.CodeableConcept)Code.DeepCopy();
                    if(Status != null) dest.Status = (Hl7.Fhir.Model.CodeableConcept)Status.DeepCopy();
                    if(StatusDateElement != null) dest.StatusDateElement = (Hl7.Fhir.Model.FhirDateTime)StatusDateElement.DeepCopy();
                    if(Note != null) dest.Note = new List<Hl7.Fhir.Model.Annotation>(Note.DeepCopy());
                    if(Source != null) dest.Source = new List<Hl7.Fhir.Model.ResourceReference>(Source.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new CodeComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as CodeComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Code, otherT.Code)) return false;
                if( !DeepComparable.Matches(Status, otherT.Status)) return false;
                if( !DeepComparable.Matches(StatusDateElement, otherT.StatusDateElement)) return false;
                if( !DeepComparable.Matches(Note, otherT.Note)) return false;
                if( !DeepComparable.Matches(Source, otherT.Source)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CodeComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if( !DeepComparable.IsExactly(Status, otherT.Status)) return false;
                if( !DeepComparable.IsExactly(StatusDateElement, otherT.StatusDateElement)) return false;
                if( !DeepComparable.IsExactly(Note, otherT.Note)) return false;
                if( !DeepComparable.IsExactly(Source, otherT.Source)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Code != null) yield return Code;
                    if (Status != null) yield return Status;
                    if (StatusDateElement != null) yield return StatusDateElement;
                    foreach (var elem in Note) { if (elem != null) yield return elem; }
                    foreach (var elem in Source) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", Code);
                    if (Status != null) yield return new ElementValue("status", Status);
                    if (StatusDateElement != null) yield return new ElementValue("statusDate", StatusDateElement);
                    foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
                    foreach (var elem in Source) { if (elem != null) yield return new ElementValue("source", elem); }
                }
            }

            
        }
        
        
        [FhirType("NameComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class NameComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "NameComponent"; } }
            
            /// <summary>
            /// The actual name
            /// </summary>
            [FhirElement("name", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString NameElement
            {
                get { return _NameElement; }
                set { _NameElement = value; OnPropertyChanged("NameElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _NameElement;
            
            /// <summary>
            /// The actual name
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
            /// Name type, for example 'systematic',  'scientific, 'brand'
            /// </summary>
            [FhirElement("type", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Type;
            
            /// <summary>
            /// The status of the name, for example 'current', 'proposed'
            /// </summary>
            [FhirElement("status", InSummary=true, Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Status
            {
                get { return _Status; }
                set { _Status = value; OnPropertyChanged("Status"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Status;
            
            /// <summary>
            /// If this is the preferred name for this substance
            /// </summary>
            [FhirElement("preferred", InSummary=true, Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.FhirBoolean PreferredElement
            {
                get { return _PreferredElement; }
                set { _PreferredElement = value; OnPropertyChanged("PreferredElement"); }
            }
            
            private Hl7.Fhir.Model.FhirBoolean _PreferredElement;
            
            /// <summary>
            /// If this is the preferred name for this substance
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public bool? Preferred
            {
                get { return PreferredElement != null ? PreferredElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        PreferredElement = null; 
                    else
                        PreferredElement = new Hl7.Fhir.Model.FhirBoolean(value);
                    OnPropertyChanged("Preferred");
                }
            }
            
            /// <summary>
            /// Human language that the name is written in
            /// </summary>
            [FhirElement("language", InSummary=true, Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.CodeableConcept> Language
            {
                get { if(_Language==null) _Language = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Language; }
                set { _Language = value; OnPropertyChanged("Language"); }
            }
            
            private List<Hl7.Fhir.Model.CodeableConcept> _Language;
            
            /// <summary>
            /// The use context of this name for example if there is a different name a drug active ingredient as opposed to a food colour additive
            /// </summary>
            [FhirElement("domain", InSummary=true, Order=90)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.CodeableConcept> Domain
            {
                get { if(_Domain==null) _Domain = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Domain; }
                set { _Domain = value; OnPropertyChanged("Domain"); }
            }
            
            private List<Hl7.Fhir.Model.CodeableConcept> _Domain;
            
            /// <summary>
            /// The jurisdiction where this name applies
            /// </summary>
            [FhirElement("jurisdiction", InSummary=true, Order=100)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.CodeableConcept> Jurisdiction
            {
                get { if(_Jurisdiction==null) _Jurisdiction = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Jurisdiction; }
                set { _Jurisdiction = value; OnPropertyChanged("Jurisdiction"); }
            }
            
            private List<Hl7.Fhir.Model.CodeableConcept> _Jurisdiction;
            
            /// <summary>
            /// A synonym of this particular name, by which the substance is also known
            /// </summary>
            [FhirElement("synonym", InSummary=true, Order=110)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.SubstanceDefinition.NameComponent> Synonym
            {
                get { if(_Synonym==null) _Synonym = new List<Hl7.Fhir.Model.SubstanceDefinition.NameComponent>(); return _Synonym; }
                set { _Synonym = value; OnPropertyChanged("Synonym"); }
            }
            
            private List<Hl7.Fhir.Model.SubstanceDefinition.NameComponent> _Synonym;
            
            /// <summary>
            /// A translation for this name into another human language
            /// </summary>
            [FhirElement("translation", InSummary=true, Order=120)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.SubstanceDefinition.NameComponent> Translation
            {
                get { if(_Translation==null) _Translation = new List<Hl7.Fhir.Model.SubstanceDefinition.NameComponent>(); return _Translation; }
                set { _Translation = value; OnPropertyChanged("Translation"); }
            }
            
            private List<Hl7.Fhir.Model.SubstanceDefinition.NameComponent> _Translation;
            
            /// <summary>
            /// Details of the official nature of this name
            /// </summary>
            [FhirElement("official", InSummary=true, Order=130)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.SubstanceDefinition.OfficialComponent> Official
            {
                get { if(_Official==null) _Official = new List<Hl7.Fhir.Model.SubstanceDefinition.OfficialComponent>(); return _Official; }
                set { _Official = value; OnPropertyChanged("Official"); }
            }
            
            private List<Hl7.Fhir.Model.SubstanceDefinition.OfficialComponent> _Official;
            
            /// <summary>
            /// Supporting literature
            /// </summary>
            [FhirElement("source", InSummary=true, Order=140)]
            [CLSCompliant(false)]
			[References("DocumentReference")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.ResourceReference> Source
            {
                get { if(_Source==null) _Source = new List<Hl7.Fhir.Model.ResourceReference>(); return _Source; }
                set { _Source = value; OnPropertyChanged("Source"); }
            }
            
            private List<Hl7.Fhir.Model.ResourceReference> _Source;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as NameComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
                    if(Status != null) dest.Status = (Hl7.Fhir.Model.CodeableConcept)Status.DeepCopy();
                    if(PreferredElement != null) dest.PreferredElement = (Hl7.Fhir.Model.FhirBoolean)PreferredElement.DeepCopy();
                    if(Language != null) dest.Language = new List<Hl7.Fhir.Model.CodeableConcept>(Language.DeepCopy());
                    if(Domain != null) dest.Domain = new List<Hl7.Fhir.Model.CodeableConcept>(Domain.DeepCopy());
                    if(Jurisdiction != null) dest.Jurisdiction = new List<Hl7.Fhir.Model.CodeableConcept>(Jurisdiction.DeepCopy());
                    if(Synonym != null) dest.Synonym = new List<Hl7.Fhir.Model.SubstanceDefinition.NameComponent>(Synonym.DeepCopy());
                    if(Translation != null) dest.Translation = new List<Hl7.Fhir.Model.SubstanceDefinition.NameComponent>(Translation.DeepCopy());
                    if(Official != null) dest.Official = new List<Hl7.Fhir.Model.SubstanceDefinition.OfficialComponent>(Official.DeepCopy());
                    if(Source != null) dest.Source = new List<Hl7.Fhir.Model.ResourceReference>(Source.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new NameComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as NameComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(Status, otherT.Status)) return false;
                if( !DeepComparable.Matches(PreferredElement, otherT.PreferredElement)) return false;
                if( !DeepComparable.Matches(Language, otherT.Language)) return false;
                if( !DeepComparable.Matches(Domain, otherT.Domain)) return false;
                if( !DeepComparable.Matches(Jurisdiction, otherT.Jurisdiction)) return false;
                if( !DeepComparable.Matches(Synonym, otherT.Synonym)) return false;
                if( !DeepComparable.Matches(Translation, otherT.Translation)) return false;
                if( !DeepComparable.Matches(Official, otherT.Official)) return false;
                if( !DeepComparable.Matches(Source, otherT.Source)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as NameComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(Status, otherT.Status)) return false;
                if( !DeepComparable.IsExactly(PreferredElement, otherT.PreferredElement)) return false;
                if( !DeepComparable.IsExactly(Language, otherT.Language)) return false;
                if( !DeepComparable.IsExactly(Domain, otherT.Domain)) return false;
                if( !DeepComparable.IsExactly(Jurisdiction, otherT.Jurisdiction)) return false;
                if( !DeepComparable.IsExactly(Synonym, otherT.Synonym)) return false;
                if( !DeepComparable.IsExactly(Translation, otherT.Translation)) return false;
                if( !DeepComparable.IsExactly(Official, otherT.Official)) return false;
                if( !DeepComparable.IsExactly(Source, otherT.Source)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NameElement != null) yield return NameElement;
                    if (Type != null) yield return Type;
                    if (Status != null) yield return Status;
                    if (PreferredElement != null) yield return PreferredElement;
                    foreach (var elem in Language) { if (elem != null) yield return elem; }
                    foreach (var elem in Domain) { if (elem != null) yield return elem; }
                    foreach (var elem in Jurisdiction) { if (elem != null) yield return elem; }
                    foreach (var elem in Synonym) { if (elem != null) yield return elem; }
                    foreach (var elem in Translation) { if (elem != null) yield return elem; }
                    foreach (var elem in Official) { if (elem != null) yield return elem; }
                    foreach (var elem in Source) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (Status != null) yield return new ElementValue("status", Status);
                    if (PreferredElement != null) yield return new ElementValue("preferred", PreferredElement);
                    foreach (var elem in Language) { if (elem != null) yield return new ElementValue("language", elem); }
                    foreach (var elem in Domain) { if (elem != null) yield return new ElementValue("domain", elem); }
                    foreach (var elem in Jurisdiction) { if (elem != null) yield return new ElementValue("jurisdiction", elem); }
                    foreach (var elem in Synonym) { if (elem != null) yield return new ElementValue("synonym", elem); }
                    foreach (var elem in Translation) { if (elem != null) yield return new ElementValue("translation", elem); }
                    foreach (var elem in Official) { if (elem != null) yield return new ElementValue("official", elem); }
                    foreach (var elem in Source) { if (elem != null) yield return new ElementValue("source", elem); }
                }
            }

            
        }
        
        
        [FhirType("OfficialComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class OfficialComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "OfficialComponent"; } }
            
            /// <summary>
            /// Which authority uses this official name
            /// </summary>
            [FhirElement("authority", InSummary=true, Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Authority
            {
                get { return _Authority; }
                set { _Authority = value; OnPropertyChanged("Authority"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Authority;
            
            /// <summary>
            /// The status of the official name, for example 'provisional', 'approved'
            /// </summary>
            [FhirElement("status", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Status
            {
                get { return _Status; }
                set { _Status = value; OnPropertyChanged("Status"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Status;
            
            /// <summary>
            /// Date of official name change
            /// </summary>
            [FhirElement("date", InSummary=true, Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.FhirDateTime DateElement
            {
                get { return _DateElement; }
                set { _DateElement = value; OnPropertyChanged("DateElement"); }
            }
            
            private Hl7.Fhir.Model.FhirDateTime _DateElement;
            
            /// <summary>
            /// Date of official name change
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
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as OfficialComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Authority != null) dest.Authority = (Hl7.Fhir.Model.CodeableConcept)Authority.DeepCopy();
                    if(Status != null) dest.Status = (Hl7.Fhir.Model.CodeableConcept)Status.DeepCopy();
                    if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.FhirDateTime)DateElement.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new OfficialComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as OfficialComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Authority, otherT.Authority)) return false;
                if( !DeepComparable.Matches(Status, otherT.Status)) return false;
                if( !DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as OfficialComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Authority, otherT.Authority)) return false;
                if( !DeepComparable.IsExactly(Status, otherT.Status)) return false;
                if( !DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Authority != null) yield return Authority;
                    if (Status != null) yield return Status;
                    if (DateElement != null) yield return DateElement;
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Authority != null) yield return new ElementValue("authority", Authority);
                    if (Status != null) yield return new ElementValue("status", Status);
                    if (DateElement != null) yield return new ElementValue("date", DateElement);
                }
            }

            
        }
        
        
        [FhirType("RelationshipComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class RelationshipComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "RelationshipComponent"; } }
            
            /// <summary>
            /// A pointer to another substance, as a resource or just a representational code
            /// </summary>
            [FhirElement("substanceDefinition", InSummary=true, Order=40, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
			[AllowedTypes(typeof(Hl7.Fhir.Model.ResourceReference),typeof(Hl7.Fhir.Model.CodeableConcept))]
            [DataMember]
            public Hl7.Fhir.Model.Element SubstanceDefinition
            {
                get { return _SubstanceDefinition; }
                set { _SubstanceDefinition = value; OnPropertyChanged("SubstanceDefinition"); }
            }
            
            private Hl7.Fhir.Model.Element _SubstanceDefinition;
            
            /// <summary>
            /// For example "salt to parent", "active moiety", "starting material", "polymorph"
            /// </summary>
            [FhirElement("type", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Type;
            
            /// <summary>
            /// For example where an enzyme strongly bonds with a particular substance, this is a defining relationship for that enzyme, out of several possible substance relationships
            /// </summary>
            [FhirElement("isDefining", InSummary=true, Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.FhirBoolean IsDefiningElement
            {
                get { return _IsDefiningElement; }
                set { _IsDefiningElement = value; OnPropertyChanged("IsDefiningElement"); }
            }
            
            private Hl7.Fhir.Model.FhirBoolean _IsDefiningElement;
            
            /// <summary>
            /// For example where an enzyme strongly bonds with a particular substance, this is a defining relationship for that enzyme, out of several possible substance relationships
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public bool? IsDefining
            {
                get { return IsDefiningElement != null ? IsDefiningElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        IsDefiningElement = null; 
                    else
                        IsDefiningElement = new Hl7.Fhir.Model.FhirBoolean(value);
                    OnPropertyChanged("IsDefining");
                }
            }
            
            /// <summary>
            /// A numeric factor for the relationship, for instance to express that the salt of a substance has some percentage of the active substance in relation to some other
            /// </summary>
            [FhirElement("amount", InSummary=true, Order=70, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
			[AllowedTypes(typeof(Quantity),typeof(Hl7.Fhir.Model.Range),typeof(Hl7.Fhir.Model.Ratio),typeof(Hl7.Fhir.Model.FhirString))]
            [DataMember]
            public Hl7.Fhir.Model.Element Amount
            {
                get { return _Amount; }
                set { _Amount = value; OnPropertyChanged("Amount"); }
            }
            
            private Hl7.Fhir.Model.Element _Amount;
            
            /// <summary>
            /// For use when the numeric has an uncertain range
            /// </summary>
            [FhirElement("amountRatioHighLimit", InSummary=true, Order=80)]
            [DataMember]
            public Hl7.Fhir.Model.Ratio AmountRatioHighLimit
            {
                get { return _AmountRatioHighLimit; }
                set { _AmountRatioHighLimit = value; OnPropertyChanged("AmountRatioHighLimit"); }
            }
            
            private Hl7.Fhir.Model.Ratio _AmountRatioHighLimit;
            
            /// <summary>
            /// An operator for the amount, for example "average", "approximately", "less than"
            /// </summary>
            [FhirElement("amountType", InSummary=true, Order=90)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept AmountType
            {
                get { return _AmountType; }
                set { _AmountType = value; OnPropertyChanged("AmountType"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _AmountType;
            
            /// <summary>
            /// Supporting literature
            /// </summary>
            [FhirElement("source", InSummary=true, Order=100)]
            [CLSCompliant(false)]
			[References("DocumentReference")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.ResourceReference> Source
            {
                get { if(_Source==null) _Source = new List<Hl7.Fhir.Model.ResourceReference>(); return _Source; }
                set { _Source = value; OnPropertyChanged("Source"); }
            }
            
            private List<Hl7.Fhir.Model.ResourceReference> _Source;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RelationshipComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(SubstanceDefinition != null) dest.SubstanceDefinition = (Hl7.Fhir.Model.Element)SubstanceDefinition.DeepCopy();
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
                    if(IsDefiningElement != null) dest.IsDefiningElement = (Hl7.Fhir.Model.FhirBoolean)IsDefiningElement.DeepCopy();
                    if(Amount != null) dest.Amount = (Hl7.Fhir.Model.Element)Amount.DeepCopy();
                    if(AmountRatioHighLimit != null) dest.AmountRatioHighLimit = (Hl7.Fhir.Model.Ratio)AmountRatioHighLimit.DeepCopy();
                    if(AmountType != null) dest.AmountType = (Hl7.Fhir.Model.CodeableConcept)AmountType.DeepCopy();
                    if(Source != null) dest.Source = new List<Hl7.Fhir.Model.ResourceReference>(Source.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new RelationshipComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RelationshipComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(SubstanceDefinition, otherT.SubstanceDefinition)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(IsDefiningElement, otherT.IsDefiningElement)) return false;
                if( !DeepComparable.Matches(Amount, otherT.Amount)) return false;
                if( !DeepComparable.Matches(AmountRatioHighLimit, otherT.AmountRatioHighLimit)) return false;
                if( !DeepComparable.Matches(AmountType, otherT.AmountType)) return false;
                if( !DeepComparable.Matches(Source, otherT.Source)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RelationshipComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(SubstanceDefinition, otherT.SubstanceDefinition)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(IsDefiningElement, otherT.IsDefiningElement)) return false;
                if( !DeepComparable.IsExactly(Amount, otherT.Amount)) return false;
                if( !DeepComparable.IsExactly(AmountRatioHighLimit, otherT.AmountRatioHighLimit)) return false;
                if( !DeepComparable.IsExactly(AmountType, otherT.AmountType)) return false;
                if( !DeepComparable.IsExactly(Source, otherT.Source)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (SubstanceDefinition != null) yield return SubstanceDefinition;
                    if (Type != null) yield return Type;
                    if (IsDefiningElement != null) yield return IsDefiningElement;
                    if (Amount != null) yield return Amount;
                    if (AmountRatioHighLimit != null) yield return AmountRatioHighLimit;
                    if (AmountType != null) yield return AmountType;
                    foreach (var elem in Source) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (SubstanceDefinition != null) yield return new ElementValue("substanceDefinition", SubstanceDefinition);
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (IsDefiningElement != null) yield return new ElementValue("isDefining", IsDefiningElement);
                    if (Amount != null) yield return new ElementValue("amount", Amount);
                    if (AmountRatioHighLimit != null) yield return new ElementValue("amountRatioHighLimit", AmountRatioHighLimit);
                    if (AmountType != null) yield return new ElementValue("amountType", AmountType);
                    foreach (var elem in Source) { if (elem != null) yield return new ElementValue("source", elem); }
                }
            }

            
        }
        
        
        /// <summary>
        /// Identifier by which this substance is known
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=90)]
        [DataMember]
        public Hl7.Fhir.Model.Identifier Identifier
        {
            get { return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private Hl7.Fhir.Model.Identifier _Identifier;
        
        /// <summary>
        /// A business level identifier of the substance
        /// </summary>
        [FhirElement("version", InSummary=true, Order=100)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString VersionElement
        {
            get { return _VersionElement; }
            set { _VersionElement = value; OnPropertyChanged("VersionElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _VersionElement;
        
        /// <summary>
        /// A business level identifier of the substance
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
        /// Status of substance within the catalogue e.g. approved
        /// </summary>
        [FhirElement("status", InSummary=true, Order=110)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Status
        {
            get { return _Status; }
            set { _Status = value; OnPropertyChanged("Status"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Status;
        
        /// <summary>
        /// High level categorization, e.g. polymer or nucleic acid, or food, chemical, biological
        /// </summary>
        [FhirElement("category", InSummary=true, Order=120)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Category
        {
            get { return _Category; }
            set { _Category = value; OnPropertyChanged("Category"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Category;
        
        /// <summary>
        /// If the substance applies to only human or veterinary use
        /// </summary>
        [FhirElement("domain", InSummary=true, Order=130)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Domain
        {
            get { return _Domain; }
            set { _Domain = value; OnPropertyChanged("Domain"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Domain;
        
        /// <summary>
        /// Textual description of the substance
        /// </summary>
        [FhirElement("description", InSummary=true, Order=140)]
        [DataMember]
        public Hl7.Fhir.Model.Markdown Description
        {
            get { return _Description; }
            set { _Description = value; OnPropertyChanged("Description"); }
        }
        
        private Hl7.Fhir.Model.Markdown _Description;
        
        /// <summary>
        /// Supporting literature
        /// </summary>
        [FhirElement("source", InSummary=true, Order=150)]
        [CLSCompliant(false)]
		[References("DocumentReference")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ResourceReference> Source
        {
            get { if(_Source==null) _Source = new List<Hl7.Fhir.Model.ResourceReference>(); return _Source; }
            set { _Source = value; OnPropertyChanged("Source"); }
        }
        
        private List<Hl7.Fhir.Model.ResourceReference> _Source;
        
        /// <summary>
        /// Textual comment about this record of a substance
        /// </summary>
        [FhirElement("note", InSummary=true, Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Annotation> Note
        {
            get { if(_Note==null) _Note = new List<Hl7.Fhir.Model.Annotation>(); return _Note; }
            set { _Note = value; OnPropertyChanged("Note"); }
        }
        
        private List<Hl7.Fhir.Model.Annotation> _Note;
        
        /// <summary>
        /// A company that makes this substance
        /// </summary>
        [FhirElement("manufacturer", InSummary=true, Order=170)]
        [CLSCompliant(false)]
		[References("Organization")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ResourceReference> Manufacturer
        {
            get { if(_Manufacturer==null) _Manufacturer = new List<Hl7.Fhir.Model.ResourceReference>(); return _Manufacturer; }
            set { _Manufacturer = value; OnPropertyChanged("Manufacturer"); }
        }
        
        private List<Hl7.Fhir.Model.ResourceReference> _Manufacturer;
        
        /// <summary>
        /// A company that supplies this substance
        /// </summary>
        [FhirElement("supplier", InSummary=true, Order=180)]
        [CLSCompliant(false)]
		[References("Organization")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ResourceReference> Supplier
        {
            get { if(_Supplier==null) _Supplier = new List<Hl7.Fhir.Model.ResourceReference>(); return _Supplier; }
            set { _Supplier = value; OnPropertyChanged("Supplier"); }
        }
        
        private List<Hl7.Fhir.Model.ResourceReference> _Supplier;
        
        /// <summary>
        /// Moiety, for structural modifications
        /// </summary>
        [FhirElement("moiety", InSummary=true, Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.SubstanceDefinition.MoietyComponent> Moiety
        {
            get { if(_Moiety==null) _Moiety = new List<Hl7.Fhir.Model.SubstanceDefinition.MoietyComponent>(); return _Moiety; }
            set { _Moiety = value; OnPropertyChanged("Moiety"); }
        }
        
        private List<Hl7.Fhir.Model.SubstanceDefinition.MoietyComponent> _Moiety;
        
        /// <summary>
        /// General specifications for this substance, including how it is related to other substances
        /// </summary>
        [FhirElement("property", InSummary=true, Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.SubstanceDefinition.PropertyComponent> Property
        {
            get { if(_Property==null) _Property = new List<Hl7.Fhir.Model.SubstanceDefinition.PropertyComponent>(); return _Property; }
            set { _Property = value; OnPropertyChanged("Property"); }
        }
        
        private List<Hl7.Fhir.Model.SubstanceDefinition.PropertyComponent> _Property;
        
        /// <summary>
        /// General information detailing this substance
        /// </summary>
        [FhirElement("referenceInformation", InSummary=true, Order=210)]
        [CLSCompliant(false)]
		[References("SubstanceReferenceInformation")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference ReferenceInformation
        {
            get { return _ReferenceInformation; }
            set { _ReferenceInformation = value; OnPropertyChanged("ReferenceInformation"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _ReferenceInformation;
        
        /// <summary>
        /// Structural information
        /// </summary>
        [FhirElement("structure", InSummary=true, Order=220)]
        [DataMember]
        public Hl7.Fhir.Model.SubstanceDefinition.StructureComponent Structure
        {
            get { return _Structure; }
            set { _Structure = value; OnPropertyChanged("Structure"); }
        }
        
        private Hl7.Fhir.Model.SubstanceDefinition.StructureComponent _Structure;
        
        /// <summary>
        /// Codes associated with the substance
        /// </summary>
        [FhirElement("code", InSummary=true, Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.SubstanceDefinition.CodeComponent> Code
        {
            get { if(_Code==null) _Code = new List<Hl7.Fhir.Model.SubstanceDefinition.CodeComponent>(); return _Code; }
            set { _Code = value; OnPropertyChanged("Code"); }
        }
        
        private List<Hl7.Fhir.Model.SubstanceDefinition.CodeComponent> _Code;
        
        /// <summary>
        /// Names applicable to this substance
        /// </summary>
        [FhirElement("name", InSummary=true, Order=240)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.SubstanceDefinition.NameComponent> Name
        {
            get { if(_Name==null) _Name = new List<Hl7.Fhir.Model.SubstanceDefinition.NameComponent>(); return _Name; }
            set { _Name = value; OnPropertyChanged("Name"); }
        }
        
        private List<Hl7.Fhir.Model.SubstanceDefinition.NameComponent> _Name;
        
        /// <summary>
        /// The molecular weight or weight range (for proteins, polymers or nucleic acids)
        /// </summary>
        [FhirElement("molecularWeight", InSummary=true, Order=250)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.SubstanceDefinition.MolecularWeightComponent> MolecularWeight
        {
            get { if(_MolecularWeight==null) _MolecularWeight = new List<Hl7.Fhir.Model.SubstanceDefinition.MolecularWeightComponent>(); return _MolecularWeight; }
            set { _MolecularWeight = value; OnPropertyChanged("MolecularWeight"); }
        }
        
        private List<Hl7.Fhir.Model.SubstanceDefinition.MolecularWeightComponent> _MolecularWeight;
        
        /// <summary>
        /// A link between this substance and another, with details of the relationship
        /// </summary>
        [FhirElement("relationship", InSummary=true, Order=260)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.SubstanceDefinition.RelationshipComponent> Relationship
        {
            get { if(_Relationship==null) _Relationship = new List<Hl7.Fhir.Model.SubstanceDefinition.RelationshipComponent>(); return _Relationship; }
            set { _Relationship = value; OnPropertyChanged("Relationship"); }
        }
        
        private List<Hl7.Fhir.Model.SubstanceDefinition.RelationshipComponent> _Relationship;
        
        /// <summary>
        /// Data items specific to nucleic acids
        /// </summary>
        [FhirElement("nucleicAcid", InSummary=true, Order=270)]
        [CLSCompliant(false)]
		[References("SubstanceNucleicAcid")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference NucleicAcid
        {
            get { return _NucleicAcid; }
            set { _NucleicAcid = value; OnPropertyChanged("NucleicAcid"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _NucleicAcid;
        
        /// <summary>
        /// Data items specific to polymers
        /// </summary>
        [FhirElement("polymer", InSummary=true, Order=280)]
        [CLSCompliant(false)]
		[References("SubstancePolymer")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Polymer
        {
            get { return _Polymer; }
            set { _Polymer = value; OnPropertyChanged("Polymer"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Polymer;
        
        /// <summary>
        /// Data items specific to proteins
        /// </summary>
        [FhirElement("protein", InSummary=true, Order=290)]
        [CLSCompliant(false)]
		[References("SubstanceProtein")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Protein
        {
            get { return _Protein; }
            set { _Protein = value; OnPropertyChanged("Protein"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Protein;
        
        /// <summary>
        /// Material or taxonomic/anatomical source for the substance
        /// </summary>
        [FhirElement("sourceMaterial", InSummary=true, Order=300)]
        [CLSCompliant(false)]
		[References("SubstanceSourceMaterial")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference SourceMaterial
        {
            get { return _SourceMaterial; }
            set { _SourceMaterial = value; OnPropertyChanged("SourceMaterial"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _SourceMaterial;
        

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as SubstanceDefinition;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Identifier != null) dest.Identifier = (Hl7.Fhir.Model.Identifier)Identifier.DeepCopy();
                if(VersionElement != null) dest.VersionElement = (Hl7.Fhir.Model.FhirString)VersionElement.DeepCopy();
                if(Status != null) dest.Status = (Hl7.Fhir.Model.CodeableConcept)Status.DeepCopy();
                if(Category != null) dest.Category = (Hl7.Fhir.Model.CodeableConcept)Category.DeepCopy();
                if(Domain != null) dest.Domain = (Hl7.Fhir.Model.CodeableConcept)Domain.DeepCopy();
                if(Description != null) dest.Description = (Hl7.Fhir.Model.Markdown)Description.DeepCopy();
                if(Source != null) dest.Source = new List<Hl7.Fhir.Model.ResourceReference>(Source.DeepCopy());
                if(Note != null) dest.Note = new List<Hl7.Fhir.Model.Annotation>(Note.DeepCopy());
                if(Manufacturer != null) dest.Manufacturer = new List<Hl7.Fhir.Model.ResourceReference>(Manufacturer.DeepCopy());
                if(Supplier != null) dest.Supplier = new List<Hl7.Fhir.Model.ResourceReference>(Supplier.DeepCopy());
                if(Moiety != null) dest.Moiety = new List<Hl7.Fhir.Model.SubstanceDefinition.MoietyComponent>(Moiety.DeepCopy());
                if(Property != null) dest.Property = new List<Hl7.Fhir.Model.SubstanceDefinition.PropertyComponent>(Property.DeepCopy());
                if(ReferenceInformation != null) dest.ReferenceInformation = (Hl7.Fhir.Model.ResourceReference)ReferenceInformation.DeepCopy();
                if(Structure != null) dest.Structure = (Hl7.Fhir.Model.SubstanceDefinition.StructureComponent)Structure.DeepCopy();
                if(Code != null) dest.Code = new List<Hl7.Fhir.Model.SubstanceDefinition.CodeComponent>(Code.DeepCopy());
                if(Name != null) dest.Name = new List<Hl7.Fhir.Model.SubstanceDefinition.NameComponent>(Name.DeepCopy());
                if(MolecularWeight != null) dest.MolecularWeight = new List<Hl7.Fhir.Model.SubstanceDefinition.MolecularWeightComponent>(MolecularWeight.DeepCopy());
                if(Relationship != null) dest.Relationship = new List<Hl7.Fhir.Model.SubstanceDefinition.RelationshipComponent>(Relationship.DeepCopy());
                if(NucleicAcid != null) dest.NucleicAcid = (Hl7.Fhir.Model.ResourceReference)NucleicAcid.DeepCopy();
                if(Polymer != null) dest.Polymer = (Hl7.Fhir.Model.ResourceReference)Polymer.DeepCopy();
                if(Protein != null) dest.Protein = (Hl7.Fhir.Model.ResourceReference)Protein.DeepCopy();
                if(SourceMaterial != null) dest.SourceMaterial = (Hl7.Fhir.Model.ResourceReference)SourceMaterial.DeepCopy();
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new SubstanceDefinition());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as SubstanceDefinition;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
            if( !DeepComparable.Matches(Status, otherT.Status)) return false;
            if( !DeepComparable.Matches(Category, otherT.Category)) return false;
            if( !DeepComparable.Matches(Domain, otherT.Domain)) return false;
            if( !DeepComparable.Matches(Description, otherT.Description)) return false;
            if( !DeepComparable.Matches(Source, otherT.Source)) return false;
            if( !DeepComparable.Matches(Note, otherT.Note)) return false;
            if( !DeepComparable.Matches(Manufacturer, otherT.Manufacturer)) return false;
            if( !DeepComparable.Matches(Supplier, otherT.Supplier)) return false;
            if( !DeepComparable.Matches(Moiety, otherT.Moiety)) return false;
            if( !DeepComparable.Matches(Property, otherT.Property)) return false;
            if( !DeepComparable.Matches(ReferenceInformation, otherT.ReferenceInformation)) return false;
            if( !DeepComparable.Matches(Structure, otherT.Structure)) return false;
            if( !DeepComparable.Matches(Code, otherT.Code)) return false;
            if( !DeepComparable.Matches(Name, otherT.Name)) return false;
            if( !DeepComparable.Matches(MolecularWeight, otherT.MolecularWeight)) return false;
            if( !DeepComparable.Matches(Relationship, otherT.Relationship)) return false;
            if( !DeepComparable.Matches(NucleicAcid, otherT.NucleicAcid)) return false;
            if( !DeepComparable.Matches(Polymer, otherT.Polymer)) return false;
            if( !DeepComparable.Matches(Protein, otherT.Protein)) return false;
            if( !DeepComparable.Matches(SourceMaterial, otherT.SourceMaterial)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as SubstanceDefinition;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
            if( !DeepComparable.IsExactly(Status, otherT.Status)) return false;
            if( !DeepComparable.IsExactly(Category, otherT.Category)) return false;
            if( !DeepComparable.IsExactly(Domain, otherT.Domain)) return false;
            if( !DeepComparable.IsExactly(Description, otherT.Description)) return false;
            if( !DeepComparable.IsExactly(Source, otherT.Source)) return false;
            if( !DeepComparable.IsExactly(Note, otherT.Note)) return false;
            if( !DeepComparable.IsExactly(Manufacturer, otherT.Manufacturer)) return false;
            if( !DeepComparable.IsExactly(Supplier, otherT.Supplier)) return false;
            if( !DeepComparable.IsExactly(Moiety, otherT.Moiety)) return false;
            if( !DeepComparable.IsExactly(Property, otherT.Property)) return false;
            if( !DeepComparable.IsExactly(ReferenceInformation, otherT.ReferenceInformation)) return false;
            if( !DeepComparable.IsExactly(Structure, otherT.Structure)) return false;
            if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if( !DeepComparable.IsExactly(Name, otherT.Name)) return false;
            if( !DeepComparable.IsExactly(MolecularWeight, otherT.MolecularWeight)) return false;
            if( !DeepComparable.IsExactly(Relationship, otherT.Relationship)) return false;
            if( !DeepComparable.IsExactly(NucleicAcid, otherT.NucleicAcid)) return false;
            if( !DeepComparable.IsExactly(Polymer, otherT.Polymer)) return false;
            if( !DeepComparable.IsExactly(Protein, otherT.Protein)) return false;
            if( !DeepComparable.IsExactly(SourceMaterial, otherT.SourceMaterial)) return false;
            
            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
				if (Identifier != null) yield return Identifier;
				if (VersionElement != null) yield return VersionElement;
				if (Status != null) yield return Status;
				if (Category != null) yield return Category;
				if (Domain != null) yield return Domain;
				if (Description != null) yield return Description;
				foreach (var elem in Source) { if (elem != null) yield return elem; }
				foreach (var elem in Note) { if (elem != null) yield return elem; }
				foreach (var elem in Manufacturer) { if (elem != null) yield return elem; }
				foreach (var elem in Supplier) { if (elem != null) yield return elem; }
				foreach (var elem in Moiety) { if (elem != null) yield return elem; }
				foreach (var elem in Property) { if (elem != null) yield return elem; }
				if (ReferenceInformation != null) yield return ReferenceInformation;
				if (Structure != null) yield return Structure;
				foreach (var elem in Code) { if (elem != null) yield return elem; }
				foreach (var elem in Name) { if (elem != null) yield return elem; }
				foreach (var elem in MolecularWeight) { if (elem != null) yield return elem; }
				foreach (var elem in Relationship) { if (elem != null) yield return elem; }
				if (NucleicAcid != null) yield return NucleicAcid;
				if (Polymer != null) yield return Polymer;
				if (Protein != null) yield return Protein;
				if (SourceMaterial != null) yield return SourceMaterial;
            }
        }

        [NotMapped]
        public override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                if (VersionElement != null) yield return new ElementValue("version", VersionElement);
                if (Status != null) yield return new ElementValue("status", Status);
                if (Category != null) yield return new ElementValue("category", Category);
                if (Domain != null) yield return new ElementValue("domain", Domain);
                if (Description != null) yield return new ElementValue("description", Description);
                foreach (var elem in Source) { if (elem != null) yield return new ElementValue("source", elem); }
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
                foreach (var elem in Manufacturer) { if (elem != null) yield return new ElementValue("manufacturer", elem); }
                foreach (var elem in Supplier) { if (elem != null) yield return new ElementValue("supplier", elem); }
                foreach (var elem in Moiety) { if (elem != null) yield return new ElementValue("moiety", elem); }
                foreach (var elem in Property) { if (elem != null) yield return new ElementValue("property", elem); }
                if (ReferenceInformation != null) yield return new ElementValue("referenceInformation", ReferenceInformation);
                if (Structure != null) yield return new ElementValue("structure", Structure);
                foreach (var elem in Code) { if (elem != null) yield return new ElementValue("code", elem); }
                foreach (var elem in Name) { if (elem != null) yield return new ElementValue("name", elem); }
                foreach (var elem in MolecularWeight) { if (elem != null) yield return new ElementValue("molecularWeight", elem); }
                foreach (var elem in Relationship) { if (elem != null) yield return new ElementValue("relationship", elem); }
                if (NucleicAcid != null) yield return new ElementValue("nucleicAcid", NucleicAcid);
                if (Polymer != null) yield return new ElementValue("polymer", Polymer);
                if (Protein != null) yield return new ElementValue("protein", Protein);
                if (SourceMaterial != null) yield return new ElementValue("sourceMaterial", SourceMaterial);
            }
        }

    }
    
}
