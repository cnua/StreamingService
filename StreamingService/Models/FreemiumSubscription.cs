using System;

namespace StreamingService.Models
{
    public sealed class FreemiumSubscription : ISubscription
    {
        public Guid Id { get; } = Guid.Parse("e0cb3b2f-1297-4cc1-8a87-a659b1698fc2");
        public Packages Package { get; } = Packages.Freemium;

    }
}
