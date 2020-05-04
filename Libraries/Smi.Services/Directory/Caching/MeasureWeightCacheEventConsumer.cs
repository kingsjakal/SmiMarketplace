using Smi.Core.Domain.Directory;
using Smi.Services.Caching;

namespace Smi.Services.Directory.Caching
{
    /// <summary>
    /// Represents a measure weight cache event consumer
    /// </summary>
    public partial class MeasureWeightCacheEventConsumer : CacheEventConsumer<MeasureWeight>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(MeasureWeight entity)
        {
            Remove(SmiDirectoryDefaults.MeasureWeightsAllCacheKey);
        }
    }
}
