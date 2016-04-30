using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VindiSharp.Core
{
    [System.AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class VindiNodeAttribute : Attribute
    {
        public string SingleResultNodeName
        {
            get;
            set;
        }
        public string MultiResultsNodeName
        {
            get;
            set;
        }


    }
}
