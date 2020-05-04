using Smi.Core.Caching;

namespace Smi.Services.Shipping
{
    /// <summary>
    /// Represents default values related to shipping services
    /// </summary>
    public static partial class SmiShippingDefaults
    {
        #region Caching defaults

        #region Shipping methods

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// {0} : country identifier
        /// </remarks>
        public static CacheKey ShippingMethodsAllCacheKey => new CacheKey("Smi.shippingmethod.all-{0}", ShippingMethodsAllPrefixCacheKey);

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        public static string ShippingMethodsAllPrefixCacheKey => "Smi.shippingmethod.all";

        #endregion

        #region Warehouses

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// </remarks>
        public static CacheKey WarehousesAllCacheKey => new CacheKey("Smi.warehouse.all");

        #endregion

        #region Date

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// </remarks>
        public static CacheKey DeliveryDatesAllCacheKey => new CacheKey("Smi.deliverydates.all");

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// </remarks>
        public static CacheKey ProductAvailabilityAllCacheKey => new CacheKey("Smi.productavailability.all");

        #endregion

        #endregion
    }
}