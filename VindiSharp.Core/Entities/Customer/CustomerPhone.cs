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
    public class CustomerPhone : IDestroyableEntity
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Int64? Id
        {
            get;
            set;
        }

        [JsonProperty("phone_type", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public PhoneType? PhoneType
        {
            get;
            set;
        }
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public String Number
        {
            get;
            set;
        }
        [JsonProperty("extension", NullValueHandling = NullValueHandling.Ignore)]
        public String Extension
        {
            get;
            set;
        }

        public bool? Destroy
        {
            get;
            set;

        }
    }
}
