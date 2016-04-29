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
    }
}
