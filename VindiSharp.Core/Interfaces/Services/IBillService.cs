using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VindiSharp.Core.Entities;

namespace VindiSharp.Core.Interfaces
{
    public interface IBillService :
        IDeleteService<Bill>,
        IInsertService<Bill>,
        IUpdateService<Bill>,
        ISearchService<Bill>

    {
        void Approve(long Id);
        void Charge(long Id);
    }
}
