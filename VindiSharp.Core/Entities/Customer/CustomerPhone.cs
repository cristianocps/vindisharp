using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VindiSharp.Core.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace VindiSharp.Core.Entities
{
    public class CustomerPhone
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Int64? Id
        {
            get;
            set;
        }
        [JsonProperty("phone_type")]
        [JsonConverter(typeof(StringEnumConverter), new object[] { true })]
        public PhoneType PhoneType
        {
            get;
            set;
        }
        [JsonProperty("number")]
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

    }
}
