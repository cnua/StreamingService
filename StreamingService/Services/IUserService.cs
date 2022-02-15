using StreamingService.Models;
using System;
using System.Collections.Generic;

namespace StreamingService.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
        IEnumerable<User> GetUsersWithRemainingSongsThisMonth();
        void ResetRemainingSongsThisMonth();
        bool Subscribe(string emailAddress, Guid subscriptionId);
    }
}