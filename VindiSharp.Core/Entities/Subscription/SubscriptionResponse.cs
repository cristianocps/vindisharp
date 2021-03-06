﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VindiSharp.Core.Entities
{
    public class SubscriptionResponse
    {
        [JsonProperty("subscription")]
        public Subscription Subscription { get; set; }

        [JsonProperty("bill")]
        public Bill Bill { get; set; }
    }
}
