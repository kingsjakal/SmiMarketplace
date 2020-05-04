using Smi.Core.Domain.Orders;
using Smi.Services.Caching;

namespace Smi.Services.Orders.Caching
{
    /// <summary>
    /// Represents a return request action cache event consumer
    /// </summary>
    public partial class ReturnRequestActionCacheEventConsumer : CacheEventConsumer<ReturnRequestAction>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(ReturnRequestAction entity)
        {
            Remove(SmiOrderDefaults.ReturnRequestActionAllCacheKey);
        }
    }
}
