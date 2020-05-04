using Smi.Core.Domain.Customers;
using Smi.Services.Caching;

namespace Smi.Services.Customers.Caching
{
    /// <summary>
    /// Represents a customer address mapping cache event consumer
    /// </summary>
    public partial class CustomerAddressMappingCacheEventConsumer : CacheEventConsumer<CustomerAddressMapping>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(CustomerAddressMapping entity)
        {
            RemoveByPrefix(SmiCustomerServicesDefaults.CustomerAddressesPrefixCacheKey);
        }
    }
}