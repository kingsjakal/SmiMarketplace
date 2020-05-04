using Smi.Core.Domain.Seo;
using Smi.Services.Caching;

namespace Smi.Services.Seo.Caching
{
    /// <summary>
    /// Represents an URL record cache event consumer
    /// </summary>
    public partial class UrlRecordCacheEventConsumer : CacheEventConsumer<UrlRecord>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(UrlRecord entity)
        {
            Remove(SmiSeoDefaults.UrlRecordAllCacheKey);

            var cacheKey = _cacheKeyService.PrepareKey(SmiSeoDefaults.UrlRecordActiveByIdNameLanguageCacheKey,
                entity.EntityId, entity.EntityName, entity.LanguageId);
            Remove(cacheKey);

            RemoveByPrefix(SmiSeoDefaults.UrlRecordByIdsPrefixCacheKey);

            cacheKey = _cacheKeyService.PrepareKey(SmiSeoDefaults.UrlRecordBySlugCacheKey, entity.Slug);
            Remove(cacheKey);
        }
    }
}
