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
    public class PlanServiceIntegrationTest
    {
        private IPlanService planService;

        [SetUp]
        public void Setup()
        {

            IVindiGenericRepository repository = new VindiGenericRepository(Constants.CreateClient());

            planService = new PlanService(repository);
        }

        [Test]
        public void TestGetPlans()
        {
            List<Plan> plans = planService.GetAll(1, 10, new List<Core.QueryParameter>(), "", Core.Enums.SortOrder.Asc);

            Assert.IsTrue(plans != null && plans.Count > 0);
        }
        [Test]
        public void TestGetSpecificPlan()
        {
            Plan plan = planService.GetByCode("plano-bronze-mensal");

            Assert.IsNotNull(plan);
        }
    }
}
