using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VindiSharp.Core.Exceptions
{
    [Serializable]
    public class VindiError
    {
        [JsonProperty("id")]
        public string Id
        {
            get;
            set;
        }
        [JsonProperty("message")]
        public string Message
        {
            get;
            set;
        }
    }
}
