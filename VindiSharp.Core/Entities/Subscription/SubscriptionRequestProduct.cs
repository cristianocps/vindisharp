using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VindiSharp.Core.Entities
{
    public class SubscriptionRequestProductItem
    {

        [JsonProperty("product_id")]
        public long ProductId { get; set; }

        [JsonProperty("cycles")]
        public int? Cycles { get; set; }

        [JsonProperty("quantity")]
        public int? Quantity { get; set; }

        [JsonProperty("pricing_schema")]
        public PricingSchema PricingSchema { get; set; }

        [JsonProperty("discounts")]
        public List<Discount> Discounts { get; set; }
    }

}
