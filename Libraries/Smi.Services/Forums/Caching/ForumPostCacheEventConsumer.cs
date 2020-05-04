using Smi.Core.Domain.Forums;
using Smi.Services.Caching;

namespace Smi.Services.Forums.Caching
{
    /// <summary>
    /// Represents a forum post cache event consumer
    /// </summary>
    public partial class ForumPostCacheEventConsumer : CacheEventConsumer<ForumPost>
    {
    }
}
