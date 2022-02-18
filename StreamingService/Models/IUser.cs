using System;

namespace StreamingService.Models
{
    public interface IUser
    {
        string EmailAddress { get; }
        int FreeSongs { get; set; }
        int RemainingSongsThisMonth { get; set; }
        Guid SubscriptionId { get; }

        void ResetRemainingSongsThisMonth();
    }
}