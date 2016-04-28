using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VindiSharp.Core.Entities
{
    public class BillItem
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("pricing_range_id")]
        public int PricingRangeId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("pricing_schema")]
        public PricingSchema PricingSchema { get; set; }

        [JsonProperty("product")]
        public ProductSummary Product { get; set; }

        [JsonProperty("product_item")]
        public ProductItem ProductItem { get; set; }

        [JsonProperty("discount")]
        public DiscountSummary Discount { get; set; }
    }

}
