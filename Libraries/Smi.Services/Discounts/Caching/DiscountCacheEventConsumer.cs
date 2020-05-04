using Smi.Core.Domain.Discounts;
using Smi.Services.Caching;

namespace Smi.Services.Discounts.Caching
{
    /// <summary>
    /// Represents a discount cache event consumer
    /// </summary>
    public partial class DiscountCacheEventConsumer : CacheEventConsumer<Discount>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(Discount entity)
        {
            RemoveByPrefix(SmiDiscountDefaults.DiscountAllPrefixCacheKey);
            var cacheKey = _cacheKeyService.PrepareKey(SmiDiscountDefaults.DiscountRequirementModelCacheKey, entity);
            Remove(cacheKey);

            var prefix = _cacheKeyService.PrepareKeyPrefix(SmiDiscountDefaults.DiscountCategoryIdsByDiscountPrefixCacheKey, entity);
            RemoveByPrefix(prefix);

            prefix = _cacheKeyService.PrepareKeyPrefix(SmiDiscountDefaults.DiscountManufacturerIdsByDiscountPrefixCacheKey, entity);
            RemoveByPrefix(prefix);
        }
    }
}
