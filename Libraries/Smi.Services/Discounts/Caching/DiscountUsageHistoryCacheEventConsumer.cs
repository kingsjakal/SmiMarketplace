using Smi.Core.Domain.Discounts;
using Smi.Services.Caching;

namespace Smi.Services.Discounts.Caching
{
    /// <summary>
    /// Represents a discount usage history cache event consumer
    /// </summary>
    public partial class DiscountUsageHistoryCacheEventConsumer : CacheEventConsumer<DiscountUsageHistory>
    {
    }
}
