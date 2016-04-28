using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VindiSharp.Core.Enums;
namespace VindiSharp.Core.Entities
{
    public class Discount
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("discount_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public DiscountType DiscountType { get; set; }

        [JsonProperty("percentage")]
        public int Percentage { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("cycles")]
        public int Cycles { get; set; }

        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public DiscountStatus Status { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        [JsonProperty("product_item")]
        public DiscountProductItem ProductItem { get; set; }
    }
}
