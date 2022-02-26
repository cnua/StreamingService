using System;

namespace StreamingService.Models
{
    public class Subscription : ISubscription
    {
        public Guid Id { get; }
        public Packages Package { get; }

    }
}
