using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VindiSharp.Core;
using VindiSharp.Core.Entities;
using VindiSharp.Core.Enums;
using VindiSharp.Core.Interfaces;
namespace VindiSharp.Client.Services
{
    public class SubscriptionService : ISubscriptionService
    {
        private readonly IVindiGenericRepository genericRepository;

        public SubscriptionService(IVindiGenericRepository repository)
        {
            genericRepository = repository;
        }

        public Subscription Create(Subscription Entity)
        {
            return genericRepository.Insert<Subscription>(Subscription.RESOURCE_NAME, Entity);
        }

        public Subscription Delete(long Id)
        {
            return genericRepository.Delete<Subscription>(Subscription.RESOURCE_NAME, Id);
        }

        public List<Subscription> GetAll(int Page = 1, int PerPage = 10, List<QueryParameter> query = null, string OrderBy = null, SortOrder? OrderByDirection = SortOrder.Asc)
        {
            return genericRepository.GetAll<Subscription>(Subscription.RESOURCE_NAME, Page, PerPage, query, OrderBy, OrderByDirection);
        }

        public Subscription GetById(long Id)
        {
            return genericRepository.GetById<Subscription>(Subscription.RESOURCE_NAME, Id);
        }

        public Subscription Reactivate(long Id)
        {
            return genericRepository.Client.Do<Subscription>(String.Format("{0}/{1}/reactivate", Subscription.RESOURCE_NAME, Id), VindiNodeUtils.GetVindiNodeAttribute<Subscription>().SingleResultNodeName, VindiRequestMethod.Post);

        }
    }
}
