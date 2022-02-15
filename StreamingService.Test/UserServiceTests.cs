using StreamingService.Services.Fakes;
using System;
using Xunit;

namespace StreamingService.Test
{
    /// <summary>
    /// Test suite for <see cref="UserService"/>.
    /// </summary>
    public class UserServiceTests
    {
        public readonly StubIUserService SUT = new() { SubscribeStringGuid=(email, guid) => true };

        [Fact]
        public void SubscribeFreemium()
        {
            var freemiumId = Guid.Parse("e0cb3b2f-1297-4cc1-8a87-a659b1698fc2");
            SUT.Equals(freemiumId);
            var result = SUT.SubscribeStringGuid("email", freemiumId);

            Assert.True(result);
        }

    }
}
