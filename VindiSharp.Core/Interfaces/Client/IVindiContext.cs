using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VindiSharp.Core.Interfaces
{
    public interface IVindiContext
    {

        ICustomerService Customers { get; }

        IBillService Bills { get; }

        IChargeService Charges { get; }

        IDiscountService Discounts { get; }

        IIssueService Issues { get; }

        IPaymentService Payments { get; }

        IPeriodService Periods { get; }

        IPlanService Plans { get; }

        IProductItemsService ProductItems { get; }

        IProductService Products { get; }

        ISubscriptionService Subscriptions { get; }

        ITransactionService Transactons { get; }

    }
}
