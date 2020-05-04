using Smi.Core.Domain.Discounts;
using Smi.Services.Caching;

namespace Smi.Services.Discounts.Caching
{
    /// <summary>
    /// Represents a discount-category mapping cache event consumer
    /// </summary>
    public partial class DiscountCategoryMappingCacheEventConsumer : CacheEventConsumer<DiscountCategoryMapping>
    {
    }
}