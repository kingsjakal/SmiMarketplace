using Smi.Core.Domain.Common;
using Smi.Services.Caching;
using Smi.Services.Customers;

namespace Smi.Services.Common.Caching
{
    /// <summary>
    /// Represents a address cache event consumer
    /// </summary>
    public partial class AddressCacheEventConsumer : CacheEventConsumer<Address>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(Address entity)
        {
            RemoveByPrefix(SmiCustomerServicesDefaults.CustomerAddressesPrefixCacheKey);
        }
    }
}
