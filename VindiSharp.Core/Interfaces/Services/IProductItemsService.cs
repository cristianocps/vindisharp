using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using VindiSharp.Core.Entities;

namespace VindiSharp.Core.Interfaces
{
    public interface IProductItemsService
    {
        ProductItemsResponse Create(ProductItemsRequest Entity);
        ProductItem Delete(long Id);
#if !NET35
        List<ProductItemsResponse> GetAll(int Page = 1, int PerPage = 10, List<QueryParameter> query = null, string OrderBy = null, SortOrder? OrderByDirection = SortOrder.Asc);
#endif

#if NET35
        List<ProductItemsResponse> GetAll(int Page, int PerPage, List<QueryParameter> query, string OrderBy, SortOrder OrderByDirection);
#endif
        ProductItemsResponse GetById(long Id);
        ProductItemsResponse Update(ProductItemsRequest Entity);

    }
}
