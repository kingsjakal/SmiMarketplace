using Smi.Core.Domain.Shipping;
using Smi.Services.Caching;

namespace Smi.Services.Shipping.Caching
{
    /// <summary>
    /// Represents a warehouse cache event consumer
    /// </summary>
    public partial class WarehouseCacheEventConsumer : CacheEventConsumer<Warehouse>
    {
        protected override void ClearCache(Warehouse entity)
        {
            Remove(SmiShippingDefaults.WarehousesAllCacheKey);
        }
    }
}
