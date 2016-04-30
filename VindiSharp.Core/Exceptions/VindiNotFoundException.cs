using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VindiSharp.Core.Exceptions
{
    public class VindiNotFoundException : Exception
    {

        public List<VindiError> Errors { get; set; }

        public VindiNotFoundException(List<VindiError> errors, String message) : base(message)
        {

            this.Errors = errors;
        }

    }
}
