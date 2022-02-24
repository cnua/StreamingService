using StreamingService.Services.Fakes;
using StreamingService.Models;
using StreamingService.Models.Fakes;
using StreamingService.Services;
using StreamingService.Repositories;
using StreamingService.Repositories.Fakes;
using System;
using Xunit;

namespace StreamingService.Test
{
    /// <summary>
    /// Test suite for <see cref="Subscription"/>.
    /// </summary>
    public class SubscriptionTests
    {
        //readonly string _email = "joe@hotmail.com";
        readonly string _subscriptionId = "e0cb3b2f-1297-4cc1-8a87-a659b1698fc2";

        [Fact]
        public void PackagesGuidTest()
        {
            var packageGuid = Guid.Parse(_subscriptionId);

            ISubscriptionRepository sr = new StubISubscriptionRepository()
            {
                
            };
            bool b = sr.GetById(packageGuid).Package==Packages.Freemium;
            Assert.True(b);


        }

    }   
}
