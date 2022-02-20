using StreamingService.Services.Fakes;
using StreamingService.Models;
using StreamingService.Services;
using StreamingService.Repositories;
using System;
using Xunit;

namespace StreamingService.Test
{
    /// <summary>
    /// Test suite for <see cref="UserService"/>.
    /// </summary>
    public class UserServiceTests
    {
        

        [Fact]
        public void SubscribeFreemium()
        {
            StubIUserService SUT = new() { SubscribeStringGuid=(email, guid) => true };
        var freemiumId = Guid.Parse("e0cb3b2f-1297-4cc1-8a87-a659b1698fc2");
            var result = SUT.SubscribeStringGuid("email", freemiumId);

            Assert.True(result);
        }
        [Fact]
        public void Test_FreemiumFreeSongs()
        {
            var freemiumId = Guid.Parse("e0cb3b2f-1297-4cc1-8a87-a659b1698fc2");
            var email = "joe@hotmail.com";
            var expected = 3;
            var fuser = new UserFreemium(email, freemiumId);
            var result = fuser.FreeSongs;

            Assert.True(result==expected);
        }
    }
}
