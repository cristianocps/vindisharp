﻿using System.Collections.Generic;
using VindiSharp.Core;
using VindiSharp.Core.Enums;
using VindiSharp.Core.Interfaces;

namespace VindiSharp.Client
{
    public interface IVindiGenericRepository
    {
        IVindiHttpClient Client { get; }

        TEntity Delete<TEntity>(string ResourceName, long Id) where TEntity : class, IVindiEntity, new();
#if !NET35
        List<TEntity> GetAll<TEntity>(string ResourceName, int Page = 1, int PerPage = 10, List<QueryParameter> Parameters = null, string OrderBy = null, SortOrder? OrderByDirection = default(SortOrder?)) where TEntity : class, IVindiEntity, new(); 
#endif
#if NET35
        List<TEntity> GetAll<TEntity>(string ResourceName, int Page, int PerPage, List<QueryParameter> Parameters, string OrderBy, SortOrder? OrderByDirection) where TEntity : class, IVindiEntity, new();
#endif
        TEntity GetById<TEntity>(string ResourceName, long Id) where TEntity : class, IVindiEntity, new();
        TEntity Insert<TEntity>(string ResourceName, TEntity Entity) where TEntity : class, IVindiEntity, new();
        TEntity Update<TEntity>(string ResourceName, long Id, TEntity Entity) where TEntity : class, IVindiEntity, new();
    }
}