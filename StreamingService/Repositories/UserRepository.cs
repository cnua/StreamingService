using StreamingService.Models;
using System;
using System.Collections.Generic;

namespace StreamingService.Repositories
{
    public class UserRepository : IUserRepository
    {
        public bool Exists(string EmailAddress)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Add(User user)
        {
            throw new NotImplementedException();
        }
    }
}
