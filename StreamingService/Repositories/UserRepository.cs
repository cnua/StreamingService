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

        public IEnumerable<IUser> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Add(IUser user)
        {
            throw new NotImplementedException();
        }

        #region refactor import
        public IEnumerable<IUser> GetUsers()
        {
            //...
            throw new NotImplementedException();
        }
        #endregion
    }
}
