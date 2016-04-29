using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VindiSharp.Client;
using VindiSharp.Client.Services;
using VindiSharp.Core.Entities;
using VindiSharp.Core.Interfaces;

namespace VindiSharp.Tests
{
    [TestFixture]
    public class BillServiceIntegrationTest
    {
        private IBillService billService;

        [SetUp]
        public void Setup()
        {

            IVindiGenericRepository repository = new VindiGenericRepository(Constants.CreateClient());

            billService = new BillService(repository);
        }
        [Test]
        public void TestGetBills()
        {

            List<Bill> bills = billService.GetAll();

            Assert.True(bills != null && bills.Count > 0);
        }
    }
}
