using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VindiSharp.Core;
using VindiSharp.Client;
using FakeItEasy;
using VindiSharp.Core.Interfaces;
using VindiSharp.Core.Entities;

namespace VindiSharp.Tests
{
    [TestFixture]
    public class VindiGenericRepositoryTest
    {
        private IVindiHttpClient vindiClient;
        private IVindiGenericRepository genericRepository;
        [SetUp]
        public void Setup()
        {
            vindiClient = A.Fake<IVindiHttpClient>();

            genericRepository = new VindiGenericRepository(vindiClient);


        }

        [Test(Description = "Testa se o repositório genérico está chamando o método Do da Interface IVindiHttpClient")]
        public void TestDo()
        {

            genericRepository.GetAll<Customer>(Customer.RESOURCE_NAME);

            A.CallTo(() => vindiClient.Do<List<Customer>>(Customer.RESOURCE_NAME, "customers", Core.Enums.VindiRequestMethod.Get, null))
                .WithAnyArguments()
                .MustHaveHappened();
        }
    }
}
