using Smi.Core.Domain.Stores;
using Smi.Services.Caching;

namespace Smi.Services.Stores.Caching
{
    /// <summary>
    /// Represents a store mapping cache event consumer
    /// </summary>
    public partial class StoreMappingCacheEventConsumer : CacheEventConsumer<StoreMapping>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(StoreMapping entity)
        {
            var entityId = entity.EntityId;
            var entityName = entity.EntityName;

            var key = _cacheKeyService.PrepareKey(SmiStoreDefaults.StoreMappingsByEntityIdNameCacheKey, entityId, entityName);

            Remove(key);

            key = _cacheKeyService.PrepareKey(SmiStoreDefaults.StoreMappingIdsByEntityIdNameCacheKey, entityId, entityName);
            
            Remove(key);
        }
    }
}
