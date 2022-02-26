using System;

namespace StreamingService.Models
{
    public sealed class UnlimitedSubscription : ISubscription
    {
        public Guid Id { get; } = Guid.Parse("29dea130-76dd-49d1-a4d5-ade854f96be6");
        public Packages Package { get; } = Packages.Unlimitted;

    }
}
