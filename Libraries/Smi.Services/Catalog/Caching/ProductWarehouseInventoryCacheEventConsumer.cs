using Smi.Core.Domain.Catalog;
using Smi.Services.Caching;

namespace Smi.Services.Catalog.Caching
{
    /// <summary>
    /// Represents a product warehouse inventory cache event consumer
    /// </summary>
    public partial class ProductWarehouseInventoryCacheEventConsumer : CacheEventConsumer<ProductWarehouseInventory>
    {
    }
}
