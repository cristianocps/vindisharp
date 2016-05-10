using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VindiSharp.Core.Interfaces;

namespace VindiSharp.Core.Entities
{
    [VindiNode(MultiResultsNodeName = "product_items", SingleResultNodeName = "product_item")]
    public class ProductItemsResponse : IVindiEntity
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter), new object[] { true })]
        public ProductItemStatus Status { get; set; }

        [JsonProperty("cycles")]
        public int Cycles { get; set; }

        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public int Quantity { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("product")]
        public Product Product { get; set; }

        [JsonProperty("pricing_schema")]
        public PricingSchema PricingSchema { get; set; }

        [JsonProperty("discounts")]
        public IList<Discount> Discounts { get; set; }

        public const string RESOURCE_NAME = "product_items";
        public string ResourceName
        {
            get
            {
                return RESOURCE_NAME;
            }
        }
    }
}
