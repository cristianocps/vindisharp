using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VindiSharp.Core.Enums;

namespace VindiSharp.Core.Interfaces
{
    public interface ISearchService<TEntity> where TEntity : class
    {

#if !NET35
        List<TEntity> GetAll(Int32 Page = 1, Int32 PerPage = 10, List<QueryParameter> query = null, String OrderBy = null, SortOrder? OrderByDirection = SortOrder.Asc); 
#endif
#if NET35
        List<TEntity> GetAll(Int32 Page, Int32 PerPage, List<QueryParameter> query, String OrderBy, SortOrder OrderByDirection);
#endif

        TEntity GetById(long Id);

    }
}
