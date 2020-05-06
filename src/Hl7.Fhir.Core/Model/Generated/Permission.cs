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
    /// Permission
    /// </summary>
    [FhirType("Permission", IsResource=true)]
    [DataContract]
    public partial class Permission : Hl7.Fhir.Model.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Permission; } }
        [NotMapped]
        public override string TypeName { get { return "Permission"; } }
        
        /// <summary>
        /// Codes identifying the lifecycle stage of a product.
        /// (url: http://hl7.org/fhir/ValueSet/permission-status)
        /// </summary>
        [FhirEnumeration("PermissionStatus")]
        public enum PermissionStatus
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/permission-status)
            /// </summary>
            [EnumLiteral("active", "http://hl7.org/fhir/permission-status"), Description("Active")]
            Active,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/permission-status)
            /// </summary>
            [EnumLiteral("entered-in-error", "http://hl7.org/fhir/permission-status"), Description("Entered in Error")]
            EnteredInError,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/permission-status)
            /// </summary>
            [EnumLiteral("draft", "http://hl7.org/fhir/permission-status"), Description("Draft")]
            Draft,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/permission-status)
            /// </summary>
            [EnumLiteral("rejected", "http://hl7.org/fhir/permission-status"), Description("Rejected")]
            Rejected,
        }

        [FhirType("ProcessingActivityComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class ProcessingActivityComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ProcessingActivityComponent"; } }
            
            /// <summary>
            /// If the processing is a transfer, we must capture where it the data allowed or expected to be shared - with a party or person
            /// </summary>
            [FhirElement("partyReference", InSummary=true, Order=40)]
            [CLSCompliant(false)]
			[References("Organization")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.ResourceReference> PartyReference
            {
                get { if(_PartyReference==null) _PartyReference = new List<Hl7.Fhir.Model.ResourceReference>(); return _PartyReference; }
                set { _PartyReference = value; OnPropertyChanged("PartyReference"); }
            }
            
            private List<Hl7.Fhir.Model.ResourceReference> _PartyReference;
            
            /// <summary>
            /// If the processing is a transfer, or involves another party, we must capture where it the data allowed or expected to be shared - with a party or person. This can be a party instance or party type
            /// § Purpose – a specific purpose of the data
            /// </summary>
            [FhirElement("partyCodeableConcept", InSummary=true, Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.CodeableConcept> PartyCodeableConcept
            {
                get { if(_PartyCodeableConcept==null) _PartyCodeableConcept = new List<Hl7.Fhir.Model.CodeableConcept>(); return _PartyCodeableConcept; }
                set { _PartyCodeableConcept = value; OnPropertyChanged("PartyCodeableConcept"); }
            }
            
            private List<Hl7.Fhir.Model.CodeableConcept> _PartyCodeableConcept;
            
            /// <summary>
            /// The purpose for which the permission is given
            /// </summary>
            [FhirElement("purpose", InSummary=true, Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.CodeableConcept> Purpose
            {
                get { if(_Purpose==null) _Purpose = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Purpose; }
                set { _Purpose = value; OnPropertyChanged("Purpose"); }
            }
            
            private List<Hl7.Fhir.Model.CodeableConcept> _Purpose;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ProcessingActivityComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(PartyReference != null) dest.PartyReference = new List<Hl7.Fhir.Model.ResourceReference>(PartyReference.DeepCopy());
                    if(PartyCodeableConcept != null) dest.PartyCodeableConcept = new List<Hl7.Fhir.Model.CodeableConcept>(PartyCodeableConcept.DeepCopy());
                    if(Purpose != null) dest.Purpose = new List<Hl7.Fhir.Model.CodeableConcept>(Purpose.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ProcessingActivityComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ProcessingActivityComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(PartyReference, otherT.PartyReference)) return false;
                if( !DeepComparable.Matches(PartyCodeableConcept, otherT.PartyCodeableConcept)) return false;
                if( !DeepComparable.Matches(Purpose, otherT.Purpose)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ProcessingActivityComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(PartyReference, otherT.PartyReference)) return false;
                if( !DeepComparable.IsExactly(PartyCodeableConcept, otherT.PartyCodeableConcept)) return false;
                if( !DeepComparable.IsExactly(Purpose, otherT.Purpose)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in PartyReference) { if (elem != null) yield return elem; }
                    foreach (var elem in PartyCodeableConcept) { if (elem != null) yield return elem; }
                    foreach (var elem in Purpose) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in PartyReference) { if (elem != null) yield return new ElementValue("partyReference", elem); }
                    foreach (var elem in PartyCodeableConcept) { if (elem != null) yield return new ElementValue("partyCodeableConcept", elem); }
                    foreach (var elem in Purpose) { if (elem != null) yield return new ElementValue("purpose", elem); }
                }
            }

            
        }
        
        
        [FhirType("JustificationComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class JustificationComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "JustificationComponent"; } }
            
            /// <summary>
            /// Evidence – reference to consent, or a contract, or a policy, or a regulation, or an attachment that contains a screenshot
            /// </summary>
            [FhirElement("evidence", InSummary=true, Order=40)]
            [CLSCompliant(false)]
			[References("Consent")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.ResourceReference> Evidence
            {
                get { if(_Evidence==null) _Evidence = new List<Hl7.Fhir.Model.ResourceReference>(); return _Evidence; }
                set { _Evidence = value; OnPropertyChanged("Evidence"); }
            }
            
            private List<Hl7.Fhir.Model.ResourceReference> _Evidence;
            
            /// <summary>
            /// This would be a codeableconcept, or a coding, which can be constrained to , for example, the 6 grounds for processing in GDPR
            /// </summary>
            [FhirElement("grounds", InSummary=true, Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.CodeableConcept> Grounds
            {
                get { if(_Grounds==null) _Grounds = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Grounds; }
                set { _Grounds = value; OnPropertyChanged("Grounds"); }
            }
            
            private List<Hl7.Fhir.Model.CodeableConcept> _Grounds;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as JustificationComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Evidence != null) dest.Evidence = new List<Hl7.Fhir.Model.ResourceReference>(Evidence.DeepCopy());
                    if(Grounds != null) dest.Grounds = new List<Hl7.Fhir.Model.CodeableConcept>(Grounds.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new JustificationComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as JustificationComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Evidence, otherT.Evidence)) return false;
                if( !DeepComparable.Matches(Grounds, otherT.Grounds)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as JustificationComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Evidence, otherT.Evidence)) return false;
                if( !DeepComparable.IsExactly(Grounds, otherT.Grounds)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Evidence) { if (elem != null) yield return elem; }
                    foreach (var elem in Grounds) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Evidence) { if (elem != null) yield return new ElementValue("evidence", elem); }
                    foreach (var elem in Grounds) { if (elem != null) yield return new ElementValue("grounds", elem); }
                }
            }

            
        }
        
        
        /// <summary>
        /// active | entered-in-error | draft | rejected
        /// </summary>
        [FhirElement("status", InSummary=true, Order=90)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<Hl7.Fhir.Model.Permission.PermissionStatus> StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        
        private Code<Hl7.Fhir.Model.Permission.PermissionStatus> _StatusElement;
        
        /// <summary>
        /// active | entered-in-error | draft | rejected
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.Permission.PermissionStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.Permission.PermissionStatus>(value);
                OnPropertyChanged("Status");
            }
        }
        
        /// <summary>
        /// grant|refuse
        /// </summary>
        [FhirElement("intent", InSummary=true, Order=100)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Intent
        {
            get { return _Intent; }
            set { _Intent = value; OnPropertyChanged("Intent"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Intent;
        
        /// <summary>
        /// The person or entity that asserts the permission
        /// </summary>
        [FhirElement("asserter", InSummary=true, Order=110)]
        [CLSCompliant(false)]
		[References("Person")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Asserter
        {
            get { return _Asserter; }
            set { _Asserter = value; OnPropertyChanged("Asserter"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Asserter;
        
        /// <summary>
        /// The date that permission was asserted
        /// </summary>
        [FhirElement("assertionDate", InSummary=true, Order=120)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.FhirDateTime> AssertionDateElement
        {
            get { if(_AssertionDateElement==null) _AssertionDateElement = new List<Hl7.Fhir.Model.FhirDateTime>(); return _AssertionDateElement; }
            set { _AssertionDateElement = value; OnPropertyChanged("AssertionDateElement"); }
        }
        
        private List<Hl7.Fhir.Model.FhirDateTime> _AssertionDateElement;
        
        /// <summary>
        /// The date that permission was asserted
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public IEnumerable<string> AssertionDate
        {
            get { return AssertionDateElement != null ? AssertionDateElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                  AssertionDateElement = null; 
                else
                  AssertionDateElement = new List<Hl7.Fhir.Model.FhirDateTime>(value.Select(elem=>new Hl7.Fhir.Model.FhirDateTime(elem)));
                OnPropertyChanged("AssertionDate");
            }
        }
        
        /// <summary>
        /// The period in which the permission is active
        /// </summary>
        [FhirElement("validity", InSummary=true, Order=130)]
        [DataMember]
        public Hl7.Fhir.Model.Period Validity
        {
            get { return _Validity; }
            set { _Validity = value; OnPropertyChanged("Validity"); }
        }
        
        private Hl7.Fhir.Model.Period _Validity;
        
        /// <summary>
        /// The purpose for which the permission is given
        /// </summary>
        [FhirElement("purpose", InSummary=true, Order=140)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> Purpose
        {
            get { if(_Purpose==null) _Purpose = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Purpose; }
            set { _Purpose = value; OnPropertyChanged("Purpose"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _Purpose;
        
        /// <summary>
        /// This can be 1) the definition of data elements, or 2) a category or label) e.g. “sensitive”. It could also be a c) graph-like definition of a set of data elements
        /// </summary>
        [FhirElement("dataScope", InSummary=true, Order=150)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Expression> DataScope
        {
            get { if(_DataScope==null) _DataScope = new List<Expression>(); return _DataScope; }
            set { _DataScope = value; OnPropertyChanged("DataScope"); }
        }
        
        private List<Expression> _DataScope;
        
        /// <summary>
        /// A description or definition of which activities are allowed to be done on the data
        /// </summary>
        [FhirElement("processingActivity", InSummary=true, Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Permission.ProcessingActivityComponent> ProcessingActivity
        {
            get { if(_ProcessingActivity==null) _ProcessingActivity = new List<Hl7.Fhir.Model.Permission.ProcessingActivityComponent>(); return _ProcessingActivity; }
            set { _ProcessingActivity = value; OnPropertyChanged("ProcessingActivity"); }
        }
        
        private List<Hl7.Fhir.Model.Permission.ProcessingActivityComponent> _ProcessingActivity;
        
        /// <summary>
        /// The asserted justification for using the data
        /// </summary>
        [FhirElement("justification", InSummary=true, Order=170)]
        [DataMember]
        public Hl7.Fhir.Model.Permission.JustificationComponent Justification
        {
            get { return _Justification; }
            set { _Justification = value; OnPropertyChanged("Justification"); }
        }
        
        private Hl7.Fhir.Model.Permission.JustificationComponent _Justification;
        
        /// <summary>
        /// What limits apply to the use of the data
        /// </summary>
        [FhirElement("usageLimitations", InSummary=true, Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> UsageLimitations
        {
            get { if(_UsageLimitations==null) _UsageLimitations = new List<Hl7.Fhir.Model.CodeableConcept>(); return _UsageLimitations; }
            set { _UsageLimitations = value; OnPropertyChanged("UsageLimitations"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _UsageLimitations;
        

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Permission;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.Permission.PermissionStatus>)StatusElement.DeepCopy();
                if(Intent != null) dest.Intent = (Hl7.Fhir.Model.CodeableConcept)Intent.DeepCopy();
                if(Asserter != null) dest.Asserter = (Hl7.Fhir.Model.ResourceReference)Asserter.DeepCopy();
                if(AssertionDateElement != null) dest.AssertionDateElement = new List<Hl7.Fhir.Model.FhirDateTime>(AssertionDateElement.DeepCopy());
                if(Validity != null) dest.Validity = (Hl7.Fhir.Model.Period)Validity.DeepCopy();
                if(Purpose != null) dest.Purpose = new List<Hl7.Fhir.Model.CodeableConcept>(Purpose.DeepCopy());
                if(DataScope != null) dest.DataScope = new List<Expression>(DataScope.DeepCopy());
                if(ProcessingActivity != null) dest.ProcessingActivity = new List<Hl7.Fhir.Model.Permission.ProcessingActivityComponent>(ProcessingActivity.DeepCopy());
                if(Justification != null) dest.Justification = (Hl7.Fhir.Model.Permission.JustificationComponent)Justification.DeepCopy();
                if(UsageLimitations != null) dest.UsageLimitations = new List<Hl7.Fhir.Model.CodeableConcept>(UsageLimitations.DeepCopy());
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new Permission());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Permission;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(Intent, otherT.Intent)) return false;
            if( !DeepComparable.Matches(Asserter, otherT.Asserter)) return false;
            if( !DeepComparable.Matches(AssertionDateElement, otherT.AssertionDateElement)) return false;
            if( !DeepComparable.Matches(Validity, otherT.Validity)) return false;
            if( !DeepComparable.Matches(Purpose, otherT.Purpose)) return false;
            if( !DeepComparable.Matches(DataScope, otherT.DataScope)) return false;
            if( !DeepComparable.Matches(ProcessingActivity, otherT.ProcessingActivity)) return false;
            if( !DeepComparable.Matches(Justification, otherT.Justification)) return false;
            if( !DeepComparable.Matches(UsageLimitations, otherT.UsageLimitations)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Permission;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(Intent, otherT.Intent)) return false;
            if( !DeepComparable.IsExactly(Asserter, otherT.Asserter)) return false;
            if( !DeepComparable.IsExactly(AssertionDateElement, otherT.AssertionDateElement)) return false;
            if( !DeepComparable.IsExactly(Validity, otherT.Validity)) return false;
            if( !DeepComparable.IsExactly(Purpose, otherT.Purpose)) return false;
            if( !DeepComparable.IsExactly(DataScope, otherT.DataScope)) return false;
            if( !DeepComparable.IsExactly(ProcessingActivity, otherT.ProcessingActivity)) return false;
            if( !DeepComparable.IsExactly(Justification, otherT.Justification)) return false;
            if( !DeepComparable.IsExactly(UsageLimitations, otherT.UsageLimitations)) return false;
            
            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
				if (StatusElement != null) yield return StatusElement;
				if (Intent != null) yield return Intent;
				if (Asserter != null) yield return Asserter;
				foreach (var elem in AssertionDateElement) { if (elem != null) yield return elem; }
				if (Validity != null) yield return Validity;
				foreach (var elem in Purpose) { if (elem != null) yield return elem; }
				foreach (var elem in DataScope) { if (elem != null) yield return elem; }
				foreach (var elem in ProcessingActivity) { if (elem != null) yield return elem; }
				if (Justification != null) yield return Justification;
				foreach (var elem in UsageLimitations) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        public override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (Intent != null) yield return new ElementValue("intent", Intent);
                if (Asserter != null) yield return new ElementValue("asserter", Asserter);
                foreach (var elem in AssertionDateElement) { if (elem != null) yield return new ElementValue("assertionDate", elem); }
                if (Validity != null) yield return new ElementValue("validity", Validity);
                foreach (var elem in Purpose) { if (elem != null) yield return new ElementValue("purpose", elem); }
                foreach (var elem in DataScope) { if (elem != null) yield return new ElementValue("dataScope", elem); }
                foreach (var elem in ProcessingActivity) { if (elem != null) yield return new ElementValue("processingActivity", elem); }
                if (Justification != null) yield return new ElementValue("justification", Justification);
                foreach (var elem in UsageLimitations) { if (elem != null) yield return new ElementValue("usageLimitations", elem); }
            }
        }

    }
    
}
