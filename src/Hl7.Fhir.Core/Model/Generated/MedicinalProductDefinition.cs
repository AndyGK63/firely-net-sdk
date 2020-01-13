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
    /// Detailed definition of a medicinal product, typically for uses other than direct patient care (e.g. regulatory use)
    /// </summary>
    [FhirType("MedicinalProductDefinition", IsResource=true)]
    [DataContract]
    public partial class MedicinalProductDefinition : Hl7.Fhir.Model.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.MedicinalProductDefinition; } }
        [NotMapped]
        public override string TypeName { get { return "MedicinalProductDefinition"; } }
        
        [FhirType("ContactComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class ContactComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ContactComponent"; } }
            
            /// <summary>
            /// Allows the contact to be classified, for example QPPV, Pharmacovigilence Enquiry Information
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
            /// A product specific contact, person (in a role), or an organization
            /// </summary>
            [FhirElement("contact", InSummary=true, Order=50)]
            [CLSCompliant(false)]
			[References("Organization","PractitionerRole")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference Contact
            {
                get { return _Contact; }
                set { _Contact = value; OnPropertyChanged("Contact"); }
            }
            
            private Hl7.Fhir.Model.ResourceReference _Contact;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ContactComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
                    if(Contact != null) dest.Contact = (Hl7.Fhir.Model.ResourceReference)Contact.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ContactComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ContactComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ContactComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (Contact != null) yield return Contact;
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (Contact != null) yield return new ElementValue("contact", Contact);
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
            /// The full product name
            /// </summary>
            [FhirElement("productName", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString ProductNameElement
            {
                get { return _ProductNameElement; }
                set { _ProductNameElement = value; OnPropertyChanged("ProductNameElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _ProductNameElement;
            
            /// <summary>
            /// The full product name
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string ProductName
            {
                get { return ProductNameElement != null ? ProductNameElement.Value : null; }
                set
                {
                    if (value == null)
                        ProductNameElement = null; 
                    else
                        ProductNameElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("ProductName");
                }
            }
            
            /// <summary>
            /// Type of product name, such as rINN, BAN, Proprietary, Non-Proprietary
            /// </summary>
            [FhirElement("type", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.Coding Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.Coding _Type;
            
            /// <summary>
            /// Coding words or phrases of the name
            /// </summary>
            [FhirElement("namePart", InSummary=true, Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.MedicinalProductDefinition.NamePartComponent> NamePart
            {
                get { if(_NamePart==null) _NamePart = new List<Hl7.Fhir.Model.MedicinalProductDefinition.NamePartComponent>(); return _NamePart; }
                set { _NamePart = value; OnPropertyChanged("NamePart"); }
            }
            
            private List<Hl7.Fhir.Model.MedicinalProductDefinition.NamePartComponent> _NamePart;
            
            /// <summary>
            /// Country where the name applies
            /// </summary>
            [FhirElement("countryLanguage", InSummary=true, Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.MedicinalProductDefinition.CountryLanguageComponent> CountryLanguage
            {
                get { if(_CountryLanguage==null) _CountryLanguage = new List<Hl7.Fhir.Model.MedicinalProductDefinition.CountryLanguageComponent>(); return _CountryLanguage; }
                set { _CountryLanguage = value; OnPropertyChanged("CountryLanguage"); }
            }
            
            private List<Hl7.Fhir.Model.MedicinalProductDefinition.CountryLanguageComponent> _CountryLanguage;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as NameComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(ProductNameElement != null) dest.ProductNameElement = (Hl7.Fhir.Model.FhirString)ProductNameElement.DeepCopy();
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.Coding)Type.DeepCopy();
                    if(NamePart != null) dest.NamePart = new List<Hl7.Fhir.Model.MedicinalProductDefinition.NamePartComponent>(NamePart.DeepCopy());
                    if(CountryLanguage != null) dest.CountryLanguage = new List<Hl7.Fhir.Model.MedicinalProductDefinition.CountryLanguageComponent>(CountryLanguage.DeepCopy());
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
                if( !DeepComparable.Matches(ProductNameElement, otherT.ProductNameElement)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(NamePart, otherT.NamePart)) return false;
                if( !DeepComparable.Matches(CountryLanguage, otherT.CountryLanguage)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as NameComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(ProductNameElement, otherT.ProductNameElement)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(NamePart, otherT.NamePart)) return false;
                if( !DeepComparable.IsExactly(CountryLanguage, otherT.CountryLanguage)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (ProductNameElement != null) yield return ProductNameElement;
                    if (Type != null) yield return Type;
                    foreach (var elem in NamePart) { if (elem != null) yield return elem; }
                    foreach (var elem in CountryLanguage) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (ProductNameElement != null) yield return new ElementValue("productName", ProductNameElement);
                    if (Type != null) yield return new ElementValue("type", Type);
                    foreach (var elem in NamePart) { if (elem != null) yield return new ElementValue("namePart", elem); }
                    foreach (var elem in CountryLanguage) { if (elem != null) yield return new ElementValue("countryLanguage", elem); }
                }
            }

            
        }
        
        
        [FhirType("NamePartComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class NamePartComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "NamePartComponent"; } }
            
            /// <summary>
            /// A fragment of a product name
            /// </summary>
            [FhirElement("part", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString PartElement
            {
                get { return _PartElement; }
                set { _PartElement = value; OnPropertyChanged("PartElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _PartElement;
            
            /// <summary>
            /// A fragment of a product name
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Part
            {
                get { return PartElement != null ? PartElement.Value : null; }
                set
                {
                    if (value == null)
                        PartElement = null; 
                    else
                        PartElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Part");
                }
            }
            
            /// <summary>
            /// Idenifying type for this part of the name (e.g. strength part)
            /// </summary>
            [FhirElement("type", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Coding Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.Coding _Type;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as NamePartComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(PartElement != null) dest.PartElement = (Hl7.Fhir.Model.FhirString)PartElement.DeepCopy();
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.Coding)Type.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new NamePartComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as NamePartComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(PartElement, otherT.PartElement)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as NamePartComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(PartElement, otherT.PartElement)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (PartElement != null) yield return PartElement;
                    if (Type != null) yield return Type;
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (PartElement != null) yield return new ElementValue("part", PartElement);
                    if (Type != null) yield return new ElementValue("type", Type);
                }
            }

            
        }
        
        
        [FhirType("CountryLanguageComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class CountryLanguageComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "CountryLanguageComponent"; } }
            
            /// <summary>
            /// Country code for where this name applies
            /// </summary>
            [FhirElement("country", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Country
            {
                get { return _Country; }
                set { _Country = value; OnPropertyChanged("Country"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Country;
            
            /// <summary>
            /// Jurisdiction code for where this name applies
            /// </summary>
            [FhirElement("jurisdiction", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Jurisdiction
            {
                get { return _Jurisdiction; }
                set { _Jurisdiction = value; OnPropertyChanged("Jurisdiction"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Jurisdiction;
            
            /// <summary>
            /// Language code for this name
            /// </summary>
            [FhirElement("language", InSummary=true, Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Language
            {
                get { return _Language; }
                set { _Language = value; OnPropertyChanged("Language"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Language;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CountryLanguageComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Country != null) dest.Country = (Hl7.Fhir.Model.CodeableConcept)Country.DeepCopy();
                    if(Jurisdiction != null) dest.Jurisdiction = (Hl7.Fhir.Model.CodeableConcept)Jurisdiction.DeepCopy();
                    if(Language != null) dest.Language = (Hl7.Fhir.Model.CodeableConcept)Language.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new CountryLanguageComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as CountryLanguageComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Country, otherT.Country)) return false;
                if( !DeepComparable.Matches(Jurisdiction, otherT.Jurisdiction)) return false;
                if( !DeepComparable.Matches(Language, otherT.Language)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CountryLanguageComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Country, otherT.Country)) return false;
                if( !DeepComparable.IsExactly(Jurisdiction, otherT.Jurisdiction)) return false;
                if( !DeepComparable.IsExactly(Language, otherT.Language)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Country != null) yield return Country;
                    if (Jurisdiction != null) yield return Jurisdiction;
                    if (Language != null) yield return Language;
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Country != null) yield return new ElementValue("country", Country);
                    if (Jurisdiction != null) yield return new ElementValue("jurisdiction", Jurisdiction);
                    if (Language != null) yield return new ElementValue("language", Language);
                }
            }

            
        }
        
        
        [FhirType("CrossReferenceComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class CrossReferenceComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "CrossReferenceComponent"; } }
            
            /// <summary>
            /// Reference to another product, e.g. for linking authorised to investigational product
            /// </summary>
            [FhirElement("product", InSummary=true, Order=40, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
			[AllowedTypes(typeof(Hl7.Fhir.Model.Identifier),typeof(Hl7.Fhir.Model.ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Element Product
            {
                get { return _Product; }
                set { _Product = value; OnPropertyChanged("Product"); }
            }
            
            private Hl7.Fhir.Model.Element _Product;
            
            /// <summary>
            /// The type of relationship, for instance branded to generic, product to development product (investigational), parallel import version
            /// </summary>
            [FhirElement("type", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.Coding Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.Coding _Type;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CrossReferenceComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Product != null) dest.Product = (Hl7.Fhir.Model.Element)Product.DeepCopy();
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.Coding)Type.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new CrossReferenceComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as CrossReferenceComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Product, otherT.Product)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CrossReferenceComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Product, otherT.Product)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Product != null) yield return Product;
                    if (Type != null) yield return Type;
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Product != null) yield return new ElementValue("product", Product);
                    if (Type != null) yield return new ElementValue("type", Type);
                }
            }

            
        }
        
        
        [FhirType("ManufacturingBusinessOperationComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class ManufacturingBusinessOperationComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ManufacturingBusinessOperationComponent"; } }
            
            /// <summary>
            /// The type of manufacturing operation e.g. manufacturing itself, re-packaging. This may be a subtype of some other wider scope of authorized operation, referenced by the authorization attribute
            /// </summary>
            [FhirElement("type", InSummary=true, Order=40, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
			[AllowedTypes(typeof(Hl7.Fhir.Model.Coding),typeof(Hl7.Fhir.Model.ResourceReference))]
            [DataMember]
            public Hl7.Fhir.Model.Element Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.Element _Type;
            
            /// <summary>
            /// Date range of applicability
            /// </summary>
            [FhirElement("effectiveDate", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.Period EffectiveDate
            {
                get { return _EffectiveDate; }
                set { _EffectiveDate = value; OnPropertyChanged("EffectiveDate"); }
            }
            
            private Hl7.Fhir.Model.Period _EffectiveDate;
            
            /// <summary>
            /// The manufacturer or establishment associated with the process
            /// </summary>
            [FhirElement("manufacturer", InSummary=true, Order=60)]
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
            /// An authorization for this process, either as a logical reference, holding just an identifier, or a full refererence to a resource that captures the details. The authorization mayu possibly apply to several products or a wider scope of process of which this is a part
            /// </summary>
            [FhirElement("authorization", InSummary=true, Order=70)]
            [CLSCompliant(false)]
			[References("RegulatedAuthorization")]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference Authorization
            {
                get { return _Authorization; }
                set { _Authorization = value; OnPropertyChanged("Authorization"); }
            }
            
            private Hl7.Fhir.Model.ResourceReference _Authorization;
            
            /// <summary>
            /// To indicate if this proces is commercially confidential
            /// </summary>
            [FhirElement("confidentialityIndicator", InSummary=true, Order=80)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept ConfidentialityIndicator
            {
                get { return _ConfidentialityIndicator; }
                set { _ConfidentialityIndicator = value; OnPropertyChanged("ConfidentialityIndicator"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _ConfidentialityIndicator;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ManufacturingBusinessOperationComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.Element)Type.DeepCopy();
                    if(EffectiveDate != null) dest.EffectiveDate = (Hl7.Fhir.Model.Period)EffectiveDate.DeepCopy();
                    if(Manufacturer != null) dest.Manufacturer = new List<Hl7.Fhir.Model.ResourceReference>(Manufacturer.DeepCopy());
                    if(Authorization != null) dest.Authorization = (Hl7.Fhir.Model.ResourceReference)Authorization.DeepCopy();
                    if(ConfidentialityIndicator != null) dest.ConfidentialityIndicator = (Hl7.Fhir.Model.CodeableConcept)ConfidentialityIndicator.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ManufacturingBusinessOperationComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ManufacturingBusinessOperationComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(EffectiveDate, otherT.EffectiveDate)) return false;
                if( !DeepComparable.Matches(Manufacturer, otherT.Manufacturer)) return false;
                if( !DeepComparable.Matches(Authorization, otherT.Authorization)) return false;
                if( !DeepComparable.Matches(ConfidentialityIndicator, otherT.ConfidentialityIndicator)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ManufacturingBusinessOperationComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(EffectiveDate, otherT.EffectiveDate)) return false;
                if( !DeepComparable.IsExactly(Manufacturer, otherT.Manufacturer)) return false;
                if( !DeepComparable.IsExactly(Authorization, otherT.Authorization)) return false;
                if( !DeepComparable.IsExactly(ConfidentialityIndicator, otherT.ConfidentialityIndicator)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (EffectiveDate != null) yield return EffectiveDate;
                    foreach (var elem in Manufacturer) { if (elem != null) yield return elem; }
                    if (Authorization != null) yield return Authorization;
                    if (ConfidentialityIndicator != null) yield return ConfidentialityIndicator;
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (EffectiveDate != null) yield return new ElementValue("effectiveDate", EffectiveDate);
                    foreach (var elem in Manufacturer) { if (elem != null) yield return new ElementValue("manufacturer", elem); }
                    if (Authorization != null) yield return new ElementValue("authorization", Authorization);
                    if (ConfidentialityIndicator != null) yield return new ElementValue("confidentialityIndicator", ConfidentialityIndicator);
                }
            }

            
        }
        
        
        /// <summary>
        /// Business identifier for this product. Could be an MPID
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
        /// Regulatory type, e.g. Investigational or Authorized
        /// </summary>
        [FhirElement("type", InSummary=true, Order=100)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Type
        {
            get { return _Type; }
            set { _Type = value; OnPropertyChanged("Type"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Type;
        
        /// <summary>
        /// If this medicine applies to human or veterinary uses
        /// </summary>
        [FhirElement("domain", InSummary=true, Order=110)]
        [DataMember]
        public Hl7.Fhir.Model.Coding Domain
        {
            get { return _Domain; }
            set { _Domain = value; OnPropertyChanged("Domain"); }
        }
        
        private Hl7.Fhir.Model.Coding _Domain;
        
        /// <summary>
        /// A business level identifier of the product
        /// </summary>
        [FhirElement("version", InSummary=true, Order=120)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString VersionElement
        {
            get { return _VersionElement; }
            set { _VersionElement = value; OnPropertyChanged("VersionElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _VersionElement;
        
        /// <summary>
        /// A business level identifier of the product
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
        /// The status within the lifecycle of this product. A high level status, this is not intended to duplicate details carried elswhere such as legal status, or authorization status
        /// </summary>
        [FhirElement("status", InSummary=true, Order=130)]
        [DataMember]
        public Hl7.Fhir.Model.Coding Status
        {
            get { return _Status; }
            set { _Status = value; OnPropertyChanged("Status"); }
        }
        
        private Hl7.Fhir.Model.Coding _Status;
        
        /// <summary>
        /// General description of this product
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
        /// The dose form for a single part product, or combined form of a multiple part product
        /// </summary>
        [FhirElement("combinedPharmaceuticalDoseForm", InSummary=true, Order=150)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept CombinedPharmaceuticalDoseForm
        {
            get { return _CombinedPharmaceuticalDoseForm; }
            set { _CombinedPharmaceuticalDoseForm = value; OnPropertyChanged("CombinedPharmaceuticalDoseForm"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _CombinedPharmaceuticalDoseForm;
        
        /// <summary>
        /// General combined description of indication(s) for this product. See also MedicinalProductDefinitionIndication
        /// </summary>
        [FhirElement("indication", InSummary=true, Order=160)]
        [DataMember]
        public Hl7.Fhir.Model.Markdown Indication
        {
            get { return _Indication; }
            set { _Indication = value; OnPropertyChanged("Indication"); }
        }
        
        private Hl7.Fhir.Model.Markdown _Indication;
        
        /// <summary>
        /// The legal status of supply of the medicinal product as classified by the regulator
        /// </summary>
        [FhirElement("legalStatusOfSupply", InSummary=true, Order=170)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept LegalStatusOfSupply
        {
            get { return _LegalStatusOfSupply; }
            set { _LegalStatusOfSupply = value; OnPropertyChanged("LegalStatusOfSupply"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _LegalStatusOfSupply;
        
        /// <summary>
        /// Whether the Medicinal Product is subject to additional monitoring for regulatory reasons
        /// </summary>
        [FhirElement("additionalMonitoringIndicator", InSummary=true, Order=180)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept AdditionalMonitoringIndicator
        {
            get { return _AdditionalMonitoringIndicator; }
            set { _AdditionalMonitoringIndicator = value; OnPropertyChanged("AdditionalMonitoringIndicator"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _AdditionalMonitoringIndicator;
        
        /// <summary>
        /// Whether the Medicinal Product is subject to special measures for regulatory reasons
        /// </summary>
        [FhirElement("specialMeasures", InSummary=true, Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> SpecialMeasures
        {
            get { if(_SpecialMeasures==null) _SpecialMeasures = new List<Hl7.Fhir.Model.CodeableConcept>(); return _SpecialMeasures; }
            set { _SpecialMeasures = value; OnPropertyChanged("SpecialMeasures"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _SpecialMeasures;
        
        /// <summary>
        /// If authorised for use in children
        /// </summary>
        [FhirElement("paediatricUseIndicator", InSummary=true, Order=200)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept PaediatricUseIndicator
        {
            get { return _PaediatricUseIndicator; }
            set { _PaediatricUseIndicator = value; OnPropertyChanged("PaediatricUseIndicator"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _PaediatricUseIndicator;
        
        /// <summary>
        /// Allows the product to be classified by various systems
        /// </summary>
        [FhirElement("productClassification", InSummary=true, Order=210)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> ProductClassification
        {
            get { if(_ProductClassification==null) _ProductClassification = new List<Hl7.Fhir.Model.CodeableConcept>(); return _ProductClassification; }
            set { _ProductClassification = value; OnPropertyChanged("ProductClassification"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _ProductClassification;
        
        /// <summary>
        /// Marketing status of the medicinal product, in contrast to marketing authorizaton
        /// </summary>
        [FhirElement("marketingStatus", InSummary=true, Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<MarketingStatus> MarketingStatus
        {
            get { if(_MarketingStatus==null) _MarketingStatus = new List<MarketingStatus>(); return _MarketingStatus; }
            set { _MarketingStatus = value; OnPropertyChanged("MarketingStatus"); }
        }
        
        private List<MarketingStatus> _MarketingStatus;
        
        /// <summary>
        /// Pharmaceutical aspects of product
        /// </summary>
        [FhirElement("pharmaceuticalProduct", InSummary=true, Order=230)]
        [CLSCompliant(false)]
		[References("AdministrableProductDefinition")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ResourceReference> PharmaceuticalProduct
        {
            get { if(_PharmaceuticalProduct==null) _PharmaceuticalProduct = new List<Hl7.Fhir.Model.ResourceReference>(); return _PharmaceuticalProduct; }
            set { _PharmaceuticalProduct = value; OnPropertyChanged("PharmaceuticalProduct"); }
        }
        
        private List<Hl7.Fhir.Model.ResourceReference> _PharmaceuticalProduct;
        
        /// <summary>
        /// Package representation for the product
        /// </summary>
        [FhirElement("packagedMedicinalProduct", InSummary=true, Order=240)]
        [CLSCompliant(false)]
		[References("PackagedProductDefinition")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ResourceReference> PackagedMedicinalProduct
        {
            get { if(_PackagedMedicinalProduct==null) _PackagedMedicinalProduct = new List<Hl7.Fhir.Model.ResourceReference>(); return _PackagedMedicinalProduct; }
            set { _PackagedMedicinalProduct = value; OnPropertyChanged("PackagedMedicinalProduct"); }
        }
        
        private List<Hl7.Fhir.Model.ResourceReference> _PackagedMedicinalProduct;
        
        /// <summary>
        /// The ingredients of this medicinal product - when not specified elsewhere. This is only needed if the ingredients are not specified by the pharmaceuticalProduct or packagedMedicinalProduct references above. In cases where those levels of detail are not used, the ingredients may be specified directly here
        /// </summary>
        [FhirElement("ingredient", InSummary=true, Order=250)]
        [CLSCompliant(false)]
		[References("Ingredient")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ResourceReference> Ingredient
        {
            get { if(_Ingredient==null) _Ingredient = new List<Hl7.Fhir.Model.ResourceReference>(); return _Ingredient; }
            set { _Ingredient = value; OnPropertyChanged("Ingredient"); }
        }
        
        private List<Hl7.Fhir.Model.ResourceReference> _Ingredient;
        
        /// <summary>
        /// Supporting documentation, typically for regulatory submission
        /// </summary>
        [FhirElement("attachedDocument", InSummary=true, Order=260)]
        [CLSCompliant(false)]
		[References("DocumentReference")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ResourceReference> AttachedDocument
        {
            get { if(_AttachedDocument==null) _AttachedDocument = new List<Hl7.Fhir.Model.ResourceReference>(); return _AttachedDocument; }
            set { _AttachedDocument = value; OnPropertyChanged("AttachedDocument"); }
        }
        
        private List<Hl7.Fhir.Model.ResourceReference> _AttachedDocument;
        
        /// <summary>
        /// A master file for to the medicinal product (e.g. Pharmacovigilance System Master File)
        /// </summary>
        [FhirElement("masterFile", InSummary=true, Order=270)]
        [CLSCompliant(false)]
		[References("DocumentReference")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ResourceReference> MasterFile
        {
            get { if(_MasterFile==null) _MasterFile = new List<Hl7.Fhir.Model.ResourceReference>(); return _MasterFile; }
            set { _MasterFile = value; OnPropertyChanged("MasterFile"); }
        }
        
        private List<Hl7.Fhir.Model.ResourceReference> _MasterFile;
        
        /// <summary>
        /// A product specific contact, person (in a role), or an organization
        /// </summary>
        [FhirElement("contact", InSummary=true, Order=280)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.MedicinalProductDefinition.ContactComponent> Contact
        {
            get { if(_Contact==null) _Contact = new List<Hl7.Fhir.Model.MedicinalProductDefinition.ContactComponent>(); return _Contact; }
            set { _Contact = value; OnPropertyChanged("Contact"); }
        }
        
        private List<Hl7.Fhir.Model.MedicinalProductDefinition.ContactComponent> _Contact;
        
        /// <summary>
        /// Clinical trials or studies that this product is involved in
        /// </summary>
        [FhirElement("clinicalTrial", InSummary=true, Order=290)]
        [CLSCompliant(false)]
		[References("ResearchStudy")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ResourceReference> ClinicalTrial
        {
            get { if(_ClinicalTrial==null) _ClinicalTrial = new List<Hl7.Fhir.Model.ResourceReference>(); return _ClinicalTrial; }
            set { _ClinicalTrial = value; OnPropertyChanged("ClinicalTrial"); }
        }
        
        private List<Hl7.Fhir.Model.ResourceReference> _ClinicalTrial;
        
        /// <summary>
        /// The product's name, including full name and possibly coded parts
        /// </summary>
        [FhirElement("name", InSummary=true, Order=300)]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.MedicinalProductDefinition.NameComponent> Name
        {
            get { if(_Name==null) _Name = new List<Hl7.Fhir.Model.MedicinalProductDefinition.NameComponent>(); return _Name; }
            set { _Name = value; OnPropertyChanged("Name"); }
        }
        
        private List<Hl7.Fhir.Model.MedicinalProductDefinition.NameComponent> _Name;
        
        /// <summary>
        /// Reference to another product, e.g. for linking authorised to investigational product
        /// </summary>
        [FhirElement("crossReference", InSummary=true, Order=310)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.MedicinalProductDefinition.CrossReferenceComponent> CrossReference
        {
            get { if(_CrossReference==null) _CrossReference = new List<Hl7.Fhir.Model.MedicinalProductDefinition.CrossReferenceComponent>(); return _CrossReference; }
            set { _CrossReference = value; OnPropertyChanged("CrossReference"); }
        }
        
        private List<Hl7.Fhir.Model.MedicinalProductDefinition.CrossReferenceComponent> _CrossReference;
        
        /// <summary>
        /// An operation applied to the product, for manufacturing or adminsitrative purpose
        /// </summary>
        [FhirElement("manufacturingBusinessOperation", InSummary=true, Order=320)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.MedicinalProductDefinition.ManufacturingBusinessOperationComponent> ManufacturingBusinessOperation
        {
            get { if(_ManufacturingBusinessOperation==null) _ManufacturingBusinessOperation = new List<Hl7.Fhir.Model.MedicinalProductDefinition.ManufacturingBusinessOperationComponent>(); return _ManufacturingBusinessOperation; }
            set { _ManufacturingBusinessOperation = value; OnPropertyChanged("ManufacturingBusinessOperation"); }
        }
        
        private List<Hl7.Fhir.Model.MedicinalProductDefinition.ManufacturingBusinessOperationComponent> _ManufacturingBusinessOperation;
        

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as MedicinalProductDefinition;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
                if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
                if(Domain != null) dest.Domain = (Hl7.Fhir.Model.Coding)Domain.DeepCopy();
                if(VersionElement != null) dest.VersionElement = (Hl7.Fhir.Model.FhirString)VersionElement.DeepCopy();
                if(Status != null) dest.Status = (Hl7.Fhir.Model.Coding)Status.DeepCopy();
                if(Description != null) dest.Description = (Hl7.Fhir.Model.Markdown)Description.DeepCopy();
                if(CombinedPharmaceuticalDoseForm != null) dest.CombinedPharmaceuticalDoseForm = (Hl7.Fhir.Model.CodeableConcept)CombinedPharmaceuticalDoseForm.DeepCopy();
                if(Indication != null) dest.Indication = (Hl7.Fhir.Model.Markdown)Indication.DeepCopy();
                if(LegalStatusOfSupply != null) dest.LegalStatusOfSupply = (Hl7.Fhir.Model.CodeableConcept)LegalStatusOfSupply.DeepCopy();
                if(AdditionalMonitoringIndicator != null) dest.AdditionalMonitoringIndicator = (Hl7.Fhir.Model.CodeableConcept)AdditionalMonitoringIndicator.DeepCopy();
                if(SpecialMeasures != null) dest.SpecialMeasures = new List<Hl7.Fhir.Model.CodeableConcept>(SpecialMeasures.DeepCopy());
                if(PaediatricUseIndicator != null) dest.PaediatricUseIndicator = (Hl7.Fhir.Model.CodeableConcept)PaediatricUseIndicator.DeepCopy();
                if(ProductClassification != null) dest.ProductClassification = new List<Hl7.Fhir.Model.CodeableConcept>(ProductClassification.DeepCopy());
                if(MarketingStatus != null) dest.MarketingStatus = new List<MarketingStatus>(MarketingStatus.DeepCopy());
                if(PharmaceuticalProduct != null) dest.PharmaceuticalProduct = new List<Hl7.Fhir.Model.ResourceReference>(PharmaceuticalProduct.DeepCopy());
                if(PackagedMedicinalProduct != null) dest.PackagedMedicinalProduct = new List<Hl7.Fhir.Model.ResourceReference>(PackagedMedicinalProduct.DeepCopy());
                if(Ingredient != null) dest.Ingredient = new List<Hl7.Fhir.Model.ResourceReference>(Ingredient.DeepCopy());
                if(AttachedDocument != null) dest.AttachedDocument = new List<Hl7.Fhir.Model.ResourceReference>(AttachedDocument.DeepCopy());
                if(MasterFile != null) dest.MasterFile = new List<Hl7.Fhir.Model.ResourceReference>(MasterFile.DeepCopy());
                if(Contact != null) dest.Contact = new List<Hl7.Fhir.Model.MedicinalProductDefinition.ContactComponent>(Contact.DeepCopy());
                if(ClinicalTrial != null) dest.ClinicalTrial = new List<Hl7.Fhir.Model.ResourceReference>(ClinicalTrial.DeepCopy());
                if(Name != null) dest.Name = new List<Hl7.Fhir.Model.MedicinalProductDefinition.NameComponent>(Name.DeepCopy());
                if(CrossReference != null) dest.CrossReference = new List<Hl7.Fhir.Model.MedicinalProductDefinition.CrossReferenceComponent>(CrossReference.DeepCopy());
                if(ManufacturingBusinessOperation != null) dest.ManufacturingBusinessOperation = new List<Hl7.Fhir.Model.MedicinalProductDefinition.ManufacturingBusinessOperationComponent>(ManufacturingBusinessOperation.DeepCopy());
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new MedicinalProductDefinition());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as MedicinalProductDefinition;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(Type, otherT.Type)) return false;
            if( !DeepComparable.Matches(Domain, otherT.Domain)) return false;
            if( !DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
            if( !DeepComparable.Matches(Status, otherT.Status)) return false;
            if( !DeepComparable.Matches(Description, otherT.Description)) return false;
            if( !DeepComparable.Matches(CombinedPharmaceuticalDoseForm, otherT.CombinedPharmaceuticalDoseForm)) return false;
            if( !DeepComparable.Matches(Indication, otherT.Indication)) return false;
            if( !DeepComparable.Matches(LegalStatusOfSupply, otherT.LegalStatusOfSupply)) return false;
            if( !DeepComparable.Matches(AdditionalMonitoringIndicator, otherT.AdditionalMonitoringIndicator)) return false;
            if( !DeepComparable.Matches(SpecialMeasures, otherT.SpecialMeasures)) return false;
            if( !DeepComparable.Matches(PaediatricUseIndicator, otherT.PaediatricUseIndicator)) return false;
            if( !DeepComparable.Matches(ProductClassification, otherT.ProductClassification)) return false;
            if( !DeepComparable.Matches(MarketingStatus, otherT.MarketingStatus)) return false;
            if( !DeepComparable.Matches(PharmaceuticalProduct, otherT.PharmaceuticalProduct)) return false;
            if( !DeepComparable.Matches(PackagedMedicinalProduct, otherT.PackagedMedicinalProduct)) return false;
            if( !DeepComparable.Matches(Ingredient, otherT.Ingredient)) return false;
            if( !DeepComparable.Matches(AttachedDocument, otherT.AttachedDocument)) return false;
            if( !DeepComparable.Matches(MasterFile, otherT.MasterFile)) return false;
            if( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if( !DeepComparable.Matches(ClinicalTrial, otherT.ClinicalTrial)) return false;
            if( !DeepComparable.Matches(Name, otherT.Name)) return false;
            if( !DeepComparable.Matches(CrossReference, otherT.CrossReference)) return false;
            if( !DeepComparable.Matches(ManufacturingBusinessOperation, otherT.ManufacturingBusinessOperation)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as MedicinalProductDefinition;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if( !DeepComparable.IsExactly(Domain, otherT.Domain)) return false;
            if( !DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
            if( !DeepComparable.IsExactly(Status, otherT.Status)) return false;
            if( !DeepComparable.IsExactly(Description, otherT.Description)) return false;
            if( !DeepComparable.IsExactly(CombinedPharmaceuticalDoseForm, otherT.CombinedPharmaceuticalDoseForm)) return false;
            if( !DeepComparable.IsExactly(Indication, otherT.Indication)) return false;
            if( !DeepComparable.IsExactly(LegalStatusOfSupply, otherT.LegalStatusOfSupply)) return false;
            if( !DeepComparable.IsExactly(AdditionalMonitoringIndicator, otherT.AdditionalMonitoringIndicator)) return false;
            if( !DeepComparable.IsExactly(SpecialMeasures, otherT.SpecialMeasures)) return false;
            if( !DeepComparable.IsExactly(PaediatricUseIndicator, otherT.PaediatricUseIndicator)) return false;
            if( !DeepComparable.IsExactly(ProductClassification, otherT.ProductClassification)) return false;
            if( !DeepComparable.IsExactly(MarketingStatus, otherT.MarketingStatus)) return false;
            if( !DeepComparable.IsExactly(PharmaceuticalProduct, otherT.PharmaceuticalProduct)) return false;
            if( !DeepComparable.IsExactly(PackagedMedicinalProduct, otherT.PackagedMedicinalProduct)) return false;
            if( !DeepComparable.IsExactly(Ingredient, otherT.Ingredient)) return false;
            if( !DeepComparable.IsExactly(AttachedDocument, otherT.AttachedDocument)) return false;
            if( !DeepComparable.IsExactly(MasterFile, otherT.MasterFile)) return false;
            if( !DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if( !DeepComparable.IsExactly(ClinicalTrial, otherT.ClinicalTrial)) return false;
            if( !DeepComparable.IsExactly(Name, otherT.Name)) return false;
            if( !DeepComparable.IsExactly(CrossReference, otherT.CrossReference)) return false;
            if( !DeepComparable.IsExactly(ManufacturingBusinessOperation, otherT.ManufacturingBusinessOperation)) return false;
            
            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
				foreach (var elem in Identifier) { if (elem != null) yield return elem; }
				if (Type != null) yield return Type;
				if (Domain != null) yield return Domain;
				if (VersionElement != null) yield return VersionElement;
				if (Status != null) yield return Status;
				if (Description != null) yield return Description;
				if (CombinedPharmaceuticalDoseForm != null) yield return CombinedPharmaceuticalDoseForm;
				if (Indication != null) yield return Indication;
				if (LegalStatusOfSupply != null) yield return LegalStatusOfSupply;
				if (AdditionalMonitoringIndicator != null) yield return AdditionalMonitoringIndicator;
				foreach (var elem in SpecialMeasures) { if (elem != null) yield return elem; }
				if (PaediatricUseIndicator != null) yield return PaediatricUseIndicator;
				foreach (var elem in ProductClassification) { if (elem != null) yield return elem; }
				foreach (var elem in MarketingStatus) { if (elem != null) yield return elem; }
				foreach (var elem in PharmaceuticalProduct) { if (elem != null) yield return elem; }
				foreach (var elem in PackagedMedicinalProduct) { if (elem != null) yield return elem; }
				foreach (var elem in Ingredient) { if (elem != null) yield return elem; }
				foreach (var elem in AttachedDocument) { if (elem != null) yield return elem; }
				foreach (var elem in MasterFile) { if (elem != null) yield return elem; }
				foreach (var elem in Contact) { if (elem != null) yield return elem; }
				foreach (var elem in ClinicalTrial) { if (elem != null) yield return elem; }
				foreach (var elem in Name) { if (elem != null) yield return elem; }
				foreach (var elem in CrossReference) { if (elem != null) yield return elem; }
				foreach (var elem in ManufacturingBusinessOperation) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        public override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (Type != null) yield return new ElementValue("type", Type);
                if (Domain != null) yield return new ElementValue("domain", Domain);
                if (VersionElement != null) yield return new ElementValue("version", VersionElement);
                if (Status != null) yield return new ElementValue("status", Status);
                if (Description != null) yield return new ElementValue("description", Description);
                if (CombinedPharmaceuticalDoseForm != null) yield return new ElementValue("combinedPharmaceuticalDoseForm", CombinedPharmaceuticalDoseForm);
                if (Indication != null) yield return new ElementValue("indication", Indication);
                if (LegalStatusOfSupply != null) yield return new ElementValue("legalStatusOfSupply", LegalStatusOfSupply);
                if (AdditionalMonitoringIndicator != null) yield return new ElementValue("additionalMonitoringIndicator", AdditionalMonitoringIndicator);
                foreach (var elem in SpecialMeasures) { if (elem != null) yield return new ElementValue("specialMeasures", elem); }
                if (PaediatricUseIndicator != null) yield return new ElementValue("paediatricUseIndicator", PaediatricUseIndicator);
                foreach (var elem in ProductClassification) { if (elem != null) yield return new ElementValue("productClassification", elem); }
                foreach (var elem in MarketingStatus) { if (elem != null) yield return new ElementValue("marketingStatus", elem); }
                foreach (var elem in PharmaceuticalProduct) { if (elem != null) yield return new ElementValue("pharmaceuticalProduct", elem); }
                foreach (var elem in PackagedMedicinalProduct) { if (elem != null) yield return new ElementValue("packagedMedicinalProduct", elem); }
                foreach (var elem in Ingredient) { if (elem != null) yield return new ElementValue("ingredient", elem); }
                foreach (var elem in AttachedDocument) { if (elem != null) yield return new ElementValue("attachedDocument", elem); }
                foreach (var elem in MasterFile) { if (elem != null) yield return new ElementValue("masterFile", elem); }
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
                foreach (var elem in ClinicalTrial) { if (elem != null) yield return new ElementValue("clinicalTrial", elem); }
                foreach (var elem in Name) { if (elem != null) yield return new ElementValue("name", elem); }
                foreach (var elem in CrossReference) { if (elem != null) yield return new ElementValue("crossReference", elem); }
                foreach (var elem in ManufacturingBusinessOperation) { if (elem != null) yield return new ElementValue("manufacturingBusinessOperation", elem); }
            }
        }

    }
    
}
