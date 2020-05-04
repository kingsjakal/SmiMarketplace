using Smi.Core.Domain.Shipping;
using Smi.Services.Caching;

namespace Smi.Services.Shipping.Caching
{
    /// <summary>
    /// Represents a shipment cache event consumer
    /// </summary>
    public partial class ShipmentCacheEventConsumer : CacheEventConsumer<Shipment>
    {
    }
}