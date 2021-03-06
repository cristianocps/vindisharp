﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public SubscriptionResponse Create(SubscriptionRequest Entity)
        {
            return genericRepository.Client.Do<SubscriptionRequest, SubscriptionResponse>(Subscription.RESOURCE_NAME, String.Empty, VindiRequestMethod.Post, Entity);
        }

        public SubscriptionResponse Update(SubscriptionRequest Entity)
        {
            return genericRepository.Client.Do<SubscriptionRequest, SubscriptionResponse>(String.Format("{0}/{1}", Subscription.RESOURCE_NAME, Entity.Id), VindiNodeUtils.GetVindiNodeAttribute<ProductItemsRequest>().SingleResultNodeName, VindiRequestMethod.Put, Entity);
        }

        public Subscription Delete(long Id)
        {
            return genericRepository.Delete<Subscription>(Subscription.RESOURCE_NAME, Id);
        }

#if !NET35
        public List<Subscription> GetAll(int Page = 1, int PerPage = 10, List<QueryParameter> query = null, string OrderBy = null, SortOrder? OrderByDirection = SortOrder.Asc)
        {
            return genericRepository.GetAll<Subscription>(Subscription.RESOURCE_NAME, Page, PerPage, query, OrderBy, OrderByDirection);
        } 
#endif
#if NET35
        public List<Subscription> GetAll(int Page, int PerPage, List<QueryParameter> query, string OrderBy, SortOrder OrderByDirection)
        {
            return genericRepository.GetAll<Subscription>(Subscription.RESOURCE_NAME, Page, PerPage, query, OrderBy, OrderByDirection);
        }
#endif

        public Subscription GetById(long Id)
        {
            return genericRepository.GetById<Subscription>(Subscription.RESOURCE_NAME, Id);
        }

        public Subscription Reactivate(long Id)
        {
            return genericRepository.Client.Do<Subscription>(String.Format("{0}/{1}/reactivate", Subscription.RESOURCE_NAME, Id), VindiNodeUtils.GetVindiNodeAttribute<Subscription>().SingleResultNodeName, VindiRequestMethod.Post, new Dictionary<string, object>());

        }
    }
}
