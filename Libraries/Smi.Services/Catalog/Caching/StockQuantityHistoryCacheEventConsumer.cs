using Smi.Core.Domain.Catalog;
using Smi.Services.Caching;

namespace Smi.Services.Catalog.Caching
{
    /// <summary>
    /// Represents a stock quantity change entry cache event consumer
    /// </summary>
    public partial class StockQuantityHistoryCacheEventConsumer : CacheEventConsumer<StockQuantityHistory>
    {
    }
}
