using Smi.Core.Domain.Orders;
using Smi.Services.Caching;

namespace Smi.Services.Orders.Caching
{
    /// <summary>
    /// Represents a checkout attribute cache event consumer
    /// </summary>
    public partial class CheckoutAttributeCacheEventConsumer : CacheEventConsumer<CheckoutAttribute>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(CheckoutAttribute entity)
        {
            RemoveByPrefix(SmiOrderDefaults.CheckoutAttributesAllPrefixCacheKey);
            var cacheKey = _cacheKeyService.PrepareKey(SmiOrderDefaults.CheckoutAttributeValuesAllCacheKey, entity);
            Remove(cacheKey);
        }
    }
}
