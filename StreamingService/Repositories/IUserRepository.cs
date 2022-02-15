using StreamingService.Models;
using System.Collections.Generic;

namespace StreamingService.Repositories
{
    public interface IUserRepository
    {
        void Add(User user);
        bool Exists(string EmailAddress);
        IEnumerable<User> GetAll();
    }
}