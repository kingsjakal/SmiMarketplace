using Smi.Core.Domain.Stores;
using Smi.Services.Caching;
using Smi.Services.Localization;
using Smi.Services.Orders;

namespace Smi.Services.Stores.Caching
{
    /// <summary>
    /// Represents a store cache event consumer
    /// </summary>
    public partial class StoreCacheEventConsumer : CacheEventConsumer<Store>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(Store entity)
        {
            Remove(SmiStoreDefaults.StoresAllCacheKey);
            RemoveByPrefix(SmiOrderDefaults.ShoppingCartPrefixCacheKey);

            var prefix = _cacheKeyService.PrepareKeyPrefix(SmiLocalizationDefaults.LanguagesByStoreIdPrefixCacheKey, entity);

            RemoveByPrefix(prefix);
        }
    }
}
