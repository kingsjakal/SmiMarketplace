using Smi.Core.Domain.Media;
using Smi.Services.Caching;

namespace Smi.Services.Media.Caching
{
    /// <summary>
    /// Represents a picture cache event consumer
    /// </summary>
    public partial class PictureCacheEventConsumer : CacheEventConsumer<Picture>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(Picture entity)
        {
            RemoveByPrefix(SmiMediaDefaults.ThumbsExistsPrefixCacheKey);
        }
    }
}
