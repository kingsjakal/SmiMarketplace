using Smi.Core.Domain.Catalog;
using Smi.Services.Caching;

namespace Smi.Services.Catalog.Caching
{
    /// <summary>
    /// Represents a related product cache event consumer
    /// </summary>
    public partial class RelatedProductCacheEventConsumer : CacheEventConsumer<RelatedProduct>
    {
        /// <summary>
        /// entity
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(RelatedProduct entity)
        {
            var prefix = _cacheKeyService.PrepareKeyPrefix(SmiCatalogDefaults.ProductsRelatedPrefixCacheKey, entity.ProductId1);
            RemoveByPrefix(prefix);
        }
    }
}
