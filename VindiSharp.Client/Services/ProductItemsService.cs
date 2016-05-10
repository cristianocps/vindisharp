using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using VindiSharp.Core;
using VindiSharp.Core.Entities;
using VindiSharp.Core.Enums;
using VindiSharp.Core.Interfaces;

namespace VindiSharp.Client.Services
{
    public class ProductItemsService : IProductItemsService
    {
        private readonly IVindiGenericRepository genericRepository;

        public ProductItemsService(IVindiGenericRepository repository)
        {
            genericRepository = repository;
        }
        public ProductItemsResponse Create(ProductItemsRequest Entity)
        {
            return genericRepository.Client.Do<ProductItemsRequest,ProductItemsResponse>(ProductItemsRequest.RESOURCE_NAME,VindiNodeUtils.GetVindiNodeAttribute<ProductItemsRequest>().SingleResultNodeName,VindiRequestMethod.Post,Entity);
        }

        public ProductItem Delete(long Id)
        {
            return genericRepository.Delete<ProductItem>(ProductItem.RESOURCE_NAME, Id);
        }

#if !NET35
        public List<ProductItemsResponse> GetAll(int Page = 1, int PerPage = 10, List<QueryParameter> query = null, string OrderBy = null, SortOrder? OrderByDirection = SortOrder.Asc)
        {
            return null;
        } 
#endif

#if NET35
        public List<ProductItemsResponse> GetAll(int Page, int PerPage, List<QueryParameter> query, string OrderBy, System.Data.SqlClient.SortOrder OrderByDirection)
        {
            return null;
        }
#endif

        public ProductItemsResponse GetById(long Id)
        {
            return genericRepository.GetById<ProductItemsResponse>(ProductItemsResponse.RESOURCE_NAME, Id);
        }

        public ProductItemsResponse Update(ProductItemsRequest Entity)
        {
            return genericRepository.Client.Do<ProductItemsRequest, ProductItemsResponse>(String.Format("{0}/{1}", ProductItemsRequest.RESOURCE_NAME, Entity.Id), VindiNodeUtils.GetVindiNodeAttribute<ProductItemsRequest>().SingleResultNodeName, VindiRequestMethod.Put, Entity);
        }
    }
}
