using Smi.Core.Domain.Customers;
using Smi.Services.Caching;
using Smi.Services.Events;
using Smi.Services.Orders;

namespace Smi.Services.Customers.Caching
{
    /// <summary>
    /// Represents a customer cache event consumer
    /// </summary>
    public partial class CustomerCacheEventConsumer : CacheEventConsumer<Customer>, IConsumer<CustomerPasswordChangedEvent>
    {
        #region Methods

        /// <summary>
        /// Handle password changed event
        /// </summary>
        /// <param name="eventMessage">Event message</param>
        public void HandleEvent(CustomerPasswordChangedEvent eventMessage)
        {
            Remove(_cacheKeyService.PrepareKey(SmiCustomerServicesDefaults.CustomerPasswordLifetimeCacheKey, eventMessage.Password.CustomerId));
        }

        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(Customer entity)
        {
            RemoveByPrefix(SmiCustomerServicesDefaults.CustomerCustomerRolesPrefixCacheKey);
            RemoveByPrefix(SmiCustomerServicesDefaults.CustomerAddressesPrefixCacheKey);
            RemoveByPrefix(SmiOrderDefaults.ShoppingCartPrefixCacheKey);
        }

        #endregion
    }
}