using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace VindiSharp.Core
{
    public class QueryParameter
    {
        public String Property { get; set; }
        public QueryOperator Operator { get; set; }

        public object Value { get; set; }

        public QueryParameter(string Property, QueryOperator Operator, object Value)
        {
            this.Property = Property;
            this.Operator = Operator;
            this.Value = Value;
        }
    }

    public enum QueryOperator
    {
        [Description(":")]
        Contains,

        [Description("=")]
        Equals,

        [Description(">")]
        Greater,

        [Description(">=")]
        GreaterOrEquals,

        [Description("<")]
        Less,

        [Description("<=")]
        LessOrEquals,

        [Description("NOT")]
        Not

    }
}
