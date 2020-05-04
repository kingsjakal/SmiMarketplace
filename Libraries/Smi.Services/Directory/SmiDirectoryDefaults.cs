using Smi.Core.Caching;

namespace Smi.Services.Directory
{
    /// <summary>
    /// Represents default values related to directory services
    /// </summary>
    public static partial class SmiDirectoryDefaults
    {
        #region Caching defaults

        #region Countries

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// {0} : Two letter ISO code
        /// </remarks>
        public static CacheKey CountriesByTwoLetterCodeCacheKey => new CacheKey("Smi.country.twoletter-{0}", CountriesPrefixCacheKey);

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// {0} : Two letter ISO code
        /// </remarks>
        public static CacheKey CountriesByThreeLetterCodeCacheKey => new CacheKey("Smi.country.threeletter-{0}", CountriesPrefixCacheKey);

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// {0} : language ID
        /// {1} : show hidden records?
        /// </remarks>
        public static CacheKey CountriesAllCacheKey => new CacheKey("Smi.country.all-{0}-{1}", CountriesPrefixCacheKey);

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        public static string CountriesPrefixCacheKey => "Smi.country.";

        #endregion

        #region Currencies

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// {0} : show hidden records?
        /// </remarks>
        public static CacheKey CurrenciesAllCacheKey => new CacheKey("Smi.currency.all-{0}", CurrenciesAllPrefixCacheKey);

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        public static string CurrenciesAllPrefixCacheKey => "Smi.currency.all";

        #endregion

        #region Measures

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        public static CacheKey MeasureDimensionsAllCacheKey => new CacheKey("Smi.measuredimension.all");

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        public static CacheKey MeasureWeightsAllCacheKey => new CacheKey("Smi.measureweight.all");

        #endregion

        #region States and provinces

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// {0} : country ID
        /// {1} : language ID
        /// {2} : show hidden records?
        /// </remarks>
        public static CacheKey StateProvincesByCountryCacheKey => new CacheKey("Smi.stateprovince.all-{0}-{1}-{2}", StateProvincesPrefixCacheKey);

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// {0} : show hidden records?
        /// </remarks>
        public static CacheKey StateProvincesAllCacheKey => new CacheKey("Smi.stateprovince.all-{0}", StateProvincesPrefixCacheKey);

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// {0} : abbreviation
        /// {1} : country ID
        /// </remarks>
        public static CacheKey StateProvincesByAbbreviationCacheKey => new CacheKey("Smi.stateprovince.abbreviationcountryid-{0}-{1}", StateProvincesPrefixCacheKey);

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        public static string StateProvincesPrefixCacheKey => "Smi.stateprovince.";

        #endregion

        #endregion
    }
}