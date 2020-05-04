using Smi.Core.Domain.Common;
using Smi.Services.Caching;

namespace Smi.Services.Common.Caching
{
    /// <summary>
    /// Represents a generic attribute cache event consumer
    /// </summary>
    public partial class GenericAttributeCacheEventConsumer : CacheEventConsumer<GenericAttribute>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(GenericAttribute entity)
        {
            var cacheKey = _cacheKeyService.PrepareKey(SmiCommonDefaults.GenericAttributeCacheKey, entity.EntityId, entity.KeyGroup);
            Remove(cacheKey);
        }
    }
}
