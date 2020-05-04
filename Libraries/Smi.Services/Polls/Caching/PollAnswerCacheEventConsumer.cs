using Smi.Core.Domain.Polls;
using Smi.Services.Caching;

namespace Smi.Services.Polls.Caching
{
    /// <summary>
    /// Represents a poll answer cache event consumer
    /// </summary>
    public partial class PollAnswerCacheEventConsumer : CacheEventConsumer<PollAnswer>
    {
    }
}