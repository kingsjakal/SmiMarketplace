using Smi.Core.Domain.Customers;
using Smi.Services.Caching;

namespace Smi.Services.Customers.Caching
{
    /// <summary>
    /// Represents a customer attribute cache event consumer
    /// </summary>
    public partial class CustomerAttributeCacheEventConsumer : CacheEventConsumer<CustomerAttribute>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(CustomerAttribute entity)
        {
            Remove(SmiCustomerServicesDefaults.CustomerAttributesAllCacheKey);
            Remove(_cacheKeyService.PrepareKey(SmiCustomerServicesDefaults.CustomerAttributeValuesAllCacheKey, entity));
        }
    }
}
