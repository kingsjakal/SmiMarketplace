using Smi.Core.Caching;

namespace Smi.Services.Tax
{
    /// <summary>
    /// Represents default values related to tax services
    /// </summary>
    public static partial class SmiTaxDefaults
    {
        #region Caching defaults

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        public static CacheKey TaxCategoriesAllCacheKey => new CacheKey("Smi.taxcategory.all");

        #endregion
    }
}