using System;

namespace StreamingService.Models
{
    public abstract class UserBase: IUser
    {
        public string EmailAddress { get; private set; }
        public Guid SubscriptionId { get; private set; }
        public abstract int FreeSongs { get; }
        public int RemainingSongsThisMonth { get; set; }
        public UserBase(string emailAddress, Guid subscriptionId)
        {
            EmailAddress = emailAddress;
            SubscriptionId = subscriptionId;
            RemainingSongsThisMonth = FreeSongs;
        }
        public virtual void ResetRemainingSongsThisMonth()
        {
            this.RemainingSongsThisMonth = FreeSongs;

        }
    }
}