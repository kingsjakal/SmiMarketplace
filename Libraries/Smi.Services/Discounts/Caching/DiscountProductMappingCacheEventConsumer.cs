using Smi.Core.Domain.Discounts;
using Smi.Services.Caching;

namespace Smi.Services.Discounts.Caching
{
    /// <summary>
    /// Represents a discount-product mapping cache event consumer
    /// </summary>
    public partial class DiscountProductMappingCacheEventConsumer : CacheEventConsumer<DiscountManufacturerMapping>
    {
    }
}