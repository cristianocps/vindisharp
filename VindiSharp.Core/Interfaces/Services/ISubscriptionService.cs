using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VindiSharp.Core.Entities;

namespace VindiSharp.Core.Interfaces
{
    public interface ISubscriptionService :
        IDeleteService<Subscription>,
        IInsertService<Subscription>,
        ISearchService<Subscription>

    {
        void Reactivate(long Id);
    }
}
