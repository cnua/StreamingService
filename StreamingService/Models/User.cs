using System;

namespace StreamingService.Models
{
    public sealed class User : UserBase
    {
        public sealed override int FreeSongs { get; } = -1;
        public User(string emailAddress, Guid subscriptionId): base(emailAddress, subscriptionId)
        {

        }
    }
}
