using Smi.Core.Domain.Catalog;
using Smi.Services.Caching;

namespace Smi.Services.Catalog.Caching
{
    /// <summary>
    /// Represents a product manufacturer cache event consumer
    /// </summary>
    public partial class ProductManufacturerCacheEventConsumer : CacheEventConsumer<ProductManufacturer>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(ProductManufacturer entity)
        {
            var prefix = _cacheKeyService.PrepareKeyPrefix(SmiCatalogDefaults.ProductManufacturersByProductPrefixCacheKey, entity.ProductId);
            RemoveByPrefix(prefix);
            
            prefix = _cacheKeyService.PrepareKeyPrefix(SmiCatalogDefaults.ProductPricePrefixCacheKey, entity.ProductId);
            RemoveByPrefix(prefix);
        }
    }
}
