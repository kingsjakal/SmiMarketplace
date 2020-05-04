using Smi.Core.Domain.Messages;
using Smi.Services.Caching;

namespace Smi.Services.Messages.Caching
{
    /// <summary>
    /// Represents news letter subscription cache event consumer
    /// </summary>
    public partial class NewsLetterSubscriptionCacheEventConsumer : CacheEventConsumer<NewsLetterSubscription>
    {    
    }
}
