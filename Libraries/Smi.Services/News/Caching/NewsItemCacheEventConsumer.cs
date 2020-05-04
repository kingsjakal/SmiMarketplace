using Smi.Core.Domain.News;
using Smi.Services.Caching;

namespace Smi.Services.News.Caching
{
    /// <summary>
    /// Represents a news item cache event consumer
    /// </summary>
    public partial class NewsItemCacheEventConsumer : CacheEventConsumer<NewsItem>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(NewsItem entity)
        {
            var prefix = _cacheKeyService.PrepareKeyPrefix(SmiNewsDefaults.NewsCommentsNumberPrefixCacheKey, entity);

            RemoveByPrefix(prefix);
        }
    }
}