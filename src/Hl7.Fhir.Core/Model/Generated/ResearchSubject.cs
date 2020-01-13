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
    /// Physical entity which is the primary unit of interest in the study
    /// </summary>
    [FhirType("ResearchSubject", IsResource=true)]
    [DataContract]
    public partial class ResearchSubject : Hl7.Fhir.Model.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ResearchSubject; } }
        [NotMapped]
        public override string TypeName { get { return "ResearchSubject"; } }
        
        /// <summary>
        /// Indicates the progression of a study subject through a study.
        /// (url: http://hl7.org/fhir/ValueSet/research-subject-status)
        /// </summary>
        [FhirEnumeration("ResearchSubjectStatus")]
        public enum ResearchSubjectStatus
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/research-subject-status)
            /// </summary>
            [EnumLiteral("candidate", "http://hl7.org/fhir/research-subject-status"), Description("Candidate")]
            Candidate,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/research-subject-status)
            /// </summary>
            [EnumLiteral("eligible", "http://hl7.org/fhir/research-subject-status"), Description("Eligible")]
            Eligible,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/research-subject-status)
            /// </summary>
            [EnumLiteral("follow-up", "http://hl7.org/fhir/research-subject-status"), Description("Follow-up")]
            FollowUp,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/research-subject-status)
            /// </summary>
            [EnumLiteral("ineligible", "http://hl7.org/fhir/research-subject-status"), Description("Ineligible")]
            Ineligible,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/research-subject-status)
            /// </summary>
            [EnumLiteral("not-registered", "http://hl7.org/fhir/research-subject-status"), Description("Not Registered")]
            NotRegistered,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/research-subject-status)
            /// </summary>
            [EnumLiteral("off-study", "http://hl7.org/fhir/research-subject-status"), Description("Off-study")]
            OffStudy,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/research-subject-status)
            /// </summary>
            [EnumLiteral("on-study", "http://hl7.org/fhir/research-subject-status"), Description("On-study")]
            OnStudy,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/research-subject-status)
            /// </summary>
            [EnumLiteral("on-study-intervention", "http://hl7.org/fhir/research-subject-status"), Description("On-study-intervention")]
            OnStudyIntervention,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/research-subject-status)
            /// </summary>
            [EnumLiteral("on-study-observation", "http://hl7.org/fhir/research-subject-status"), Description("On-study-observation")]
            OnStudyObservation,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/research-subject-status)
            /// </summary>
            [EnumLiteral("pending-on-study", "http://hl7.org/fhir/research-subject-status"), Description("Pending on-study")]
            PendingOnStudy,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/research-subject-status)
            /// </summary>
            [EnumLiteral("potential-candidate", "http://hl7.org/fhir/research-subject-status"), Description("Potential Candidate")]
            PotentialCandidate,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/research-subject-status)
            /// </summary>
            [EnumLiteral("screening", "http://hl7.org/fhir/research-subject-status"), Description("Screening")]
            Screening,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/research-subject-status)
            /// </summary>
            [EnumLiteral("withdrawn", "http://hl7.org/fhir/research-subject-status"), Description("Withdrawn")]
            Withdrawn,
        }

        [FhirType("ProgressComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class ProgressComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ProgressComponent"; } }
            
            /// <summary>
            /// Kind of state that is being described
            /// </summary>
            [FhirElement("type", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Type;
            
            /// <summary>
            /// candidate | eligible | follow-up | ineligible | not-registered | off-study | on-study | on-study-intervention | on-study-observation | pending-on-study | potential-candidate | screening | withdrawn
            /// </summary>
            [FhirElement("state", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept State
            {
                get { return _State; }
                set { _State = value; OnPropertyChanged("State"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _State;
            
            /// <summary>
            /// SignedUp | Screened | Randomized
            /// </summary>
            [FhirElement("milestone", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Milestone
            {
                get { return _Milestone; }
                set { _Milestone = value; OnPropertyChanged("Milestone"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Milestone;
            
            /// <summary>
            /// State change reason
            /// </summary>
            [FhirElement("reason", Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Reason
            {
                get { return _Reason; }
                set { _Reason = value; OnPropertyChanged("Reason"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Reason;
            
            /// <summary>
            /// State change date
            /// </summary>
            [FhirElement("startDate", Order=80)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirDateTime StartDateElement
            {
                get { return _StartDateElement; }
                set { _StartDateElement = value; OnPropertyChanged("StartDateElement"); }
            }
            
            private Hl7.Fhir.Model.FhirDateTime _StartDateElement;
            
            /// <summary>
            /// State change date
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string StartDate
            {
                get { return StartDateElement != null ? StartDateElement.Value : null; }
                set
                {
                    if (value == null)
                        StartDateElement = null; 
                    else
                        StartDateElement = new Hl7.Fhir.Model.FhirDateTime(value);
                    OnPropertyChanged("StartDate");
                }
            }
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ProgressComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
                    if(State != null) dest.State = (Hl7.Fhir.Model.CodeableConcept)State.DeepCopy();
                    if(Milestone != null) dest.Milestone = (Hl7.Fhir.Model.CodeableConcept)Milestone.DeepCopy();
                    if(Reason != null) dest.Reason = (Hl7.Fhir.Model.CodeableConcept)Reason.DeepCopy();
                    if(StartDateElement != null) dest.StartDateElement = (Hl7.Fhir.Model.FhirDateTime)StartDateElement.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ProgressComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ProgressComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(State, otherT.State)) return false;
                if( !DeepComparable.Matches(Milestone, otherT.Milestone)) return false;
                if( !DeepComparable.Matches(Reason, otherT.Reason)) return false;
                if( !DeepComparable.Matches(StartDateElement, otherT.StartDateElement)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ProgressComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(State, otherT.State)) return false;
                if( !DeepComparable.IsExactly(Milestone, otherT.Milestone)) return false;
                if( !DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
                if( !DeepComparable.IsExactly(StartDateElement, otherT.StartDateElement)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (State != null) yield return State;
                    if (Milestone != null) yield return Milestone;
                    if (Reason != null) yield return Reason;
                    if (StartDateElement != null) yield return StartDateElement;
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (State != null) yield return new ElementValue("state", State);
                    if (Milestone != null) yield return new ElementValue("milestone", Milestone);
                    if (Reason != null) yield return new ElementValue("reason", Reason);
                    if (StartDateElement != null) yield return new ElementValue("startDate", StartDateElement);
                }
            }

            
        }
        
        
        /// <summary>
        /// Business Identifier for research subject in a study
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
        /// candidate | eligible | follow-up | ineligible | not-registered | off-study | on-study | on-study-intervention | on-study-observation | pending-on-study | potential-candidate | screening | withdrawn
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<Hl7.Fhir.Model.ResearchSubject.ResearchSubjectStatus> StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        
        private Code<Hl7.Fhir.Model.ResearchSubject.ResearchSubjectStatus> _StatusElement;
        
        /// <summary>
        /// candidate | eligible | follow-up | ineligible | not-registered | off-study | on-study | on-study-intervention | on-study-observation | pending-on-study | potential-candidate | screening | withdrawn
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.ResearchSubject.ResearchSubjectStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.ResearchSubject.ResearchSubjectStatus>(value);
                OnPropertyChanged("Status");
            }
        }
        
        /// <summary>
        /// Subject status
        /// </summary>
        [FhirElement("progress", Order=110)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ResearchSubject.ProgressComponent> Progress
        {
            get { if(_Progress==null) _Progress = new List<Hl7.Fhir.Model.ResearchSubject.ProgressComponent>(); return _Progress; }
            set { _Progress = value; OnPropertyChanged("Progress"); }
        }
        
        private List<Hl7.Fhir.Model.ResearchSubject.ProgressComponent> _Progress;
        
        /// <summary>
        /// Start and end of participation
        /// </summary>
        [FhirElement("period", InSummary=true, Order=120)]
        [DataMember]
        public Hl7.Fhir.Model.Period Period
        {
            get { return _Period; }
            set { _Period = value; OnPropertyChanged("Period"); }
        }
        
        private Hl7.Fhir.Model.Period _Period;
        
        /// <summary>
        /// Study subject is part of
        /// </summary>
        [FhirElement("study", InSummary=true, Order=130)]
        [CLSCompliant(false)]
		[References("ResearchStudy")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Study
        {
            get { return _Study; }
            set { _Study = value; OnPropertyChanged("Study"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Study;
        
        /// <summary>
        /// Who is part of study
        /// </summary>
        [FhirElement("individual", InSummary=true, Order=140)]
        [CLSCompliant(false)]
		[References("Patient")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Individual
        {
            get { return _Individual; }
            set { _Individual = value; OnPropertyChanged("Individual"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Individual;
        
        /// <summary>
        /// What path should be followed
        /// </summary>
        [FhirElement("assignedArm", Order=150)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString AssignedArmElement
        {
            get { return _AssignedArmElement; }
            set { _AssignedArmElement = value; OnPropertyChanged("AssignedArmElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _AssignedArmElement;
        
        /// <summary>
        /// What path should be followed
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string AssignedArm
        {
            get { return AssignedArmElement != null ? AssignedArmElement.Value : null; }
            set
            {
                if (value == null)
                  AssignedArmElement = null; 
                else
                  AssignedArmElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("AssignedArm");
            }
        }
        
        /// <summary>
        /// What path was followed
        /// </summary>
        [FhirElement("actualArm", Order=160)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString ActualArmElement
        {
            get { return _ActualArmElement; }
            set { _ActualArmElement = value; OnPropertyChanged("ActualArmElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _ActualArmElement;
        
        /// <summary>
        /// What path was followed
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string ActualArm
        {
            get { return ActualArmElement != null ? ActualArmElement.Value : null; }
            set
            {
                if (value == null)
                  ActualArmElement = null; 
                else
                  ActualArmElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("ActualArm");
            }
        }
        
        /// <summary>
        /// Agreement to participate in study
        /// </summary>
        [FhirElement("consent", Order=170)]
        [CLSCompliant(false)]
		[References("Consent")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Consent
        {
            get { return _Consent; }
            set { _Consent = value; OnPropertyChanged("Consent"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Consent;
        

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ResearchSubject;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
                if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.ResearchSubject.ResearchSubjectStatus>)StatusElement.DeepCopy();
                if(Progress != null) dest.Progress = new List<Hl7.Fhir.Model.ResearchSubject.ProgressComponent>(Progress.DeepCopy());
                if(Period != null) dest.Period = (Hl7.Fhir.Model.Period)Period.DeepCopy();
                if(Study != null) dest.Study = (Hl7.Fhir.Model.ResourceReference)Study.DeepCopy();
                if(Individual != null) dest.Individual = (Hl7.Fhir.Model.ResourceReference)Individual.DeepCopy();
                if(AssignedArmElement != null) dest.AssignedArmElement = (Hl7.Fhir.Model.FhirString)AssignedArmElement.DeepCopy();
                if(ActualArmElement != null) dest.ActualArmElement = (Hl7.Fhir.Model.FhirString)ActualArmElement.DeepCopy();
                if(Consent != null) dest.Consent = (Hl7.Fhir.Model.ResourceReference)Consent.DeepCopy();
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new ResearchSubject());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ResearchSubject;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(Progress, otherT.Progress)) return false;
            if( !DeepComparable.Matches(Period, otherT.Period)) return false;
            if( !DeepComparable.Matches(Study, otherT.Study)) return false;
            if( !DeepComparable.Matches(Individual, otherT.Individual)) return false;
            if( !DeepComparable.Matches(AssignedArmElement, otherT.AssignedArmElement)) return false;
            if( !DeepComparable.Matches(ActualArmElement, otherT.ActualArmElement)) return false;
            if( !DeepComparable.Matches(Consent, otherT.Consent)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ResearchSubject;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(Progress, otherT.Progress)) return false;
            if( !DeepComparable.IsExactly(Period, otherT.Period)) return false;
            if( !DeepComparable.IsExactly(Study, otherT.Study)) return false;
            if( !DeepComparable.IsExactly(Individual, otherT.Individual)) return false;
            if( !DeepComparable.IsExactly(AssignedArmElement, otherT.AssignedArmElement)) return false;
            if( !DeepComparable.IsExactly(ActualArmElement, otherT.ActualArmElement)) return false;
            if( !DeepComparable.IsExactly(Consent, otherT.Consent)) return false;
            
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
				foreach (var elem in Progress) { if (elem != null) yield return elem; }
				if (Period != null) yield return Period;
				if (Study != null) yield return Study;
				if (Individual != null) yield return Individual;
				if (AssignedArmElement != null) yield return AssignedArmElement;
				if (ActualArmElement != null) yield return ActualArmElement;
				if (Consent != null) yield return Consent;
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
                foreach (var elem in Progress) { if (elem != null) yield return new ElementValue("progress", elem); }
                if (Period != null) yield return new ElementValue("period", Period);
                if (Study != null) yield return new ElementValue("study", Study);
                if (Individual != null) yield return new ElementValue("individual", Individual);
                if (AssignedArmElement != null) yield return new ElementValue("assignedArm", AssignedArmElement);
                if (ActualArmElement != null) yield return new ElementValue("actualArm", ActualArmElement);
                if (Consent != null) yield return new ElementValue("consent", Consent);
            }
        }

    }
    
}
