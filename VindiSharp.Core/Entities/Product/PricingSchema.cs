using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VindiSharp.Core.Enums;
namespace VindiSharp.Core.Entities
{
    public class PricingSchema
    {

        [JsonProperty("id")]
        public string Id
        {
            get;
            set;
        }

        [JsonProperty("short_format")]
        public string ShortFormat
        {
            get;
            set;
        }

        [JsonProperty("price")]
        public decimal Price
        {
            get;
            set;
        }

        [JsonProperty("minimum_price")]
        public decimal? MinimumPrice
        {
            get;
            set;
        }

        [JsonProperty("schema_type")]
        public PricingSchemaType SchemaType
        {
            get;
            set;
        }

        [JsonProperty("pricing_ranges")]
        public List<PricingRanx> PricingRanges
        {
            get;
            set;
        }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt
        {
            get;
            set;
        }
    }
}
