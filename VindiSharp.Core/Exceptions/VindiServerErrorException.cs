using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VindiSharp.Core.Exceptions
{
    public class VindiServerErrorException : Exception
    {
        public VindiServerErrorException(String Message) : base(Message)
        {

        }
    }
}
