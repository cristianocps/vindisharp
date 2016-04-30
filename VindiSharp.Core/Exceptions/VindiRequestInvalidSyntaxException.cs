using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VindiSharp.Core.Exceptions
{
    public class VindiRequestInvalidSyntaxException : Exception
    {
        public string RequestBody { get; set; }
        public VindiRequestInvalidSyntaxException(String RequestBody, String Message) : base(Message)
        {
            this.RequestBody = RequestBody;
        }
    }
}
