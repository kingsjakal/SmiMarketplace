using Smi.Core.Domain.Vendors;
using Smi.Services.Caching;

namespace Smi.Services.Vendors.Caching
{
    /// <summary>
    /// Represents a vendor attribute value cache event consumer
    /// </summary>
    public partial class VendorAttributeValueCacheEventConsumer : CacheEventConsumer<VendorAttributeValue>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(VendorAttributeValue entity)
        {
            var cacheKey = _cacheKeyService.PrepareKey(SmiVendorDefaults.VendorAttributeValuesAllCacheKey, entity.VendorAttributeId);

            Remove(cacheKey);
        }
    }
}
