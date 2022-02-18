using System;

namespace StreamingService.Models
{
    public interface ISubscription
    {
        Guid Id { get; }
        Packages Package { get; }
    }
}