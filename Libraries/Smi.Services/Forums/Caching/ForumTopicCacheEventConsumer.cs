using Smi.Core.Domain.Forums;
using Smi.Services.Caching;

namespace Smi.Services.Forums.Caching
{
    /// <summary>
    /// Represents a forum topic cache event consumer
    /// </summary>
    public partial class ForumTopicCacheEventConsumer : CacheEventConsumer<ForumTopic>
    {
    }
}
