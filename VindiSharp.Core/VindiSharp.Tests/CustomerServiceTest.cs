using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VindiSharp.Client;
using VindiSharp.Core.Interfaces;
using FakeItEasy;
using VindiSharp.Client.Services;
using VindiSharp.Core.Entities;

namespace VindiSharp.Tests
{
    [TestFixture]
    public class CustomerServiceTest
    {
        private ICustomerService customerService;
        private IVindiGenericRepository genericRepository;

        [SetUp]
        public void Setup()
        {
            genericRepository = A.Fake<IVindiGenericRepository>();

            customerService = new CustomerService(genericRepository);

        }
        [Test]
        public void TestGetAll()
        {
            customerService.GetAll(1, 10, new List<Core.QueryParameter>(), "", Core.Enums.SortOrder.Asc);

            A.CallTo(() => genericRepository.GetAll<Customer>(Customer.RESOURCE_NAME, 1, 10, null, null, null)).MustHaveHappened();

        }
        [Test]
        public void TestGetById()
        {
            Customer customer = A.Fake<Customer>();

            A.CallTo(() => genericRepository.GetById<Customer>(Customer.RESOURCE_NAME, 10)).Returns(customer);

            Customer otherCustomer = customerService.GetById(10);

            Assert.AreEqual(customer, otherCustomer);
        }
    }
}
