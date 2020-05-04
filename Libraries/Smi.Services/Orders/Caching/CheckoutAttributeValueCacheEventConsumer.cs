using Smi.Core.Domain.Orders;
using Smi.Services.Caching;

namespace Smi.Services.Orders.Caching
{
    /// <summary>
    /// Represents a checkout attribute value cache event consumer
    /// </summary>
    public partial class CheckoutAttributeValueCacheEventConsumer : CacheEventConsumer<CheckoutAttributeValue>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(CheckoutAttributeValue entity)
        {
            var cacheKey = _cacheKeyService.PrepareKey(SmiOrderDefaults.CheckoutAttributeValuesAllCacheKey, entity.CheckoutAttributeId);
            Remove(cacheKey);
        }
    }
}
