﻿using Smi.Core.Caching;

namespace Smi.Services.Orders
{
    /// <summary>
    /// Represents default values related to orders services
    /// </summary>
    public static partial class SmiOrderDefaults
    {
        #region Caching defaults

        #region Checkout attributes

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// {0} : store ID
        /// {1} : A value indicating whether we should exclude shippable attributes
        /// </remarks>
        public static CacheKey CheckoutAttributesAllCacheKey => new CacheKey("Smi.checkoutattribute.all-{0}-{1}", CheckoutAttributesAllPrefixCacheKey);

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        public static string CheckoutAttributesAllPrefixCacheKey => "Smi.checkoutattribute.all";

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// {0} : checkout attribute ID
        /// </remarks>
        public static CacheKey CheckoutAttributeValuesAllCacheKey => new CacheKey("Smi.checkoutattributevalue.all-{0}");

        #endregion

        #region ShoppingCart

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// {0} : customer ID
        /// {1} : shopping cart type
        /// {2} : store ID
        /// {3} : product ID
        /// {4} : created from date
        /// {5} : created to date
        /// </remarks>
        public static CacheKey ShoppingCartCacheKey => new CacheKey("Smi.shoppingcart-{0}-{1}-{2}-{3}-{4}-{5}", ShoppingCartPrefixCacheKey);

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        public static string ShoppingCartPrefixCacheKey => "Smi.shoppingcart";

        #endregion

        #region Return requests

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// </remarks>
        public static CacheKey ReturnRequestReasonAllCacheKey => new CacheKey("Smi.returnrequestreason.all");

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// </remarks>
        public static CacheKey ReturnRequestActionAllCacheKey => new CacheKey("Smi.returnrequestactions.all");

        #endregion

        #endregion
    }
}