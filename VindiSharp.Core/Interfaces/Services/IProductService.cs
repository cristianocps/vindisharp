using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VindiSharp.Core.Entities;

namespace VindiSharp.Core.Interfaces
{
    public interface IProductService :
        IDeleteService<Product>,
        IInsertService<Product>,
        IUpdateService<Product>,
        ISearchService<Product>

    {
        Product GetByCode(String code);
    }
}
