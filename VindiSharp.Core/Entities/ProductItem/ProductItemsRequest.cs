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
    [VindiNode(MultiResultsNodeName = "product_items", SingleResultNodeName = "product_item")]
    public class ProductItemsRequest : IVindiEntity
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("product_id")]
        public int ProductId { get; set; }

        [JsonProperty("subscription_id")]
        public int SubscriptionId { get; set; }

        [JsonProperty("cycles")]
        public int? Cycles { get; set; }

        [JsonProperty("quantity")]
        public int? Quantity { get; set; }

        [JsonProperty("pricing_schema")]
        public PricingSchema PricingSchema { get; set; }

        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter), new object[] { true })]
        public ProductItemStatus Status { get; set; }


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
