using Smi.Core.Domain.Orders;
using Smi.Services.Caching;

namespace Smi.Services.Orders.Caching
{
    /// <summary>
    /// Represents a shopping cart item cache event consumer
    /// </summary>
    public partial class ShoppingCartItemCacheEventConsumer : CacheEventConsumer<ShoppingCartItem>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(ShoppingCartItem entity)
        {
            RemoveByPrefix(SmiOrderDefaults.ShoppingCartPrefixCacheKey);
        }
    }
}
