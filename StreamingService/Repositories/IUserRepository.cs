using StreamingService.Models;
using System.Collections.Generic;

namespace StreamingService.Repositories
{
    public interface IUserRepository
    {
        void Add(IUser user);
        bool Exists(string EmailAddress);
        IEnumerable<IUser> GetAll();
    }
}