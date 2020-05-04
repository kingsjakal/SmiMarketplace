using Smi.Core.Domain.Catalog;
using Smi.Services.Caching;
using Smi.Services.Discounts;

namespace Smi.Services.Catalog.Caching
{
    /// <summary>
    /// Represents a manufacturer cache event consumer
    /// </summary>
    public partial class ManufacturerCacheEventConsumer : CacheEventConsumer<Manufacturer>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(Manufacturer entity)
        {
            RemoveByPrefix(SmiDiscountDefaults.DiscountManufacturerIdsPrefixCacheKey);
        }
    }
}
