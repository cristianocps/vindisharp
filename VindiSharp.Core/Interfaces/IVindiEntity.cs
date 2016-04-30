using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VindiSharp.Core.Interfaces
{
    public interface IVindiEntity
    {
        [JsonIgnore]
        String ResourceName { get; }

    }
}
