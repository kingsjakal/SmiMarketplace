using Smi.Core.Domain.Orders;
using Smi.Services.Caching;

namespace Smi.Services.Orders.Caching
{
    /// <summary>
    /// Represents a return request cache event consumer
    /// </summary>
    public partial class ReturnRequestCacheEventConsumer : CacheEventConsumer<ReturnRequest>
    {
    }
}
