using Smi.Core.Domain.Customers;
using Smi.Services.Caching;

namespace Smi.Services.Customers.Caching
{
    /// <summary>
    /// Represents a customer attribute value cache event consumer
    /// </summary>
    public partial class CustomerAttributeValueCacheEventConsumer : CacheEventConsumer<CustomerAttributeValue>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(CustomerAttributeValue entity)
        {
            Remove(SmiCustomerServicesDefaults.CustomerAttributesAllCacheKey);
            Remove(_cacheKeyService.PrepareKey(SmiCustomerServicesDefaults.CustomerAttributeValuesAllCacheKey, entity.CustomerAttributeId));
        }
    }
}