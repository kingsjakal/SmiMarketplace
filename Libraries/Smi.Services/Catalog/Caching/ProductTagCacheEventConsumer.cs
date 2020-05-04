using Smi.Core.Domain.Catalog;
using Smi.Services.Caching;

namespace Smi.Services.Catalog.Caching
{
    /// <summary>
    /// Represents a product tag cache event consumer
    /// </summary>
    public partial class ProductTagCacheEventConsumer : CacheEventConsumer<ProductTag>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(ProductTag entity)
        {
            RemoveByPrefix(SmiCatalogDefaults.ProductTagPrefixCacheKey);
        }
    }
}
