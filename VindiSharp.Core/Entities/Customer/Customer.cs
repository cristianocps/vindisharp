using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VindiSharp.Core.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using VindiSharp.Core.Interfaces;

namespace VindiSharp.Core.Entities
{
    [VindiNodeAttribute(SingleResultNodeName = "customer", MultiResultsNodeName = "customers")]
    public class Customer : IVindiEntity
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Int64 Id
        {
            get;
            set;

        }
        [JsonProperty("name")]
        public String Name
        {
            get;
            set;
        }
        [JsonProperty("email")]
        public String Email
        {
            get;
            set;
        }
        [JsonProperty("registry_code")]
        public String RegistryCode
        {
            get;
            set;
        }
        [JsonProperty("code")]
        public String Code
        {
            get;
            set;
        }
        [JsonProperty("notes")]
        public String Notes
        {
            get;
            set;
        }
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CustomerStatus Status
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
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt
        {
            get;
            set;
        }
        [JsonProperty("address")]
        public List<CustomerAddress> Address
        {
            get;
            set;
        }
        [JsonProperty("phones")]
        public List<CustomerPhone> Phones
        {
            get;
            set;
        }
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata
        {
            get;
            set;
        }
        public const string RESOURCE_NAME = "customers";

        public string ResourceName
        {
            get
            {
                return RESOURCE_NAME;
            }
        }
    }
}
