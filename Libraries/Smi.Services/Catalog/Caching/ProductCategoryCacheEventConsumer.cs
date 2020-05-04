using Smi.Core.Domain.Catalog;
using Smi.Services.Caching;

namespace Smi.Services.Catalog.Caching
{
    /// <summary>
    /// Represents a product category cache event consumer
    /// </summary>
    public partial class ProductCategoryCacheEventConsumer : CacheEventConsumer<ProductCategory>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(ProductCategory entity)
        {
            var prefix = _cacheKeyService.PrepareKeyPrefix(SmiCatalogDefaults.ProductCategoriesByProductPrefixCacheKey, entity.ProductId);
            RemoveByPrefix(prefix);

            RemoveByPrefix(SmiCatalogDefaults.CategoryNumberOfProductsPrefixCacheKey);
            
            prefix = _cacheKeyService.PrepareKeyPrefix(SmiCatalogDefaults.ProductPricePrefixCacheKey, entity.ProductId);
            RemoveByPrefix(prefix);
        }
    }
}
