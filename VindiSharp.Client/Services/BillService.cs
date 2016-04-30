using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VindiSharp.Core;
using VindiSharp.Core.Entities;
using VindiSharp.Core.Enums;
using VindiSharp.Core.Interfaces;

namespace VindiSharp.Client.Services
{
    public class BillService : IBillService
    {
        private readonly IVindiGenericRepository genericRepository;

        public BillService(IVindiGenericRepository repository)
        {
            genericRepository = repository;
        }

        public Bill Approve(long Id)
        {
            return genericRepository.Client.Do<Bill>(String.Format("{0}/{1}/approve", Bill.RESOURCE_NAME, Id), VindiNodeUtils.GetVindiNodeAttribute<Bill>().SingleResultNodeName, VindiRequestMethod.Post, null);
        }

        public Bill Charge(long Id)
        {
            return genericRepository.Client.Do<Bill>(String.Format("{0}/{1}/charge", Bill.RESOURCE_NAME, Id), VindiNodeUtils.GetVindiNodeAttribute<Bill>().SingleResultNodeName, VindiRequestMethod.Post, null);
        }

        public Bill Create(Bill Entity)
        {
            return genericRepository.Insert(Bill.RESOURCE_NAME, Entity);
        }

        public Bill Delete(long Id)
        {
            return genericRepository.Delete<Bill>(Bill.RESOURCE_NAME, Id);
        }

#if !NET35
        public List<Bill> GetAll(int Page = 1, int PerPage = 10, List<QueryParameter> query = null, string OrderBy = null, SortOrder? OrderByDirection = SortOrder.Asc)
        {
            return genericRepository.GetAll<Bill>(Bill.RESOURCE_NAME, Page, PerPage, query, OrderBy, OrderByDirection);
        } 
#endif

#if NET35
        public List<Bill> GetAll(int Page, int PerPage, List<QueryParameter> query, string OrderBy, SortOrder OrderByDirection)
        {
            return genericRepository.GetAll<Bill>(Bill.RESOURCE_NAME, Page, PerPage, query, OrderBy, OrderByDirection);
        }
#endif

        public Bill GetById(long Id)
        {
            return genericRepository.GetById<Bill>(Bill.RESOURCE_NAME, Id);
        }

        public Bill Update(Bill Entity)
        {
            return genericRepository.Update<Bill>(Bill.RESOURCE_NAME, Entity.Id, Entity);
        }
    }
}
