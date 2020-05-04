using Smi.Core.Domain.Directory;
using Smi.Services.Caching;

namespace Smi.Services.Directory.Caching
{
    /// <summary>
    /// Represents a measure dimension cache event consumer
    /// </summary>
    public partial class MeasureDimensionCacheEventConsumer : CacheEventConsumer<MeasureDimension>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(MeasureDimension entity)
        {
            Remove(SmiDirectoryDefaults.MeasureDimensionsAllCacheKey);
        }
    }
}
