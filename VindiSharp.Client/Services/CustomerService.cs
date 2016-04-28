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
    public class CustomerService : ICustomerService
    {
        private readonly IVindiGenericRepository genericRepository;

        public CustomerService(IVindiGenericRepository repository)
        {
            genericRepository = repository;
        }
        public Customer Create(Customer Entity)
        {
            return genericRepository.Insert(Entity.ResourceName, Entity);
        }

        public void Delete(long Id)
        {
            genericRepository.Delete<Customer>(Customer.RESOURCE_NAME, Id);
        }

        public List<Customer> GetAll(int Page = 1, int PerPage = 10, List<QueryParameter> query = null, string OrderBy = null, SortOrder? OrderByDirection = SortOrder.Asc)
        {
            return genericRepository.GetAll<Customer>(Customer.RESOURCE_NAME, Page, PerPage, query, OrderBy, OrderByDirection);
        }

        public Customer GetById(long Id)
        {
            return genericRepository.GetById<Customer>(Customer.RESOURCE_NAME, Id);
        }

        public void Update(Customer Entity)
        {
            genericRepository.Update(Customer.RESOURCE_NAME, Entity.Id, Entity);
        }
    }
}
