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
    [TestFixture, Category("Integration")]
    public class CustomerServiceIntegrationTest
    {
        private ICustomerService customerService;

        [SetUp]
        public void Setup()
        {


            IVindiHttpClient client = new VindiHttpClient(new Uri("https://app.vindi.com.br/api/"), "lfuHcxrBPMfeB4uwU-VoSAvOUCsJqbSS", "v1");
            IVindiGenericRepository repository = new VindiGenericRepository(client);

            customerService = new CustomerService(repository);
        }

        [Test]
        public void TestGetCustomers()
        {
            List<Customer> customers = customerService.GetAll(query: new List<Core.QueryParameter> { new Core.QueryParameter("status", Core.QueryOperator.Equals, "active") });

            Assert.True(customers != null && customers.Count > 0);
        }
        [Test]
        public void TestCreateCustomer()
        {
            Customer newCustomer = new Customer
            {
                Name = "Renan 1Sight",
                Email = "contato@1sight.com.br",
                Status = Core.Enums.CustomerStatus.Active,
                Phones = new List<CustomerPhone> { new CustomerPhone { Number = "19996519722", PhoneType = Core.Enums.PhoneType.Mobile }, new CustomerPhone { Number = "551935045412", PhoneType = Core.Enums.PhoneType.Landline } }
            };

            Customer vindiCustomer = customerService.Create(newCustomer);
        }
    }
}
