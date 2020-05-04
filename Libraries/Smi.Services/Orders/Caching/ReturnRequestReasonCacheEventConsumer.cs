using Smi.Core.Domain.Orders;
using Smi.Services.Caching;

namespace Smi.Services.Orders.Caching
{
    /// <summary>
    /// Represents a return request reason cache event consumer
    /// </summary>
    public partial class ReturnRequestReasonCacheEventConsumer : CacheEventConsumer<ReturnRequestReason>
    {
        protected override void ClearCache(ReturnRequestReason entity)
        {
            Remove(SmiOrderDefaults.ReturnRequestReasonAllCacheKey);
        }
    }
}
