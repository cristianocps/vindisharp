using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VindiSharp.Core.Interfaces;

namespace VindiSharp.Core.Entities
{
    public class PlanItem : IDestroyableEntity
    {

        [JsonProperty("id")]
        public long? Id
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

        [JsonProperty("cycles")]
        public int Cycles
        {
            get;
            set;
        }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt
        {
            get;
            set;
        }

        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt
        {
            get;
            set;
        }

        public bool? Destroy
        {
            get;
            set;
        }
    }
}
