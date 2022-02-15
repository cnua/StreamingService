using System;

namespace StreamingService.Models
{
    public class UnlimittedUser : User
    {
        public UnlimittedUser(string emailAddress, Guid subscriptionId) : base(emailAddress, subscriptionId)
        {
        }

        public override void ResetRemainingSongsThisMonth()
        {
            throw new NotImplementedException();
        }
    }
}
