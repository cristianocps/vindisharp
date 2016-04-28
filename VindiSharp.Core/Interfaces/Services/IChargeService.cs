using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VindiSharp.Core.Entities;

namespace VindiSharp.Core.Interfaces
{
    public interface IChargeService :
          IInsertService<Charge>,
          IUpdateService<Charge>,
          ISearchService<Charge>

    {
        void ReIssue(long Id);
        void Charge(long Id);

        void Refund(long Id);

        void FraudReview(long Id);

    }
}
