using Smi.Core.Domain.Discounts;
using Smi.Services.Caching;

namespace Smi.Services.Discounts.Caching
{
    /// <summary>
    /// Represents a discount-manufacturer mapping cache event consumer
    /// </summary>
    public partial class DiscountManufacturerMappingCacheEventConsumer : CacheEventConsumer<DiscountManufacturerMapping>
    {
    }
}