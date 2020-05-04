using Smi.Core.Domain.Customers;
using Smi.Services.Caching;

namespace Smi.Services.Customers.Caching
{
    /// <summary>
    /// Represents a customer password cache event consumer
    /// </summary>
    public partial class CustomerPasswordCacheEventConsumer : CacheEventConsumer<CustomerPassword>
    {
    }
}