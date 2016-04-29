using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace VindiSharp.Core.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BillingTriggerType
    {
        [EnumMember(Value = "beginning_of_period")]
        BeginningOfPeriod,

        [EnumMember(Value = "end_of_period")]
        EndOfPeriod,

        [EnumMember(Value = "day_of_month")]
        DayOfMonth
    }
}
