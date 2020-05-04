using Smi.Core.Domain.Catalog;
using Smi.Services.Caching;

namespace Smi.Services.Catalog.Caching
{
    /// <summary>
    /// Represents a product review review type cache event consumer
    /// </summary>
    public partial class ProductReviewReviewTypeMappingCacheEventConsumer : CacheEventConsumer<ProductReviewReviewTypeMapping>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(ProductReviewReviewTypeMapping entity)
        {
            Remove(SmiCatalogDefaults.ReviewTypeAllCacheKey);

            var cacheKey = _cacheKeyService.PrepareKey(SmiCatalogDefaults.ProductReviewReviewTypeMappingAllCacheKey, entity.ProductReviewId);
            Remove(cacheKey);
        }
    }
}
