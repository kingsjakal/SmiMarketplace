using Smi.Core.Domain.Polls;
using Smi.Services.Caching;

namespace Smi.Services.Polls.Caching
{
    /// <summary>
    /// Represents a poll cache event consumer
    /// </summary>
    public partial class PollCacheEventConsumer : CacheEventConsumer<Poll>
    {
    }
}