using Smi.Core.Domain.Catalog;
using Smi.Services.Caching;
using Smi.Services.Orders;

namespace Smi.Services.Catalog.Caching
{
    /// <summary>
    /// Represents a product cache event consumer
    /// </summary>
    public partial class ProductCacheEventConsumer : CacheEventConsumer<Product>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(Product entity)
        {
            var prefix = _cacheKeyService.PrepareKeyPrefix(SmiCatalogDefaults.ProductManufacturersByProductPrefixCacheKey, entity);
            RemoveByPrefix(prefix);

            Remove(SmiCatalogDefaults.ProductsAllDisplayedOnHomepageCacheKey);
            RemoveByPrefix(SmiCatalogDefaults.ProductsByIdsPrefixCacheKey);

            prefix = _cacheKeyService.PrepareKeyPrefix(SmiCatalogDefaults.ProductPricePrefixCacheKey, entity);
            RemoveByPrefix(prefix);

            RemoveByPrefix(SmiOrderDefaults.ShoppingCartPrefixCacheKey);
        }
    }
}
