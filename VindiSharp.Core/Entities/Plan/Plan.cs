using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using VindiSharp.Core.Enums;
using Newtonsoft.Json.Converters;

namespace VindiSharp.Core.Entities
{
    public class Plan
    {
        [JsonProperty("interval")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PlanInterval Interval
        {
            get;
            set;
        }

        [JsonProperty("interval_count")]
        public int IntervalCount
        {
            get;
            set;
        }
        [JsonProperty("billing_cycles")]
        public int? BillingCycles
        {
            get;
            set;
        }
        [JsonProperty("interval_name")]
        public String IntervalName
        {
            get;
            set;
        }

        [JsonProperty("billing_trigger_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public BillingTriggerType BillingTriggerType
        {
            get;
            set;
        }
        [JsonProperty("billing_trigger_day")]
        public int BillingTriggerDay
        {
            get;
            set;
        }
    }
}
