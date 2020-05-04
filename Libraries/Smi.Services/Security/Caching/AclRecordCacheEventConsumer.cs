using Smi.Core.Domain.Security;
using Smi.Services.Caching;

namespace Smi.Services.Security.Caching
{
    /// <summary>
    /// Represents a ACL record cache event consumer
    /// </summary>
    public partial class AclRecordCacheEventConsumer : CacheEventConsumer<AclRecord>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(AclRecord entity)
        {
            var cacheKey = _cacheKeyService.PrepareKey(SmiSecurityDefaults.AclRecordByEntityIdNameCacheKey, entity.EntityId, entity.EntityName);
            Remove(cacheKey);
        }
    }
}
