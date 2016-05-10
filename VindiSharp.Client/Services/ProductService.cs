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
    public class ProductService : IProductService
    {
        private readonly IVindiGenericRepository genericRepository;

        public ProductService(IVindiGenericRepository repository)
        {
            genericRepository = repository;
        }
        public Product Create(Product Entity)
        {
            return genericRepository.Insert(Entity.ResourceName, Entity);
        }

        public Product Delete(long Id)
        {
            return genericRepository.Delete<Product>(Product.RESOURCE_NAME, Id);
        }

#if !NET35
        public List<Product> GetAll(int Page = 1, int PerPage = 10, List<QueryParameter> query = null, string OrderBy = null, SortOrder? OrderByDirection = SortOrder.Asc)
        {
            return genericRepository.GetAll<Product>(Product.RESOURCE_NAME, Page, PerPage, query, OrderBy, OrderByDirection);
        } 
#endif

#if NET35
        public List<Product> GetAll(int Page, int PerPage, List<QueryParameter> query, string OrderBy, SortOrder OrderByDirection)
        {
            return genericRepository.GetAll<Product>(Product.RESOURCE_NAME, Page, PerPage, query, OrderBy, OrderByDirection);
        }
#endif
        public Product GetByCode(string code)
        {
            List<Product> plans = GetAll(1, 10, new List<QueryParameter> { new QueryParameter("code", QueryOperator.Equals, code) }, "", SortOrder.Asc);

            return plans.SingleOrDefault();
        }

        public Product GetById(long Id)
        {
            return genericRepository.GetById<Product>(Product.RESOURCE_NAME, Id);
        }

        public Product Update(Product Entity)
        {
            return genericRepository.Update(Product.RESOURCE_NAME, Entity.Id, Entity);
        }
    }
}
