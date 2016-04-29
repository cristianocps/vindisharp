using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VindiSharp.Core.Converters;
namespace VindiSharp.Core.Interfaces
{
    public interface IDestroyableEntity
    {
        [JsonProperty("_destroy", NullValueHandling = NullValueHandling.Ignore, ItemConverterType = typeof(NumberBoolConverter))]
        bool? Destroy
        {
            get;
            set;
        }
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        long? Id
        {
            get;
            set;
        }

    }
}
