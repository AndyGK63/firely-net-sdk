﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Utility;
using Hl7.Fhir.Specification;

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

//
// Generated for FHIR v4.2.0
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// An ordered list (distribution) of statistics
    /// </summary>
    [FhirType("OrderedDistribution")]
    [DataContract]
    public partial class OrderedDistribution : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override string TypeName { get { return "OrderedDistribution"; } }
        
        [FhirType("IntervalComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class IntervalComponent : Hl7.Fhir.Model.Element, System.ComponentModel.INotifyPropertyChanged, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "IntervalComponent"; } }
            
            /// <summary>
            /// Relative order of interval
            /// </summary>
            [FhirElement("rankOrder", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Integer RankOrderElement
            {
                get { return _RankOrderElement; }
                set { _RankOrderElement = value; OnPropertyChanged("RankOrderElement"); }
            }
            
            private Hl7.Fhir.Model.Integer _RankOrderElement;
            
            /// <summary>
            /// Relative order of interval
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public int? RankOrder
            {
                get { return RankOrderElement != null ? RankOrderElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                      RankOrderElement = null; 
                    else
                      RankOrderElement = new Hl7.Fhir.Model.Integer(value);
                    OnPropertyChanged("RankOrder");
                }
            }
            
            /// <summary>
            /// Values and parameters for a single statistic related to the interval
            /// </summary>
            [FhirElement("intervalStatistic", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Statistic> IntervalStatistic
            {
                get { if(_IntervalStatistic==null) _IntervalStatistic = new List<Statistic>(); return _IntervalStatistic; }
                set { _IntervalStatistic = value; OnPropertyChanged("IntervalStatistic"); }
            }
            
            private List<Statistic> _IntervalStatistic;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as IntervalComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(RankOrderElement != null) dest.RankOrderElement = (Hl7.Fhir.Model.Integer)RankOrderElement.DeepCopy();
                    if(IntervalStatistic != null) dest.IntervalStatistic = new List<Statistic>(IntervalStatistic.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new IntervalComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as IntervalComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(RankOrderElement, otherT.RankOrderElement)) return false;
                if( !DeepComparable.Matches(IntervalStatistic, otherT.IntervalStatistic)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as IntervalComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(RankOrderElement, otherT.RankOrderElement)) return false;
                if( !DeepComparable.IsExactly(IntervalStatistic, otherT.IntervalStatistic)) return false;
                
                return true;
            }

            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (RankOrderElement != null) yield return RankOrderElement;
                    foreach (var elem in IntervalStatistic) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren 
            { 
                get 
                { 
                    foreach (var item in base.NamedChildren) yield return item; 
                    if (RankOrderElement != null) yield return new ElementValue("rankOrder", RankOrderElement);
                    foreach (var elem in IntervalStatistic) { if (elem != null) yield return new ElementValue("intervalStatistic", elem); }
 
                } 
            } 
            
        }                
        /// <summary>
        /// A description of the content and value of the statistic
        /// </summary>
        [FhirElement("description", Order=90)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString DescriptionElement
        {
            get { return _DescriptionElement; }
            set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _DescriptionElement;
        
        /// <summary>
        /// A description of the content and value of the statistic
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
        [FhirElement("note", Order=100)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Annotation> Note
        {
            get { if(_Note==null) _Note = new List<Hl7.Fhir.Model.Annotation>(); return _Note; }
            set { _Note = value; OnPropertyChanged("Note"); }
        }
        
        private List<Hl7.Fhir.Model.Annotation> _Note;
        
        /// <summary>
        /// Number of intervals in an array, eg 4 for quartiles
        /// </summary>
        [FhirElement("numberOfIntervals", InSummary=true, Order=110)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.Integer NumberOfIntervalsElement
        {
            get { return _NumberOfIntervalsElement; }
            set { _NumberOfIntervalsElement = value; OnPropertyChanged("NumberOfIntervalsElement"); }
        }
        
        private Hl7.Fhir.Model.Integer _NumberOfIntervalsElement;
        
        /// <summary>
        /// Number of intervals in an array, eg 4 for quartiles
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public int? NumberOfIntervals
        {
            get { return NumberOfIntervalsElement != null ? NumberOfIntervalsElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  NumberOfIntervalsElement = null; 
                else
                  NumberOfIntervalsElement = new Hl7.Fhir.Model.Integer(value);
                OnPropertyChanged("NumberOfIntervals");
            }
        }
        
        /// <summary>
        /// Bottom of first interval
        /// </summary>
        [FhirElement("bottomOfFirstInterval", Order=120)]
        [DataMember]
        public Quantity BottomOfFirstInterval
        {
            get { return _BottomOfFirstInterval; }
            set { _BottomOfFirstInterval = value; OnPropertyChanged("BottomOfFirstInterval"); }
        }
        
        private Quantity _BottomOfFirstInterval;
        
        /// <summary>
        /// Interval
        /// </summary>
        [FhirElement("interval", InSummary=true, Order=130)]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.OrderedDistribution.IntervalComponent> Interval
        {
            get { if(_Interval==null) _Interval = new List<Hl7.Fhir.Model.OrderedDistribution.IntervalComponent>(); return _Interval; }
            set { _Interval = value; OnPropertyChanged("Interval"); }
        }
        
        private List<Hl7.Fhir.Model.OrderedDistribution.IntervalComponent> _Interval;
        
        /// <summary>
        /// Singular value of the statistic at the upper bound of the interval
        /// </summary>
        [FhirElement("topOfInterval", Order=140)]
        [DataMember]
        public Quantity TopOfInterval
        {
            get { return _TopOfInterval; }
            set { _TopOfInterval = value; OnPropertyChanged("TopOfInterval"); }
        }
        
        private Quantity _TopOfInterval;
        

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as OrderedDistribution;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.FhirString)DescriptionElement.DeepCopy();
                if(Note != null) dest.Note = new List<Hl7.Fhir.Model.Annotation>(Note.DeepCopy());
                if(NumberOfIntervalsElement != null) dest.NumberOfIntervalsElement = (Hl7.Fhir.Model.Integer)NumberOfIntervalsElement.DeepCopy();
                if(BottomOfFirstInterval != null) dest.BottomOfFirstInterval = (Quantity)BottomOfFirstInterval.DeepCopy();
                if(Interval != null) dest.Interval = new List<Hl7.Fhir.Model.OrderedDistribution.IntervalComponent>(Interval.DeepCopy());
                if(TopOfInterval != null) dest.TopOfInterval = (Quantity)TopOfInterval.DeepCopy();
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new OrderedDistribution());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as OrderedDistribution;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if( !DeepComparable.Matches(Note, otherT.Note)) return false;
            if( !DeepComparable.Matches(NumberOfIntervalsElement, otherT.NumberOfIntervalsElement)) return false;
            if( !DeepComparable.Matches(BottomOfFirstInterval, otherT.BottomOfFirstInterval)) return false;
            if( !DeepComparable.Matches(Interval, otherT.Interval)) return false;
            if( !DeepComparable.Matches(TopOfInterval, otherT.TopOfInterval)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as OrderedDistribution;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if( !DeepComparable.IsExactly(Note, otherT.Note)) return false;
            if( !DeepComparable.IsExactly(NumberOfIntervalsElement, otherT.NumberOfIntervalsElement)) return false;
            if( !DeepComparable.IsExactly(BottomOfFirstInterval, otherT.BottomOfFirstInterval)) return false;
            if( !DeepComparable.IsExactly(Interval, otherT.Interval)) return false;
            if( !DeepComparable.IsExactly(TopOfInterval, otherT.TopOfInterval)) return false;
            
            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (DescriptionElement != null) yield return DescriptionElement;
                foreach (var elem in Note) { if (elem != null) yield return elem; }
                if (NumberOfIntervalsElement != null) yield return NumberOfIntervalsElement;
                if (BottomOfFirstInterval != null) yield return BottomOfFirstInterval;
                foreach (var elem in Interval) { if (elem != null) yield return elem; }
                if (TopOfInterval != null) yield return TopOfInterval;
            }
        }

        [NotMapped]
        public override IEnumerable<ElementValue> NamedChildren 
        { 
            get 
            { 
                foreach (var item in base.NamedChildren) yield return item; 
                if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
                if (NumberOfIntervalsElement != null) yield return new ElementValue("numberOfIntervals", NumberOfIntervalsElement);
                if (BottomOfFirstInterval != null) yield return new ElementValue("bottomOfFirstInterval", BottomOfFirstInterval);
                foreach (var elem in Interval) { if (elem != null) yield return new ElementValue("interval", elem); }
                if (TopOfInterval != null) yield return new ElementValue("topOfInterval", TopOfInterval);
 
            } 
        } 
    
    
    }
    
}
