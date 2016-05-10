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
    public class ProductServiceIntegrationTest
    {
        private IProductService ProductService;

        [SetUp]
        public void Setup()
        {

            IVindiGenericRepository repository = new VindiGenericRepository(Constants.CreateClient());

            ProductService = new ProductService(repository);
        }

        [Test]
        public void TestGetProducts()
        {
            List<Product> Products = ProductService.GetAll(1, 10, new List<Core.QueryParameter>(), "", Core.Enums.SortOrder.Asc);

            Assert.IsTrue(Products != null && Products.Count > 0);
        }
        [Test]
        public void TestGetSpecificProduct()
        {
            Product Product = ProductService.GetByCode("MIGRBRONZEPRATA");

            Assert.IsNotNull(Product);
        }
    }
}
