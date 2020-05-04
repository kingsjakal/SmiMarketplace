using Smi.Core.Domain.Directory;
using Smi.Services.Caching;

namespace Smi.Services.Directory.Caching
{
    /// <summary>
    /// Represents a currency cache event consumer
    /// </summary>
    public partial class CurrencyCacheEventConsumer : CacheEventConsumer<Currency>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(Currency entity)
        {
            RemoveByPrefix(SmiDirectoryDefaults.CurrenciesAllPrefixCacheKey);
        }
    }
}
