﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VindiSharp.Core.Exceptions
{
    public class VindiInvalidParametersException : Exception
    {

        public List<VindiError> Errors { get; set; }

        public VindiInvalidParametersException(List<VindiError> errors, String Message) : base(Message)
        {
            this.Errors = errors;
        }

    }
}
