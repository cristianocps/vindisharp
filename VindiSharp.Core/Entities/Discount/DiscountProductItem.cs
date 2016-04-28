using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VindiSharp.Core.Entities
{
    public class DiscountProductItem
    {

        [JsonProperty("id")]
        public int Id
        {
            get;
            set;
        }

        [JsonProperty("product")]
        public Product Product
        {
            get;
            set;
        }
    }
}
