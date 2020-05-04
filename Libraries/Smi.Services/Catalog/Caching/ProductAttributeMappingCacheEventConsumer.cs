using Smi.Core.Domain.Catalog;
using Smi.Services.Caching;

namespace Smi.Services.Catalog.Caching
{
    /// <summary>
    /// Represents a product attribute mapping cache event consumer
    /// </summary>
    public partial class ProductAttributeMappingCacheEventConsumer : CacheEventConsumer<ProductAttributeMapping>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(ProductAttributeMapping entity)
        {
            var cacheKey = _cacheKeyService.PrepareKey(SmiCatalogDefaults.ProductAttributeMappingsAllCacheKey, entity.ProductId);
            Remove(cacheKey);

            cacheKey = _cacheKeyService.PrepareKey(SmiCatalogDefaults.ProductAttributeValuesAllCacheKey, entity);
            Remove(cacheKey);

            cacheKey = _cacheKeyService.PrepareKey(SmiCatalogDefaults.ProductAttributeCombinationsAllCacheKey, entity.ProductId);
            Remove(cacheKey);
        }
    }
}
