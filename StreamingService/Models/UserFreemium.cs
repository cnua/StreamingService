using System;

namespace StreamingService.Models
{
    public class UserFreemium : UserBase
    {
        public override int FreeSongs { get; } = 3;
        public UserFreemium(string emailAddress, Guid subscriptionId) : base(emailAddress, subscriptionId)
        {

        }

    }
}
