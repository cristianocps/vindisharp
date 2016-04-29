using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using VindiSharp.Core.Enums;
using Newtonsoft.Json.Converters;
using VindiSharp.Core.Interfaces;

namespace VindiSharp.Core.Entities
{
    [JsonObject()]
    [VindiNode(MultiResultsNodeName = "plans", SingleResultNodeName = "plan")]
    public class Plan : IVindiEntity
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("interval")]
        [JsonConverter(typeof(StringEnumConverter), new object[] { true })]
        public PlanInterval Interval { get; set; }

        [JsonProperty("interval_count")]
        public int? IntervalCount { get; set; }

        [JsonProperty("billing_trigger_type")]
        [JsonConverter(typeof(StringEnumConverter), new object[] { true })]
        public BillingTriggerType BillingTriggerType { get; set; }

        [JsonProperty("billing_trigger_day")]
        public int BillingTriggerDay { get; set; }

        [JsonProperty("billing_cycles")]
        public int BillingCycles { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter), new object[] { true })]
        public PlanStatus Status { get; set; }

        [JsonProperty("installments")]
        public int Installments { get; set; }

        [JsonProperty("interval_name")]
        public string IntervalName { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        [JsonProperty("plan_items")]
        public List<PlanItem> PlanItems { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        public const string RESOURCE_NAME = "plans";
        public string ResourceName
        {
            get
            {
                return RESOURCE_NAME;
            }
        }
    }
}
