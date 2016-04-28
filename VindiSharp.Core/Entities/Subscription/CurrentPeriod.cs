using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VindiSharp.Core.Entities
{
    public class Period
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("billing_at")]
        public DateTimeOffset? BillingAt { get; set; }

        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("start_at")]
        public DateTimeOffset? StartAt { get; set; }

        [JsonProperty("end_at")]
        public DateTimeOffset? EndAt { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }
}
