using System;

namespace StreamingService.Models
{
    public class Subscription : ISubscription//,IPackage
    {
        public Guid Id { get; }
        public Packages Package { get; }

        //public int FreeSongs { get; }
    }
}
