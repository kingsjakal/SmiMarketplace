using Smi.Core.Domain.Shipping;
using Smi.Services.Caching;

namespace Smi.Services.Shipping.Caching
{
    /// <summary>
    /// Represents a product availability range cache event consumer
    /// </summary>
    public partial class ProductAvailabilityRangeCacheEventConsumer : CacheEventConsumer<ProductAvailabilityRange>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(ProductAvailabilityRange entity)
        {
            Remove(SmiShippingDefaults.ProductAvailabilityAllCacheKey);
        }
    }
}