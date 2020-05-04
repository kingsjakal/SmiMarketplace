using Smi.Core.Domain.Common;
using Smi.Services.Caching;

namespace Smi.Services.Common.Caching
{
    /// <summary>
    /// Represents a address attribute value cache event consumer
    /// </summary>
    public partial class AddressAttributeValueCacheEventConsumer : CacheEventConsumer<AddressAttributeValue>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(AddressAttributeValue entity)
        {
            Remove(SmiCommonDefaults.AddressAttributesAllCacheKey);

            var cacheKey = _cacheKeyService.PrepareKey(SmiCommonDefaults.AddressAttributeValuesAllCacheKey, entity.AddressAttributeId);
            Remove(cacheKey);
        }
    }
}
