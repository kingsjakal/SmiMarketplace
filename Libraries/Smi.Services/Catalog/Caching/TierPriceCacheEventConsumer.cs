using Smi.Core.Domain.Catalog;
using Smi.Services.Caching;

namespace Smi.Services.Catalog.Caching
{
    /// <summary>
    /// Represents a tier price cache event consumer
    /// </summary>
    public partial class TierPriceCacheEventConsumer : CacheEventConsumer<TierPrice>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(TierPrice entity)
        {
            var cacheKey = _cacheKeyService.PrepareKey(SmiCatalogDefaults.ProductTierPricesCacheKey, entity.ProductId);
            Remove(cacheKey);

            var prefix = _cacheKeyService.PrepareKeyPrefix(SmiCatalogDefaults.ProductPricePrefixCacheKey, entity.ProductId);
            RemoveByPrefix(prefix);
        }
    }
}
