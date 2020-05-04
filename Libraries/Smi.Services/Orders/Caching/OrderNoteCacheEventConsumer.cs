using Smi.Core.Domain.Orders;
using Smi.Services.Caching;

namespace Smi.Services.Orders.Caching
{
    /// <summary>
    /// Represents an order note cache event consumer
    /// </summary>
    public partial class OrderNoteCacheEventConsumer : CacheEventConsumer<OrderNote>
    {
    }
}
