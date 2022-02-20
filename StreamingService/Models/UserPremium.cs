using System;

namespace StreamingService.Models
{
    public class UserPremium : UserBase
    {
        public UserPremium(string emailAddress, Guid subscriptionId) : base(emailAddress, subscriptionId)
        {
            FreeSongs = 3*5;
        }

        //public override void ResetRemainingSongsThisMonth()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
