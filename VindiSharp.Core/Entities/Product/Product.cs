using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VindiSharp.Core.Interfaces;

namespace VindiSharp.Core.Entities
{
    [VindiNode(MultiResultsNodeName ="products", SingleResultNodeName ="product")]
    public class Product : IVindiEntity
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter), new object[] { true })]
        public ProductStatus Status { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("invoice")]
        public string Invoice { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        [JsonProperty("pricing_schema")]
        public PricingSchema PricingSchema { get; set; }

        public const string RESOURCE_NAME = "products";
        public string ResourceName
        {
            get
            {
                return RESOURCE_NAME;
            }
        }
    }

}
