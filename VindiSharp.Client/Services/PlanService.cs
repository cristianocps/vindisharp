﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#if !NET35
using System.Threading.Tasks; 
#endif
using VindiSharp.Core;
using VindiSharp.Core.Entities;
using VindiSharp.Core.Enums;
using VindiSharp.Core.Interfaces;

namespace VindiSharp.Client.Services
{
    public class PlanService : IPlanService
    {

        private readonly IVindiGenericRepository genericRepository;

        public PlanService(IVindiGenericRepository repository)
        {
            genericRepository = repository;
        }
        public Plan Create(Plan Entity)
        {
            return genericRepository.Insert<Plan>(Plan.RESOURCE_NAME, Entity);
        }

#if !NET35
        public List<Plan> GetAll(int Page = 1, int PerPage = 10, List<QueryParameter> query = null, string OrderBy = null, SortOrder? OrderByDirection = SortOrder.Asc)
        {
            return genericRepository.GetAll<Plan>(Plan.RESOURCE_NAME, Page, PerPage, query, OrderBy, OrderByDirection);
        } 
#endif
#if NET35
        public List<Plan> GetAll(int Page, int PerPage, List<QueryParameter> query, string OrderBy, SortOrder OrderByDirection)
        {
            return genericRepository.GetAll<Plan>(Plan.RESOURCE_NAME, Page, PerPage, query, OrderBy, OrderByDirection);
        }
#endif

        public Plan GetByCode(string code)
        {
            List<Plan> plans = GetAll(1, 10, new List<QueryParameter> { new QueryParameter("code", QueryOperator.Equals, code) }, "", SortOrder.Asc);

            return plans.SingleOrDefault();
        }

        public Plan GetById(long Id)
        {
            return genericRepository.GetById<Plan>(Plan.RESOURCE_NAME, Id);
        }

        public Plan Update(Plan Entity)
        {
            return genericRepository.Update<Plan>(Plan.RESOURCE_NAME, Entity.Id, Entity);
        }
    }
}
