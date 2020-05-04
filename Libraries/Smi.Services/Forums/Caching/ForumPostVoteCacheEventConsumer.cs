using Smi.Core.Domain.Forums;
using Smi.Services.Caching;

namespace Smi.Services.Forums.Caching
{
    /// <summary>
    /// Represents a forum post vote cache event consumer
    /// </summary>
    public partial class ForumPostVoteCacheEventConsumer : CacheEventConsumer<ForumPostVote>
    {
    }
}
