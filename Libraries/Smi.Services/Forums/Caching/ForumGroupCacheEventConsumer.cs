using Smi.Core.Domain.Forums;
using Smi.Services.Caching;

namespace Smi.Services.Forums.Caching
{
    /// <summary>
    /// Represents a forum group cache event consumer
    /// </summary>
    public partial class ForumGroupCacheEventConsumer : CacheEventConsumer<ForumGroup>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(ForumGroup entity)
        {
            Remove(SmiForumDefaults.ForumGroupAllCacheKey);
            var cacheKey = _cacheKeyService.PrepareKey(SmiForumDefaults.ForumAllByForumGroupIdCacheKey, entity);
            Remove(cacheKey);
        }
    }
}
