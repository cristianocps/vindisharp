using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VindiSharp.Core.Entities
{
    public class EventRequest
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Int64 Type
        {
            get;
            set;

        }
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset created_at
        {
            get;
            set;
        }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public DataRequest Data
        {
            get;
            set;
        }

    }
}
