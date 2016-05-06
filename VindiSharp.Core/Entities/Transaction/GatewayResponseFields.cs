using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VindiSharp.Core.Entities
{
    public class GatewayResponseFields
    {

        [JsonProperty("tid")]
        public string TId { get; set; }

        [JsonProperty("pan")]
        public string PAN { get; set; }

        [JsonProperty("arp")]
        public string ARP { get; set; }

        [JsonProperty("nsu")]
        public string NSU { get; set; }

    }
}
