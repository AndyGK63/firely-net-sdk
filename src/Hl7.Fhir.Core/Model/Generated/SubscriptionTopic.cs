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
    /// Definition Pattern
    /// </summary>
    [FhirType("SubscriptionTopic", IsResource=true)]
    [DataContract]
    public partial class SubscriptionTopic : Hl7.Fhir.Model.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.SubscriptionTopic; } }
        [NotMapped]
        public override string TypeName { get { return "SubscriptionTopic"; } }
        
        /// <summary>
        /// FHIR RESTful interaction codes used for SubscriptionTopic trigger.
        /// (url: http://hl7.org/fhir/ValueSet/interaction-trigger)
        /// </summary>
        [FhirEnumeration("InteractionTrigger")]
        public enum InteractionTrigger
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/restful-interaction)
            /// </summary>
            [EnumLiteral("create", "http://hl7.org/fhir/restful-interaction"), Description("create")]
            Create,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/restful-interaction)
            /// </summary>
            [EnumLiteral("update", "http://hl7.org/fhir/restful-interaction"), Description("update")]
            Update,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/restful-interaction)
            /// </summary>
            [EnumLiteral("delete", "http://hl7.org/fhir/restful-interaction"), Description("delete")]
            Delete,
        }

        [FhirType("ResourceTriggerComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class ResourceTriggerComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ResourceTriggerComponent"; } }
            
            /// <summary>
            /// Text representation of the trigger
            /// </summary>
            [FhirElement("description", InSummary=true, Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString DescriptionElement
            {
                get { return _DescriptionElement; }
                set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _DescriptionElement;
            
            /// <summary>
            /// Text representation of the trigger
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
            /// Candidate types for this subscription topic
            /// </summary>
            [FhirElement("resourceType", InSummary=true, Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Code<Hl7.Fhir.Model.ResourceType>> ResourceTypeElement
            {
                get { if(_ResourceTypeElement==null) _ResourceTypeElement = new List<Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResourceType>>(); return _ResourceTypeElement; }
                set { _ResourceTypeElement = value; OnPropertyChanged("ResourceTypeElement"); }
            }
            
            private List<Code<Hl7.Fhir.Model.ResourceType>> _ResourceTypeElement;
            
            /// <summary>
            /// Candidate types for this subscription topic
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<Hl7.Fhir.Model.ResourceType?> ResourceType
            {
                get { return ResourceTypeElement != null ? ResourceTypeElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        ResourceTypeElement = null; 
                    else
                        ResourceTypeElement = new List<Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResourceType>>(value.Select(elem=>new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ResourceType>(elem)));
                    OnPropertyChanged("ResourceType");
                }
            }
            
            /// <summary>
            /// create | update | delete
            /// </summary>
            [FhirElement("methodCriteria", InSummary=true, Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Code<Hl7.Fhir.Model.SubscriptionTopic.InteractionTrigger>> MethodCriteriaElement
            {
                get { if(_MethodCriteriaElement==null) _MethodCriteriaElement = new List<Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SubscriptionTopic.InteractionTrigger>>(); return _MethodCriteriaElement; }
                set { _MethodCriteriaElement = value; OnPropertyChanged("MethodCriteriaElement"); }
            }
            
            private List<Code<Hl7.Fhir.Model.SubscriptionTopic.InteractionTrigger>> _MethodCriteriaElement;
            
            /// <summary>
            /// create | update | delete
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<Hl7.Fhir.Model.SubscriptionTopic.InteractionTrigger?> MethodCriteria
            {
                get { return MethodCriteriaElement != null ? MethodCriteriaElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        MethodCriteriaElement = null; 
                    else
                        MethodCriteriaElement = new List<Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SubscriptionTopic.InteractionTrigger>>(value.Select(elem=>new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SubscriptionTopic.InteractionTrigger>(elem)));
                    OnPropertyChanged("MethodCriteria");
                }
            }
            
            /// <summary>
            /// Query based trigger rule
            /// </summary>
            [FhirElement("queryCriteria", InSummary=true, Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.SubscriptionTopic.QueryCriteriaComponent QueryCriteria
            {
                get { return _QueryCriteria; }
                set { _QueryCriteria = value; OnPropertyChanged("QueryCriteria"); }
            }
            
            private Hl7.Fhir.Model.SubscriptionTopic.QueryCriteriaComponent _QueryCriteria;
            
            /// <summary>
            /// FHIRPath based trigger rule
            /// </summary>
            [FhirElement("fhirPathCriteria", InSummary=true, Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.FhirString> FhirPathCriteriaElement
            {
                get { if(_FhirPathCriteriaElement==null) _FhirPathCriteriaElement = new List<Hl7.Fhir.Model.FhirString>(); return _FhirPathCriteriaElement; }
                set { _FhirPathCriteriaElement = value; OnPropertyChanged("FhirPathCriteriaElement"); }
            }
            
            private List<Hl7.Fhir.Model.FhirString> _FhirPathCriteriaElement;
            
            /// <summary>
            /// FHIRPath based trigger rule
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<string> FhirPathCriteria
            {
                get { return FhirPathCriteriaElement != null ? FhirPathCriteriaElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        FhirPathCriteriaElement = null; 
                    else
                        FhirPathCriteriaElement = new List<Hl7.Fhir.Model.FhirString>(value.Select(elem=>new Hl7.Fhir.Model.FhirString(elem)));
                    OnPropertyChanged("FhirPathCriteria");
                }
            }
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ResourceTriggerComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.FhirString)DescriptionElement.DeepCopy();
                    if(ResourceTypeElement != null) dest.ResourceTypeElement = new List<Code<Hl7.Fhir.Model.ResourceType>>(ResourceTypeElement.DeepCopy());
                    if(MethodCriteriaElement != null) dest.MethodCriteriaElement = new List<Code<Hl7.Fhir.Model.SubscriptionTopic.InteractionTrigger>>(MethodCriteriaElement.DeepCopy());
                    if(QueryCriteria != null) dest.QueryCriteria = (Hl7.Fhir.Model.SubscriptionTopic.QueryCriteriaComponent)QueryCriteria.DeepCopy();
                    if(FhirPathCriteriaElement != null) dest.FhirPathCriteriaElement = new List<Hl7.Fhir.Model.FhirString>(FhirPathCriteriaElement.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ResourceTriggerComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ResourceTriggerComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if( !DeepComparable.Matches(ResourceTypeElement, otherT.ResourceTypeElement)) return false;
                if( !DeepComparable.Matches(MethodCriteriaElement, otherT.MethodCriteriaElement)) return false;
                if( !DeepComparable.Matches(QueryCriteria, otherT.QueryCriteria)) return false;
                if( !DeepComparable.Matches(FhirPathCriteriaElement, otherT.FhirPathCriteriaElement)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ResourceTriggerComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if( !DeepComparable.IsExactly(ResourceTypeElement, otherT.ResourceTypeElement)) return false;
                if( !DeepComparable.IsExactly(MethodCriteriaElement, otherT.MethodCriteriaElement)) return false;
                if( !DeepComparable.IsExactly(QueryCriteria, otherT.QueryCriteria)) return false;
                if( !DeepComparable.IsExactly(FhirPathCriteriaElement, otherT.FhirPathCriteriaElement)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    foreach (var elem in ResourceTypeElement) { if (elem != null) yield return elem; }
                    foreach (var elem in MethodCriteriaElement) { if (elem != null) yield return elem; }
                    if (QueryCriteria != null) yield return QueryCriteria;
                    foreach (var elem in FhirPathCriteriaElement) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    foreach (var elem in ResourceTypeElement) { if (elem != null) yield return new ElementValue("resourceType", elem); }
                    foreach (var elem in MethodCriteriaElement) { if (elem != null) yield return new ElementValue("methodCriteria", elem); }
                    if (QueryCriteria != null) yield return new ElementValue("queryCriteria", QueryCriteria);
                    foreach (var elem in FhirPathCriteriaElement) { if (elem != null) yield return new ElementValue("fhirPathCriteria", elem); }
                }
            }

            
        }
        
        
        [FhirType("QueryCriteriaComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class QueryCriteriaComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "QueryCriteriaComponent"; } }
            
            /// <summary>
            /// Rule applied to previous resource state
            /// </summary>
            [FhirElement("previous", InSummary=true, Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString PreviousElement
            {
                get { return _PreviousElement; }
                set { _PreviousElement = value; OnPropertyChanged("PreviousElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _PreviousElement;
            
            /// <summary>
            /// Rule applied to previous resource state
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Previous
            {
                get { return PreviousElement != null ? PreviousElement.Value : null; }
                set
                {
                    if (value == null)
                        PreviousElement = null; 
                    else
                        PreviousElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Previous");
                }
            }
            
            /// <summary>
            /// Rule applied to current resource state
            /// </summary>
            [FhirElement("current", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString CurrentElement
            {
                get { return _CurrentElement; }
                set { _CurrentElement = value; OnPropertyChanged("CurrentElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _CurrentElement;
            
            /// <summary>
            /// Rule applied to current resource state
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Current
            {
                get { return CurrentElement != null ? CurrentElement.Value : null; }
                set
                {
                    if (value == null)
                        CurrentElement = null; 
                    else
                        CurrentElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Current");
                }
            }
            
            /// <summary>
            /// Both must be true flag
            /// </summary>
            [FhirElement("requireBoth", InSummary=true, Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.FhirBoolean RequireBothElement
            {
                get { return _RequireBothElement; }
                set { _RequireBothElement = value; OnPropertyChanged("RequireBothElement"); }
            }
            
            private Hl7.Fhir.Model.FhirBoolean _RequireBothElement;
            
            /// <summary>
            /// Both must be true flag
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public bool? RequireBoth
            {
                get { return RequireBothElement != null ? RequireBothElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        RequireBothElement = null; 
                    else
                        RequireBothElement = new Hl7.Fhir.Model.FhirBoolean(value);
                    OnPropertyChanged("RequireBoth");
                }
            }
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as QueryCriteriaComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(PreviousElement != null) dest.PreviousElement = (Hl7.Fhir.Model.FhirString)PreviousElement.DeepCopy();
                    if(CurrentElement != null) dest.CurrentElement = (Hl7.Fhir.Model.FhirString)CurrentElement.DeepCopy();
                    if(RequireBothElement != null) dest.RequireBothElement = (Hl7.Fhir.Model.FhirBoolean)RequireBothElement.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new QueryCriteriaComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as QueryCriteriaComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(PreviousElement, otherT.PreviousElement)) return false;
                if( !DeepComparable.Matches(CurrentElement, otherT.CurrentElement)) return false;
                if( !DeepComparable.Matches(RequireBothElement, otherT.RequireBothElement)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as QueryCriteriaComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(PreviousElement, otherT.PreviousElement)) return false;
                if( !DeepComparable.IsExactly(CurrentElement, otherT.CurrentElement)) return false;
                if( !DeepComparable.IsExactly(RequireBothElement, otherT.RequireBothElement)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (PreviousElement != null) yield return PreviousElement;
                    if (CurrentElement != null) yield return CurrentElement;
                    if (RequireBothElement != null) yield return RequireBothElement;
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (PreviousElement != null) yield return new ElementValue("previous", PreviousElement);
                    if (CurrentElement != null) yield return new ElementValue("current", CurrentElement);
                    if (RequireBothElement != null) yield return new ElementValue("requireBoth", RequireBothElement);
                }
            }

            
        }
        
        
        [FhirType("CanFilterByComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class CanFilterByComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "CanFilterByComponent"; } }
            
            /// <summary>
            /// Search parameter that serves as filter key
            /// </summary>
            [FhirElement("searchParamName", InSummary=true, Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString SearchParamNameElement
            {
                get { return _SearchParamNameElement; }
                set { _SearchParamNameElement = value; OnPropertyChanged("SearchParamNameElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _SearchParamNameElement;
            
            /// <summary>
            /// Search parameter that serves as filter key
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string SearchParamName
            {
                get { return SearchParamNameElement != null ? SearchParamNameElement.Value : null; }
                set
                {
                    if (value == null)
                        SearchParamNameElement = null; 
                    else
                        SearchParamNameElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("SearchParamName");
                }
            }
            
            /// <summary>
            /// = | eq | ne | gt | lt | ge | le | sa | eb | ap | above | below | in | not-in | of-type
            /// </summary>
            [FhirElement("searchModifier", InSummary=true, Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Code<Hl7.Fhir.Model.SubscriptionSearchModifier>> SearchModifierElement
            {
                get { if(_SearchModifierElement==null) _SearchModifierElement = new List<Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SubscriptionSearchModifier>>(); return _SearchModifierElement; }
                set { _SearchModifierElement = value; OnPropertyChanged("SearchModifierElement"); }
            }
            
            private List<Code<Hl7.Fhir.Model.SubscriptionSearchModifier>> _SearchModifierElement;
            
            /// <summary>
            /// = | eq | ne | gt | lt | ge | le | sa | eb | ap | above | below | in | not-in | of-type
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<Hl7.Fhir.Model.SubscriptionSearchModifier?> SearchModifier
            {
                get { return SearchModifierElement != null ? SearchModifierElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        SearchModifierElement = null; 
                    else
                        SearchModifierElement = new List<Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SubscriptionSearchModifier>>(value.Select(elem=>new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.SubscriptionSearchModifier>(elem)));
                    OnPropertyChanged("SearchModifier");
                }
            }
            
            /// <summary>
            /// Description of this filter parameter
            /// </summary>
            [FhirElement("documentation", InSummary=true, Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.Markdown Documentation
            {
                get { return _Documentation; }
                set { _Documentation = value; OnPropertyChanged("Documentation"); }
            }
            
            private Hl7.Fhir.Model.Markdown _Documentation;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CanFilterByComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(SearchParamNameElement != null) dest.SearchParamNameElement = (Hl7.Fhir.Model.FhirString)SearchParamNameElement.DeepCopy();
                    if(SearchModifierElement != null) dest.SearchModifierElement = new List<Code<Hl7.Fhir.Model.SubscriptionSearchModifier>>(SearchModifierElement.DeepCopy());
                    if(Documentation != null) dest.Documentation = (Hl7.Fhir.Model.Markdown)Documentation.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new CanFilterByComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as CanFilterByComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(SearchParamNameElement, otherT.SearchParamNameElement)) return false;
                if( !DeepComparable.Matches(SearchModifierElement, otherT.SearchModifierElement)) return false;
                if( !DeepComparable.Matches(Documentation, otherT.Documentation)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CanFilterByComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(SearchParamNameElement, otherT.SearchParamNameElement)) return false;
                if( !DeepComparable.IsExactly(SearchModifierElement, otherT.SearchModifierElement)) return false;
                if( !DeepComparable.IsExactly(Documentation, otherT.Documentation)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (SearchParamNameElement != null) yield return SearchParamNameElement;
                    foreach (var elem in SearchModifierElement) { if (elem != null) yield return elem; }
                    if (Documentation != null) yield return Documentation;
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (SearchParamNameElement != null) yield return new ElementValue("searchParamName", SearchParamNameElement);
                    foreach (var elem in SearchModifierElement) { if (elem != null) yield return new ElementValue("searchModifier", elem); }
                    if (Documentation != null) yield return new ElementValue("documentation", Documentation);
                }
            }

            
        }
        
        
        /// <summary>
        /// Logical canonical URL to reference this SubscriptionTopic (globally unique)
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
        /// Logical canonical URL to reference this SubscriptionTopic (globally unique)
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
        /// Business Identifier for SubscriptionTopic
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
        /// Business version of the SubscriptionTopic
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
        /// Business version of the SubscriptionTopic
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
        /// Name for this SubscriptionTopic (Human friendly)
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
        /// Name for this SubscriptionTopic (Human friendly)
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
        /// Based on FHIR protocol or definition
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
        /// Based on FHIR protocol or definition
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
        /// Based on external protocol or definition
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
        /// Based on external protocol or definition
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
        /// Date status first applied
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
        /// The name of the individual or organization that published the SubscriptionTopic
        /// </summary>
        [FhirElement("publisher", InSummary=true, Order=180)]
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
        /// Natural language description of the ToSubscriptionTopicpic
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
        /// Content intends to support these contexts
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
        /// Intended jurisdiction for Topic (if applicable)
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
        /// Why this SubscriptionTopic is defined
        /// </summary>
        [FhirElement("purpose", Order=230)]
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
        [FhirElement("copyright", Order=240)]
        [DataMember]
        public Hl7.Fhir.Model.Markdown Copyright
        {
            get { return _Copyright; }
            set { _Copyright = value; OnPropertyChanged("Copyright"); }
        }
        
        private Hl7.Fhir.Model.Markdown _Copyright;
        
        /// <summary>
        /// When SubscriptionTopic is/was approved by publisher
        /// </summary>
        [FhirElement("approvalDate", Order=250)]
        [DataMember]
        public Hl7.Fhir.Model.Date ApprovalDateElement
        {
            get { return _ApprovalDateElement; }
            set { _ApprovalDateElement = value; OnPropertyChanged("ApprovalDateElement"); }
        }
        
        private Hl7.Fhir.Model.Date _ApprovalDateElement;
        
        /// <summary>
        /// When SubscriptionTopic is/was approved by publisher
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
        /// Last review date for the SubscriptionTopic
        /// </summary>
        [FhirElement("lastReviewDate", Order=260)]
        [DataMember]
        public Hl7.Fhir.Model.Date LastReviewDateElement
        {
            get { return _LastReviewDateElement; }
            set { _LastReviewDateElement = value; OnPropertyChanged("LastReviewDateElement"); }
        }
        
        private Hl7.Fhir.Model.Date _LastReviewDateElement;
        
        /// <summary>
        /// Last review date for the SubscriptionTopic
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
        /// The effective date range for the SubscriptionTopic
        /// </summary>
        [FhirElement("effectivePeriod", InSummary=true, Order=270)]
        [DataMember]
        public Hl7.Fhir.Model.Period EffectivePeriod
        {
            get { return _EffectivePeriod; }
            set { _EffectivePeriod = value; OnPropertyChanged("EffectivePeriod"); }
        }
        
        private Hl7.Fhir.Model.Period _EffectivePeriod;
        
        /// <summary>
        /// Criteria for including a resource update in the subscription topic
        /// </summary>
        [FhirElement("resourceTrigger", InSummary=true, Order=280)]
        [DataMember]
        public Hl7.Fhir.Model.SubscriptionTopic.ResourceTriggerComponent ResourceTrigger
        {
            get { return _ResourceTrigger; }
            set { _ResourceTrigger = value; OnPropertyChanged("ResourceTrigger"); }
        }
        
        private Hl7.Fhir.Model.SubscriptionTopic.ResourceTriggerComponent _ResourceTrigger;
        
        /// <summary>
        /// Properties by which a Subscription can further filter a SubscriptionTopic
        /// </summary>
        [FhirElement("canFilterBy", InSummary=true, Order=290)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.SubscriptionTopic.CanFilterByComponent> CanFilterBy
        {
            get { if(_CanFilterBy==null) _CanFilterBy = new List<Hl7.Fhir.Model.SubscriptionTopic.CanFilterByComponent>(); return _CanFilterBy; }
            set { _CanFilterBy = value; OnPropertyChanged("CanFilterBy"); }
        }
        
        private List<Hl7.Fhir.Model.SubscriptionTopic.CanFilterByComponent> _CanFilterBy;
        

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as SubscriptionTopic;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(UrlElement != null) dest.UrlElement = (Hl7.Fhir.Model.FhirUri)UrlElement.DeepCopy();
                if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
                if(VersionElement != null) dest.VersionElement = (Hl7.Fhir.Model.FhirString)VersionElement.DeepCopy();
                if(TitleElement != null) dest.TitleElement = (Hl7.Fhir.Model.FhirString)TitleElement.DeepCopy();
                if(DerivedFromCanonicalElement != null) dest.DerivedFromCanonicalElement = new List<Hl7.Fhir.Model.Canonical>(DerivedFromCanonicalElement.DeepCopy());
                if(DerivedFromUriElement != null) dest.DerivedFromUriElement = new List<Hl7.Fhir.Model.FhirUri>(DerivedFromUriElement.DeepCopy());
                if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.PublicationStatus>)StatusElement.DeepCopy();
                if(ExperimentalElement != null) dest.ExperimentalElement = (Hl7.Fhir.Model.FhirBoolean)ExperimentalElement.DeepCopy();
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
                if(ResourceTrigger != null) dest.ResourceTrigger = (Hl7.Fhir.Model.SubscriptionTopic.ResourceTriggerComponent)ResourceTrigger.DeepCopy();
                if(CanFilterBy != null) dest.CanFilterBy = new List<Hl7.Fhir.Model.SubscriptionTopic.CanFilterByComponent>(CanFilterBy.DeepCopy());
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new SubscriptionTopic());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as SubscriptionTopic;
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
            if( !DeepComparable.Matches(ResourceTrigger, otherT.ResourceTrigger)) return false;
            if( !DeepComparable.Matches(CanFilterBy, otherT.CanFilterBy)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as SubscriptionTopic;
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
            if( !DeepComparable.IsExactly(ResourceTrigger, otherT.ResourceTrigger)) return false;
            if( !DeepComparable.IsExactly(CanFilterBy, otherT.CanFilterBy)) return false;
            
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
				foreach (var elem in DerivedFromCanonicalElement) { if (elem != null) yield return elem; }
				foreach (var elem in DerivedFromUriElement) { if (elem != null) yield return elem; }
				if (StatusElement != null) yield return StatusElement;
				if (ExperimentalElement != null) yield return ExperimentalElement;
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
				if (ResourceTrigger != null) yield return ResourceTrigger;
				foreach (var elem in CanFilterBy) { if (elem != null) yield return elem; }
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
                foreach (var elem in DerivedFromCanonicalElement) { if (elem != null) yield return new ElementValue("derivedFromCanonical", elem); }
                foreach (var elem in DerivedFromUriElement) { if (elem != null) yield return new ElementValue("derivedFromUri", elem); }
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (ExperimentalElement != null) yield return new ElementValue("experimental", ExperimentalElement);
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
                if (ResourceTrigger != null) yield return new ElementValue("resourceTrigger", ResourceTrigger);
                foreach (var elem in CanFilterBy) { if (elem != null) yield return new ElementValue("canFilterBy", elem); }
            }
        }

    }
    
}
