using StreamingService.Services.Fakes;
using StreamingService.Models;
using StreamingService.Models.Fakes;
using StreamingService.Services;
using StreamingService.Repositories;
using StreamingService.Repositories.Fakes;
using System;
using Xunit;
using System.Linq;
using System.Collections.Generic;

namespace StreamingService.Test
{
    /// <summary>
    /// Test suite for <see cref="UserService"/>.
    /// </summary>
    public class UserServiceTests
    {
        readonly string _email = "joe@hotmail.com";
        readonly string _email2 = "jane@hotmail.com";
        readonly string _subscriptionId = "e0cb3b2f-1297-4cc1-8a87-a659b1698fc2";
        readonly Guid _premiumGuid = Guid.Parse("e0cb3b2f-1297-4cc1-8a87-a659b1698fc2");


        readonly IUserService _userService = new StubIUserService()
        {
            GetUsersWithRemainingSongsThisMonth=() => new List<IUser>() { new UserFreemium("joe@hotmail.com", Guid.Parse("e0cb3b2f-1297-4cc1-8a87-a659b1698fc2")) },
            GetUsers=() => new List<IUser>() { new UserFreemium("joe@hotmail.com", Guid.Parse("e0cb3b2f-1297-4cc1-8a87-a659b1698fc2")) }
        };
        IUserRepository _userRepo = new StubIUserRepository()
        {
            GetAll=() => new List<IUser>() { new UserFreemium("joe@hotmail.com", Guid.Parse("e0cb3b2f-1297-4cc1-8a87-a659b1698fc2")) },
            

        };
        /// <summary>
        /// true when added successful
        /// </summary>
        [Fact]
        public void SubscribeNewUserEmailAndGuid()
        {
            Guid freemiumId = Guid.Parse(_subscriptionId);
            bool result = _userService.Subscribe(_email, freemiumId);

            Assert.True(result);
        }
        /// <summary>
        /// false when user exists
        /// </summary>
        [Fact]
        public void SubscribeWhenUserAlreadyExists()
        {
            //create new & add user to repo
            IUser user=new UserFreemium(_email, _premiumGuid);
            _userRepo.Add(user);
            //subscribe with user service 
            bool result = _userService.Subscribe(user.EmailAddress, user.SubscriptionId);
            bool result2 = _userService.Subscribe(user.EmailAddress, user.SubscriptionId);
            Assert.False(result!=result2);
        }
        [Fact]
        public void GetUsers()
        {

            //Guid freemiumId = Guid.Parse(_subscriptionId);
            //IUser user = new UserFreemium(_email, freemiumId);

            int? count1 = _userRepo.GetAll().Count();

            //bool result = _userService.Subscribe(_email, _premiumGuid);
            int? count2 = _userService.GetUsers().Count();

            Assert.True(count2==count1);

        }
        [Fact]
        public void GetUsersWithRemainingSongsThisMonth()
        {
            var count1 = _userService.GetUsersWithRemainingSongsThisMonth().Count();

            Assert.True(count1>0);

        }
        [Fact]
        public void ResetRemainingSongsThisMonth()
        {
            bool result = true;
            _userService.ResetRemainingSongsThisMonth();

            foreach (IUser u in _userService.GetUsers())
            {
                result=result && (u.RemainingSongsThisMonth==u.FreeSongs);
            }
            Assert.True(result);
        }
    }
}
