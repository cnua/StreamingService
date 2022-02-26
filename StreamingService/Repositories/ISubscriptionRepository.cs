using StreamingService.Models;
using System;

namespace StreamingService.Repositories
{
    public interface ISubscriptionRepository
    {
        ISubscription GetById(Guid id);
    }
}