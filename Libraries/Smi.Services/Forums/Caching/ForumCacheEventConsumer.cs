using Smi.Core.Domain.Forums;
using Smi.Services.Caching;

namespace Smi.Services.Forums.Caching
{
    /// <summary>
    /// Represents a forum cache event consumer
    /// </summary>
    public partial class ForumCacheEventConsumer : CacheEventConsumer<Forum>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(Forum entity)
        {
            var cacheKey = _cacheKeyService.PrepareKey(SmiForumDefaults.ForumAllByForumGroupIdCacheKey, entity.ForumGroupId);
            Remove(cacheKey);
        }
    }
}
