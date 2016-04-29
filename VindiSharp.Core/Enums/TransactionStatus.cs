using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VindiSharp.Core.Enums
{
    public enum TransactionStatus
    {
        Processing,
        Success,
        Rejected,
        Failure,
        Timeout,
        Waiting,
        Canceled
    }
}
