using Smi.Core.Domain.Orders;
using Smi.Services.Caching;

namespace Smi.Services.Orders.Caching
{
    /// <summary>
    /// Represents a gift card cache event consumer
    /// </summary>
    public partial class GiftCardCacheEventConsumer : CacheEventConsumer<GiftCard>
    {
    }
}
