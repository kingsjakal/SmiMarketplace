using Smi.Core.Domain.Catalog;
using Smi.Services.Caching;

namespace Smi.Services.Catalog.Caching
{
    /// <summary>
    /// Represents a predefined product attribute value cache event consumer
    /// </summary>
    public partial class PredefinedProductAttributeValueCacheEventConsumer : CacheEventConsumer<PredefinedProductAttributeValue>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(PredefinedProductAttributeValue entity)
        {
            var cacheKey = _cacheKeyService.PrepareKey(SmiCatalogDefaults.PredefinedProductAttributeValuesAllCacheKey, entity.ProductAttributeId);
            Remove(cacheKey);
        }
    }
}
