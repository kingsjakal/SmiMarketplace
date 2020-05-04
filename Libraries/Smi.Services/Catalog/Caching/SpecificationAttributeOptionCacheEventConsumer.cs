using Smi.Core.Domain.Catalog;
using Smi.Services.Caching;

namespace Smi.Services.Catalog.Caching
{
    /// <summary>
    /// Represents a specification attribute option cache event consumer
    /// </summary>
    public partial class SpecificationAttributeOptionCacheEventConsumer : CacheEventConsumer<SpecificationAttributeOption>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(SpecificationAttributeOption entity)
        {
            Remove(SmiCatalogDefaults.SpecAttributesWithOptionsCacheKey);
            Remove(_cacheKeyService.PrepareKey(SmiCatalogDefaults.SpecAttributesOptionsCacheKey, entity.SpecificationAttributeId));
        }
    }
}
