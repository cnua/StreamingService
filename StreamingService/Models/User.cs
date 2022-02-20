using System;

namespace StreamingService.Models
{
    public class User : UserBase
    {
        public User(string emailAddress, Guid subscriptionId): base(emailAddress, subscriptionId)
        {
            FreeSongs = -1;
        }

        //public override void ResetRemainingSongsThisMonth()
        //{
        //    this.RemainingSongsThisMonth = FreeSongs;
        //}
    }
}
