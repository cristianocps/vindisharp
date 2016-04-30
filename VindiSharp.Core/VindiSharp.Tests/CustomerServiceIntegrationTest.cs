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
using VindiSharp.Core.Extensions;
namespace VindiSharp.Tests
{
    [TestFixture, Category("Integration")]
    public class CustomerServiceIntegrationTest
    {
        private ICustomerService customerService;

        [SetUp]
        public void Setup()
        {



            IVindiGenericRepository repository = new VindiGenericRepository(Constants.CreateClient());

            customerService = new CustomerService(repository);
        }

        [Test]
        public void TestGetCustomers()
        {
            List<Customer> customers = customerService.GetAll(1, 10, new List<Core.QueryParameter> { new Core.QueryParameter("status", Core.QueryOperator.Equals, "active") }, "", Core.Enums.SortOrder.Asc);

            Assert.True(customers != null && customers.Count > 0);
        }
        [Test]
        public void TestCreateCustomer()
        {
            Customer newCustomer = customerService.GetById(604792);


            newCustomer.Phones.Add(new CustomerPhone { Number = "5519996589496", PhoneType = Core.Enums.PhoneType.Mobile });

            Customer updatedCustomer = customerService.Update(newCustomer);
        }
    }
}
