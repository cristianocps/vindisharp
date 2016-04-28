using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VindiSharp.Core.Enums;

namespace VindiSharp.Core.Entities
{
    public class DiscountSummary
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("discount_type")]
        public DiscountType DiscountType { get; set; }

        [JsonProperty("percentage")]
        public decimal Percentage { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("cycles")]
        public int Cycles { get; set; }
    }
}
