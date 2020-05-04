using Smi.Core.Domain.Catalog;
using Smi.Services.Caching;
using Smi.Services.Discounts;

namespace Smi.Services.Catalog.Caching
{
    /// <summary>
    /// Represents a category cache event consumer
    /// </summary>
    public partial class CategoryCacheEventConsumer : CacheEventConsumer<Category>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(Category entity)
        {
            var prefix = _cacheKeyService.PrepareKeyPrefix(SmiCatalogDefaults.CategoriesByParentCategoryPrefixCacheKey, entity);
            RemoveByPrefix(prefix);
            prefix = _cacheKeyService.PrepareKeyPrefix(SmiCatalogDefaults.CategoriesByParentCategoryPrefixCacheKey, entity.ParentCategoryId);
            RemoveByPrefix(prefix);

            prefix = _cacheKeyService.PrepareKeyPrefix(SmiCatalogDefaults.CategoriesChildIdentifiersPrefixCacheKey, entity);
            RemoveByPrefix(prefix);
            prefix = _cacheKeyService.PrepareKeyPrefix(SmiCatalogDefaults.CategoriesChildIdentifiersPrefixCacheKey, entity.ParentCategoryId);
            RemoveByPrefix(prefix);
            
            RemoveByPrefix(SmiCatalogDefaults.CategoriesDisplayedOnHomepagePrefixCacheKey);
            RemoveByPrefix(SmiCatalogDefaults.CategoriesAllPrefixCacheKey);
            RemoveByPrefix(SmiCatalogDefaults.CategoryBreadcrumbPrefixCacheKey);
            
            RemoveByPrefix(SmiCatalogDefaults.CategoryNumberOfProductsPrefixCacheKey);

            RemoveByPrefix(SmiDiscountDefaults.DiscountCategoryIdsPrefixCacheKey);
        }
    }
}
