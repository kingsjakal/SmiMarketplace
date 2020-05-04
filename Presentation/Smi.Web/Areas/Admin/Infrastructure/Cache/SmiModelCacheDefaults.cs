using Smi.Core.Caching;

namespace Smi.Web.Areas.Admin.Infrastructure.Cache
{
    public static partial class SmiModelCacheDefaults
    {
        /// <summary>
        /// Key for SmiMarketplace.com news cache
        /// </summary>
        public static CacheKey OfficialNewsModelKey => new CacheKey("Smi.pres.admin.official.news");
        
        /// <summary>
        /// Key for categories caching
        /// </summary>
        /// <remarks>
        /// {0} : show hidden records?
        /// </remarks>
        public static CacheKey CategoriesListKey => new CacheKey("Smi.pres.admin.categories.list-{0}", CategoriesListPrefixCacheKey);
        public static string CategoriesListPrefixCacheKey => "Smi.pres.admin.categories.list";

        /// <summary>
        /// Key for manufacturers caching
        /// </summary>
        /// <remarks>
        /// {0} : show hidden records?
        /// </remarks>
        public static CacheKey ManufacturersListKey => new CacheKey("Smi.pres.admin.manufacturers.list-{0}", ManufacturersListPrefixCacheKey);
        public static string ManufacturersListPrefixCacheKey => "Smi.pres.admin.manufacturers.list";

        /// <summary>
        /// Key for vendors caching
        /// </summary>
        /// <remarks>
        /// {0} : show hidden records?
        /// </remarks>
        public static CacheKey VendorsListKey => new CacheKey("Smi.pres.admin.vendors.list-{0}", VendorsListPrefixCacheKey);
        public static string VendorsListPrefixCacheKey => "Smi.pres.admin.vendors.list";
    }
}
