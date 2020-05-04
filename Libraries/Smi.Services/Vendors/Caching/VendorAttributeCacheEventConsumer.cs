using Smi.Core.Domain.Vendors;
using Smi.Services.Caching;

namespace Smi.Services.Vendors.Caching
{
    /// <summary>
    /// Represents a vendor attribute cache event consumer
    /// </summary>
    public partial class VendorAttributeCacheEventConsumer : CacheEventConsumer<VendorAttribute>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(VendorAttribute entity)
        {
            base.Remove(SmiVendorDefaults.VendorAttributesAllCacheKey);

            var cacheKey = _cacheKeyService.PrepareKey(SmiVendorDefaults.VendorAttributeValuesAllCacheKey, entity);

            Remove(cacheKey);
        }
    }
}
