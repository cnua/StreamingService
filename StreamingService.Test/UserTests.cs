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
    /// Test suite for <see cref="User"/>.
    /// </summary>
    public class UserTests
    {
        readonly string _email="joe@hotmail.com";
        readonly Guid _guid= Guid.NewGuid();
        readonly int _FreemiumFreeSongs = 3;
        readonly int _PremiumFreeSongs = 3*5;
        readonly int _UnlimitedFreeSongs = int.MaxValue;
        readonly int _UserFreeSongs = -1;
        /// <summary>
        /// freemiumId User 
        /// </summary>
    //    public StubIUser stubuser = new StubIUser()
    //    {
    //        EmailAddressGet=() => "joe@hotmail.com",
    //         FreeSongsGet=() =>3,
    //         SubscriptionIdGet=() => Guid.Parse("e0cb3b2f-1297-4cc1-8a87-a659b1698fc2"),
    //          RemainingSongsThisMonthGet=()=>3
    //};

        [Fact]
        public void Freemium_Test()
        {
            /*
             test freesongs for User class
             */
            IUser user = new UserFreemium(_email, _guid);
            int expected = _FreemiumFreeSongs;
            var result = user.FreeSongs;

            Assert.True(result==expected);
        }
        [Fact]
        public void Premium_Test()
        {
            /*
             test freesongs for User class
             */
            IUser user = new UserPremium(_email, _guid);
            int expected = _PremiumFreeSongs;
            var result = user.FreeSongs;

            Assert.True(result==expected);
        }
        [Fact]
        public void ResetRemainingSongsThisMonth()
        {
            /*
             
             */
            IUser user = new UserPremium(_email, _guid);
            user.RemainingSongsThisMonth-=1;
            user.ResetRemainingSongsThisMonth();

            Assert.True(user.FreeSongs==user.RemainingSongsThisMonth);
        }

    }
}
