using StreamingService.Models;
using System;

namespace StreamingService.Repositories
{
    public interface ISubscriptionRepository
    {
        Subscription GetById(Guid id);
    }
}