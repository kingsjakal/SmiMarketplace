using Smi.Core.Domain.Catalog;
using Smi.Services.Caching;

namespace Smi.Services.Catalog.Caching
{
    /// <summary>
    /// Represents a cross-sell product cache event consumer
    /// </summary>
    public partial class CrossSellProductCacheEventConsumer : CacheEventConsumer<CrossSellProduct>
    {
    }
}
