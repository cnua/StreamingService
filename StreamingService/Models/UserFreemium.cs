using System;

namespace StreamingService.Models
{
    public class UserFreemium : UserBase
    {
        public UserFreemium(string emailAddress, Guid subscriptionId) : base(emailAddress, subscriptionId)
        {
            FreeSongs = 3;
        }

        public override void ResetRemainingSongsThisMonth()
        {
            throw new NotImplementedException();
        }
    }
}
