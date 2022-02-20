using StreamingService.Models;
using StreamingService.Repositories;
using System;
using System.Collections.Generic;

namespace StreamingService.Services
{
    public class UserService : IUserService
    {
        public bool Subscribe(string emailAddress, Guid subscriptionId)
        {
            Console.WriteLine(string.Format("Log: Start add user with email '{0}'", emailAddress));

            if (string.IsNullOrWhiteSpace(emailAddress))
            {
                return false;
            }

            var userRepo = new UserRepository();

            if (userRepo.Exists(emailAddress))
            {
                return false;
            }

            var subscriptionRepository = new SubscriptionRepository();

            var subscription = subscriptionRepository.GetById(subscriptionId);

            IUser user = new User(emailAddress, subscriptionId);

            if (subscription.Package == Packages.Freemium)
            {
                user = new UserFreemium(emailAddress, subscriptionId);

            }                           
            else if (subscription.Package == Packages.Premium)
            {
                user = new UserPremium(emailAddress, subscriptionId);
                //user.FreeSongs = 3 * 5;
                //user.RemainingSongsThisMonth = user.FreeSongs;
            }
            else if (subscription.Package == Packages.Unlimitted)
            {
                user = new UnlimittedUser(emailAddress, subscriptionId);
                //user.RemainingSongsThisMonth = user.FreeSongs;
            }
            user.RemainingSongsThisMonth = user.FreeSongs;
            userRepo.Add(user);

            Console.WriteLine(string.Format("Log: End add user with email '{0}'", emailAddress));

            return true;
        }

        //public IEnumerable<IUser> GetUsers()
        //{
        //    //...
        //    throw new NotImplementedException();
        //}

        public IEnumerable<IUser> GetUsersWithRemainingSongsThisMonth()
        {
            //Todo
            throw new NotImplementedException();
        }

        /// <summary>
        /// To be called once per month at a fixed day/time to set every user's 
        ///  RemainingSongsThisMonth back to their FreeSongs limit.
        /// </summary>
        public void ResetRemainingSongsThisMonth()
        {
            IUserRepository userRepository = new UserRepository();
            foreach (IUser u in userRepository.GetAll())
            {
                u.ResetRemainingSongsThisMonth();
            }
        }

    }



}
