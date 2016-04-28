using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.ComponentModel;

namespace VindiSharp.Core.Enums
{
    public enum PhoneType
    {
        [Description("mobile")]
        Mobile,

        [Description("landline")]
        Landline
    }
}
