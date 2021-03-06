﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
namespace VindiSharp.Core.Entities
{
    public class CustomerAddress
    {
        [JsonProperty("street")]
        public String Street
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

        [JsonProperty("additional_details")]
        public String AdditionalDetails
        {
            get;
            set;
        }
        [JsonProperty("zipcode")]
        public String ZipCode
        {
            get;
            set;
        }

        [JsonProperty("neighborhood")]
        public String Neighborhood
        {
            get;
            set;
        }
        [JsonProperty("city")]
        public String City
        {
            get;
            set;
        }
        [JsonProperty("state")]
        public String State
        {
            get;
            set;
        }
        [JsonProperty("country")]
        public String Country
        {
            get;
            set;
        }

    }
}
