using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VindiSharp.Core.Enums
{
    public enum TransactionType
    {
        Charge,
        Refund,
        Authorize,
        Capture,
        Verify,
        Register
    }
}
