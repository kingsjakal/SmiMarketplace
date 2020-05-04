using Smi.Core.Domain.Customers;
using Smi.Services.Caching;

namespace Smi.Services.Customers.Caching
{
    /// <summary>
    /// Represents a customer role cache event consumer
    /// </summary>
    public partial class CustomerRoleCacheEventConsumer : CacheEventConsumer<CustomerRole>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(CustomerRole entity)
        {
            RemoveByPrefix(SmiCustomerServicesDefaults.CustomerRolesPrefixCacheKey);
            RemoveByPrefix(SmiCustomerServicesDefaults.CustomerCustomerRolesPrefixCacheKey);
        }
    }
}
