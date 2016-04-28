using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VindiSharp.Core.Entities;

namespace VindiSharp.Core.Interfaces
{
    public interface ICustomerService :
        IDeleteService<Customer>,
        IInsertService<Customer>,
        IUpdateService<Customer>,
        ISearchService<Customer>

    {

    }
}
