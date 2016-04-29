using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VindiSharp.Core.Exceptions
{
    public class VindiInvalidParametersException : Exception
    {

        public List<VindiError> Errors { get; set; }

        public VindiInvalidParametersException(List<VindiError> errors, String message) : base(message)
        {

            this.Errors = errors;
        }

    }
}
