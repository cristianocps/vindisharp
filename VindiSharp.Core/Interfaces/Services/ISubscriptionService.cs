using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VindiSharp.Core.Entities;

namespace VindiSharp.Core.Interfaces
{
    public interface ISubscriptionService :
        IDeleteService<Subscription>,

        ISearchService<Subscription>

    {
        Subscription Reactivate(long Id);
        SubscriptionResponse Create(SubscriptionRequest newSubscription);
        SubscriptionResponse Update(SubscriptionRequest currentSubscription);
    }
}
