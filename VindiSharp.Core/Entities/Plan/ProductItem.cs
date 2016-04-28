using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VindiSharp.Core.Entities
{
    public class ProductItem
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("cycles")]
        public int Cycles { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        [JsonProperty("product")]
        public ProductSummary Product { get; set; }

        [JsonProperty("pricing_schema")]
        public PricingSchema PricingSchema { get; set; }

        [JsonProperty("discounts")]
        public List<Discount> Discounts { get; set; }
    }
}
