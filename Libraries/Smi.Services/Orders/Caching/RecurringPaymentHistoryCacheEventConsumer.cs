using Smi.Core.Domain.Orders;
using Smi.Services.Caching;

namespace Smi.Services.Orders.Caching
{
    /// <summary>
    /// Represents a recurring payment history cache event consumer
    /// </summary>
    public partial class RecurringPaymentHistoryCacheEventConsumer : CacheEventConsumer<RecurringPaymentHistory>
    {
    }
}
