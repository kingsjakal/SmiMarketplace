using Smi.Core.Domain.Common;
using Smi.Services.Caching;

namespace Smi.Services.Common.Caching
{
    /// <summary>
    /// Represents a address attribute cache event consumer
    /// </summary>
    public partial class AddressAttributeCacheEventConsumer : CacheEventConsumer<AddressAttribute>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(AddressAttribute entity)
        {
            Remove(SmiCommonDefaults.AddressAttributesAllCacheKey);

            var cacheKey = _cacheKeyService.PrepareKey(SmiCommonDefaults.AddressAttributeValuesAllCacheKey, entity);
            Remove(cacheKey);
        }
    }
}
