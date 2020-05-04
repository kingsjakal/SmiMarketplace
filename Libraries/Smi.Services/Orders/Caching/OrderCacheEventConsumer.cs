using Smi.Core.Domain.Orders;
using Smi.Services.Caching;

namespace Smi.Services.Orders.Caching
{
    /// <summary>
    /// Represents a order cache event consumer
    /// </summary>
    public partial class OrderCacheEventConsumer : CacheEventConsumer<Order>
    {
    }
}