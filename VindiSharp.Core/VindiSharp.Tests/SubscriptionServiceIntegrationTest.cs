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
    public class SubscriptionServiceIntegrationTest
    {
        private ISubscriptionService subscriptionService;
        private ICustomerService customerService;
        private IPlanService planService;
        private IProductService productService;

        [SetUp]
        public void Setup()
        {

            IVindiGenericRepository repository = new VindiGenericRepository(Constants.CreateClient());

            subscriptionService = new SubscriptionService(repository);
            customerService = new CustomerService(repository);
            planService = new PlanService(repository);

        }

        [Test]
        public void TestGetSubscriptions()
        {
            List<Subscription> subscriptions = subscriptionService.GetAll(1, 10, new List<Core.QueryParameter>(), "", Core.Enums.SortOrder.Asc);

            Assert.IsTrue(subscriptions != null && subscriptions.Count > 0);
        }
        [Test]
        public void TestGetSpecificSubscription()
        {
            Subscription subscription = subscriptionService.GetById(297185);

            Assert.IsNotNull(subscription);
        }
        [Test]
        public void TestCreateSubscription()
        {
            SubscriptionResponse newSubscription = subscriptionService.Create(new SubscriptionRequest
            {
                CustomerId = 604792,
                PlanId = 9488,
                PaymentMethodCode = "credit_card",
                BillingCycles = 1,
                BillingTriggerType = Core.Enums.BillingTriggerType.BeginningOfPeriod,
                ProductItems = new List<SubscriptionRequestProductItem> { new SubscriptionRequestProductItem { ProductId = 18125, Cycles = 1 } }
            });
        }
        [Test]
        public void TestCreateSubscriptionForNewCustomer()
        {
            RandomNameGeneratorLibrary.PersonNameGenerator nameGenerator = new RandomNameGeneratorLibrary.PersonNameGenerator();

            Customer customer = customerService.Create(new Customer { Name = nameGenerator.GenerateRandomMaleFirstAndLastName(), Email = nameGenerator.GenerateRandomFirstName() + "@1sight.com.br" });

            Plan plan = planService.GetAll(1, 10, new List<Core.QueryParameter> { new Core.QueryParameter("code", Core.QueryOperator.Equals, "plano-bronze-1mes") }, "", Core.Enums.SortOrder.Asc).FirstOrDefault();

            SubscriptionResponse subscription = subscriptionService.Create(new SubscriptionRequest
            {
                CustomerId = customer.Id,
                PlanId = plan.Id,
                PaymentMethodCode = "credit_card",
                BillingCycles = 1,
                BillingTriggerType = Core.Enums.BillingTriggerType.BeginningOfPeriod,
                ProductItems = new List<SubscriptionRequestProductItem> { new SubscriptionRequestProductItem { ProductId = 18125 } }

            });

            Assert.IsNotNull(subscription);
        }
    }
}
