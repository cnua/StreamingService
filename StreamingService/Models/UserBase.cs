using System;

namespace StreamingService.Models
{
    public abstract class UserBase: IUser
    {
        public string EmailAddress { get; private set; }
        public Guid SubscriptionId { get; private set; }
        public int FreeSongs { get; set; }
        public int RemainingSongsThisMonth { get; set; }
        public UserBase(string emailAddress, Guid subscriptionId)
        {
            this.EmailAddress = emailAddress;
            this.SubscriptionId = subscriptionId;
        }
        public virtual void ResetRemainingSongsThisMonth()
        {
            this.RemainingSongsThisMonth = FreeSongs;

        }
    }
}