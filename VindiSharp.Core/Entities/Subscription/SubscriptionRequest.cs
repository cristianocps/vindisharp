using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VindiSharp.Core.Enums;
using VindiSharp.Core.Interfaces;

namespace VindiSharp.Core.Entities
{
    public class SubscriptionRequest : IVindiEntity
    {

        [JsonProperty("start_at")]
        public DateTimeOffset? StartAt { get; set; }

        [JsonProperty("plan_id")]
        public long PlanId { get; set; }

        [JsonProperty("customer_id")]
        public long CustomerId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("payment_method_code")]
        public string PaymentMethodCode { get; set; }

        [JsonProperty("billing_trigger_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public BillingTriggerType? BillingTriggerType { get; set; }

        [JsonProperty("billing_trigger_day")]
        public int BillingTriggerDay { get; set; }

        [JsonProperty("billing_cycles")]
        public int BillingCycles { get; set; }

        [JsonProperty("product_items")]
        public List<SubscriptionRequestProductItem> ProductItems { get; set; }


        public const string RESOURCE_NAME = "subscriptions";
        public string ResourceName
        {
            get
            {
                return RESOURCE_NAME;
            }
        }
    }
}
