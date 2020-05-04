using Smi.Core.Domain.Catalog;
using Smi.Services.Caching;

namespace Smi.Services.Catalog.Caching
{
    /// <summary>
    /// Represents a review type cache event consumer
    /// </summary>
    public partial class ReviewTypeCacheEventConsumer : CacheEventConsumer<ReviewType>
    {
        /// <summary>
        /// entity
        /// </summary>
        /// <param name="entity">Entity</param>
        /// <param name="entityEventType">Entity event type</param>
        protected override void ClearCache(ReviewType entity, EntityEventType entityEventType)
        {
            if (entityEventType == EntityEventType.Delete)
                RemoveByPrefix(SmiCatalogDefaults.ProductReviewReviewTypeMappingAllPrefixCacheKey);

            Remove(SmiCatalogDefaults.ReviewTypeAllCacheKey);
        }
    }
}
