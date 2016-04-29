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
    public class BillService : IBillService
    {
        private readonly IVindiGenericRepository genericRepository;

        public BillService(IVindiGenericRepository repository)
        {
            genericRepository = repository;
        }

        public void Approve(long Id)
        {
            
        }

        public void Charge(long Id)
        {
            throw new NotImplementedException();
        }

        public Bill Create(Bill Entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(long Id)
        {
            throw new NotImplementedException();
        }

        public List<Bill> GetAll(int Page = 1, int PerPage = 10, List<QueryParameter> query = null, string OrderBy = null, SortOrder? OrderByDirection = SortOrder.Asc)
        {
            throw new NotImplementedException();
        }

        public Bill GetById(long Id)
        {
            throw new NotImplementedException();
        }

        public Bill Update(Bill Entity)
        {
            throw new NotImplementedException();
        }
    }
}
