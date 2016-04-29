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

        [SetUp]
        public void Setup()
        {

            IVindiGenericRepository repository = new VindiGenericRepository(Constants.CreateClient());

            subscriptionService = new SubscriptionService(repository);
        }

        [Test]
        public void TestGetSubscriptions()
        {
            List<Subscription> subscriptions = subscriptionService.GetAll();

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
    }
}
