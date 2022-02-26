using System;
using System.ComponentModel.DataAnnotations;
namespace StreamingService.Models
{
    public abstract class UserBase: IUser
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; private set; }
        [Required]
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