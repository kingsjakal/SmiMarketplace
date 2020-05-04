using Smi.Core.Domain.Directory;
using Smi.Services.Caching;

namespace Smi.Services.Directory.Caching
{
    /// <summary>
    /// Represents a country cache event consumer
    /// </summary>
    public partial class CountryCacheEventConsumer : CacheEventConsumer<Country>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(Country entity)
        {
            RemoveByPrefix(SmiDirectoryDefaults.CountriesPrefixCacheKey);
        }
    }
}