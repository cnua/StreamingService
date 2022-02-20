using StreamingService.Models;
using System;
using System.Collections.Generic;

namespace StreamingService.Services
{
    public interface IUserService
    {
        //IEnumerable<IUser> GetUsers();
        IEnumerable<IUser> GetUsersWithRemainingSongsThisMonth();
        void ResetRemainingSongsThisMonth();
        bool Subscribe(string emailAddress, Guid subscriptionId);
    }
}