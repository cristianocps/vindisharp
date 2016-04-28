using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VindiSharp.Core.Entities
{
    public class PricingRanx
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("start_quantity")]
        public int StartQuantity { get; set; }

        [JsonProperty("end_quantity")]
        public int EndQuantity { get; set; }

        [JsonProperty("price")]
        public decimal Price { get; set; }

        [JsonProperty("overage_price")]
        public decimal OveragePrice { get; set; }
    }
}
