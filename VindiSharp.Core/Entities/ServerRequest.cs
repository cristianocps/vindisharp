using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VindiSharp.Core.Entities
{    
    public class ServerRequest
    {
        [JsonProperty("event", NullValueHandling = NullValueHandling.Ignore)]
        public EventRequest Event
        {
            get;
            set;

        }        

    }
}
