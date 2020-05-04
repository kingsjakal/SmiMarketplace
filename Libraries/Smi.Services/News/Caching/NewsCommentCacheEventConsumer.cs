using Smi.Core.Domain.News;
using Smi.Services.Caching;

namespace Smi.Services.News.Caching
{
    /// <summary>
    /// Represents a news comment cache event consumer
    /// </summary>
    public partial class NewsCommentCacheEventConsumer : CacheEventConsumer<NewsComment>
    {
        /// <summary>
        /// entity
        /// </summary>
        /// <param name="entity">Entity</param>
        /// <param name="entityEventType">Entity event type</param>
        protected override void ClearCache(NewsComment entity, EntityEventType entityEventType)
        {
            if (entityEventType != EntityEventType.Delete)
                return;

            var prefix = _cacheKeyService.PrepareKeyPrefix(SmiNewsDefaults.NewsCommentsNumberPrefixCacheKey, entity.NewsItemId);

            RemoveByPrefix(prefix);
        }
    }
}