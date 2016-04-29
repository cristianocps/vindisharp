using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VindiSharp.Core.Entities
{
    public class SubscriptionSummary
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("plan")]
        public PlanSummary Plan { get; set; }

        [JsonProperty("customer")]
        public CustomerSummary Customer
        {
            get;
            set;
        }
    }

}
