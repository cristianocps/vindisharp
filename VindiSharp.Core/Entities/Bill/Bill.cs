using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VindiSharp.Core.Interfaces;

namespace VindiSharp.Core.Entities
{

    [VindiNode(SingleResultNodeName = "bill", MultiResultsNodeName = "bills")]
    public class Bill : IVindiEntity
    {

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("installments")]
        public int Installments { get; set; }

        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter), new object[] { true })]
        public BillStatus Status { get; set; }

        [JsonProperty("seen_at")]
        public DateTimeOffset? SeenAt { get; set; }

        [JsonProperty("billing_at")]
        public DateTimeOffset? BillingAt { get; set; }

        [JsonProperty("due_at")]
        public DateTimeOffset? DueAt { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        [JsonProperty("bill_items")]
        public List<BillItem> BillItems { get; set; }

        [JsonProperty("charges")]
        public List<ChargeSummary> Charges { get; set; }

        [JsonProperty("customer")]
        public CustomerSummary Customer { get; set; }

        [JsonProperty("period")]
        public PeriodSummary Period { get; set; }

        [JsonProperty("subscription")]
        public SubscriptionSummary Subscription { get; set; }

        public const String RESOURCE_NAME = "bills";

        public string ResourceName
        {
            get
            {
                return RESOURCE_NAME;
            }
        }
    }
}
