﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VindiSharp.Core.Exceptions
{
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
