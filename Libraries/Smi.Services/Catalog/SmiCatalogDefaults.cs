using Smi.Core.Caching;

namespace Smi.Services.Catalog
{
    /// <summary>
    /// Represents default values related to catalog services
    /// </summary>
    public static partial class SmiCatalogDefaults
    {
        #region Products

        /// <summary>
        /// Gets a template of product name on copying
        /// </summary>
        /// <remarks>
        /// {0} : product name
        /// </remarks>
        public static string ProductCopyNameTemplate => "Copy of {0}";

        /// <summary>
        /// Gets default prefix for product
        /// </summary>
        public static string ProductAttributePrefix => "product_attribute_";

        #endregion

        #region Caching defaults

        #region Categories

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// {0} : parent category ID
        /// {1} : show hidden records?
        /// {2} : current customer ID
        /// {3} : store ID
        /// </remarks>
        public static CacheKey CategoriesByParentCategoryIdCacheKey => new CacheKey("Smi.category.byparent-{0}-{1}-{2}-{3}", CategoriesByParentCategoryPrefixCacheKey);

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        /// <remarks>
        /// {0} : parent category ID
        /// </remarks>
        public static string CategoriesByParentCategoryPrefixCacheKey => "Smi.category.byparent-{0}";

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// {0} : parent category id
        /// {1} : roles of the current user
        /// {2} : current store ID
        /// {3} : show hidden records?
        /// </remarks>
        public static CacheKey CategoriesChildIdentifiersCacheKey => new CacheKey("Smi.category.childidentifiers-{0}-{1}-{2}-{3}", CategoriesChildIdentifiersPrefixCacheKey);

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        /// <remarks>
        /// {0} : parent category ID
        /// </remarks>
        public static string CategoriesChildIdentifiersPrefixCacheKey => "Smi.category.childidentifiers-{0}";

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        public static CacheKey CategoriesAllDisplayedOnHomepageCacheKey => new CacheKey("Smi.category.homepage.all", CategoriesDisplayedOnHomepagePrefixCacheKey);

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// {0} : current store ID
        /// {1} : roles of the current user
        /// </remarks>
        public static CacheKey CategoriesDisplayedOnHomepageWithoutHiddenCacheKey => new CacheKey("Smi.category.homepage.withouthidden-{0}-{1}", CategoriesDisplayedOnHomepagePrefixCacheKey);

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        public static string CategoriesDisplayedOnHomepagePrefixCacheKey => "Smi.category.homepage";

        /// <summary>
        /// Key for caching of category breadcrumb
        /// </summary>
        /// <remarks>
        /// {0} : category id
        /// {1} : roles of the current user
        /// {2} : current store ID
        /// {3} : language ID
        /// </remarks>
        public static CacheKey CategoryBreadcrumbCacheKey => new CacheKey("Smi.category.breadcrumb-{0}-{1}-{2}-{3}", CategoryBreadcrumbPrefixCacheKey);

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        public static string CategoryBreadcrumbPrefixCacheKey => "Smi.category.breadcrumb";

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// {0} : current store ID
        /// {1} : roles of the current user
        /// {2} : show hidden records?
        /// </remarks>
        public static CacheKey CategoriesAllCacheKey => new CacheKey("Smi.category.all-{0}-{1}-{2}", CategoriesAllPrefixCacheKey);

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        public static string CategoriesAllPrefixCacheKey => "Smi.category.all";

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// {0} : product ID
        /// {1} : show hidden records?
        /// {2} : current customer ID
        /// {3} : store ID
        /// </remarks>
        public static CacheKey ProductCategoriesAllByProductIdCacheKey => new CacheKey("Smi.productcategory.allbyproductid-{0}-{1}-{2}-{3}", ProductCategoriesByProductPrefixCacheKey);

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        public static string ProductCategoriesByProductPrefixCacheKey => "Smi.productcategory.allbyproductid-{0}";

        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : customer roles ID hash
        /// {1} : current store ID
        /// {2} : categories ID hash
        /// </remarks>
        public static CacheKey CategoryNumberOfProductsCacheKey => new CacheKey("Smi.productcategory.numberofproducts-{0}-{1}-{2}", CategoryNumberOfProductsPrefixCacheKey);

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        public static string CategoryNumberOfProductsPrefixCacheKey => "Smi.productcategory.numberofproducts";

        #endregion

        #region Manufacturers

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// {0} : product ID
        /// {1} : show hidden records?
        /// {2} : current customer ID
        /// {3} : store ID
        /// </remarks>
        public static CacheKey ProductManufacturersAllByProductIdCacheKey => new CacheKey("Smi.productmanufacturer.allbyproductid-{0}-{1}-{2}-{3}", ProductManufacturersByProductPrefixCacheKey);

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        /// <remarks>
        /// {0} : product ID
        /// </remarks>
        public static string ProductManufacturersByProductPrefixCacheKey => "Smi.productmanufacturer.allbyproductid-{0}";

        #endregion

        #region Products

        /// <summary>
        /// Key for "related" product displayed on the product details page
        /// </summary>
        /// <remarks>
        /// {0} : current product id
        /// {1} : show hidden records?
        /// </remarks>
        public static CacheKey ProductsRelatedCacheKey => new CacheKey("Smi.product.related-{0}-{1}", ProductsRelatedPrefixCacheKey);

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        /// <remarks>
        /// {0} : product ID
        /// </remarks>
        public static string ProductsRelatedPrefixCacheKey => "Smi.product.related-{0}";

        /// <summary>
        /// Key for "related" product identifiers displayed on the product details page
        /// </summary>
        /// <remarks>
        /// {0} : current product id
        /// </remarks>
        public static CacheKey ProductTierPricesCacheKey => new CacheKey("Smi.product.tierprices-{0}");

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        public static CacheKey ProductsAllDisplayedOnHomepageCacheKey => new CacheKey("Smi.product.homepage");

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        /// <remarks>
        /// {0} : product IDs hash
        /// </remarks>
        public static CacheKey ProductsByIdsCacheKey => new CacheKey("Smi.product.ids-{0}", ProductsByIdsPrefixCacheKey);

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        public static string ProductsByIdsPrefixCacheKey => "Smi.product.ids";

        /// <summary>
        /// Gets a key for product prices
        /// </summary>
        /// <remarks>
        /// {0} : product id
        /// {1} : overridden product price
        /// {2} : additional charge
        /// {3} : include discounts (true, false)
        /// {4} : quantity
        /// {5} : roles of the current user
        /// {6} : current store ID
        /// </remarks>
        public static CacheKey ProductPriceCacheKey => new CacheKey("Smi.totals.productprice-{0}-{1}-{2}-{3}-{4}-{5}-{6}", ProductPricePrefixCacheKey);

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        /// <remarks>
        /// {0} : product id
        /// </remarks>
        public static string ProductPricePrefixCacheKey => "Smi.totals.productprice-{0}";

        #endregion

        #region Product attributes

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// {0} : product ID
        /// </remarks>
        public static CacheKey ProductAttributeMappingsAllCacheKey => new CacheKey("Smi.productattributemapping.all-{0}", ProductAttributeMappingsPrefixCacheKey);

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        public static string ProductAttributeMappingsPrefixCacheKey => "Smi.productattributemapping.";

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// {0} : product attribute mapping ID
        /// </remarks>
        public static CacheKey ProductAttributeValuesAllCacheKey => new CacheKey("Smi.productattributevalue.all-{0}", ProductAttributeValuesAllPrefixCacheKey);

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        public static string ProductAttributeValuesAllPrefixCacheKey => "Smi.productattributevalue.all";

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// {0} : product ID
        /// </remarks>
        public static CacheKey ProductAttributeCombinationsAllCacheKey => new CacheKey("Smi.productattributecombination.all-{0}", ProductAttributeCombinationsAllPrefixCacheKey);

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        public static string ProductAttributeCombinationsAllPrefixCacheKey => "Smi.productattributecombination.all";

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// {0} : Product attribute ID
        /// </remarks>
        public static CacheKey PredefinedProductAttributeValuesAllCacheKey => new CacheKey("Smi.predefinedproductattributevalues.all-{0}");

        #endregion

        #region Product tags

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        public static CacheKey ProductTagAllCacheKey => new CacheKey("Smi.producttag.all", ProductTagPrefixCacheKey);

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// {0} : store ID
        /// {1} : hash of list of customer roles IDs
        /// {2} : show hidden records?
        /// </remarks>
        public static CacheKey ProductTagCountCacheKey => new CacheKey("Smi.producttag.all.count-{0}-{1}-{2}", ProductTagPrefixCacheKey);

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// {0} : product ID
        /// </remarks>
        public static CacheKey ProductTagAllByProductIdCacheKey => new CacheKey("Smi.producttag.allbyproductid-{0}", ProductTagPrefixCacheKey);

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        public static string ProductTagPrefixCacheKey => "Smi.producttag.";

        #endregion

        #region Review type

        /// <summary>
        /// Key for caching all review types
        /// </summary>
        public static CacheKey ReviewTypeAllCacheKey => new CacheKey("Smi.reviewType.all");

        /// <summary>
        /// Key for caching product review and review type mapping
        /// </summary>
        /// <remarks>
        /// {0} : product review ID
        /// </remarks>
        public static CacheKey ProductReviewReviewTypeMappingAllCacheKey => new CacheKey("Smi.productReviewReviewTypeMapping.all-{0}", ProductReviewReviewTypeMappingAllPrefixCacheKey);

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        public static string ProductReviewReviewTypeMappingAllPrefixCacheKey => "Smi.productReviewReviewTypeMapping.all";

        #endregion

        #region Specification attributes

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        /// <remarks>
        /// {0} : product ID
        /// {1} : specification attribute option ID
        /// {2} : allow filtering
        /// {3} : show on product page
        /// </remarks>
        public static CacheKey ProductSpecificationAttributeAllByProductIdCacheKey => new CacheKey("Smi.productspecificationattribute.allbyproductid-{0}-{1}-{2}-{3}", ProductSpecificationAttributeAllByProductPrefixCacheKey);

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        /// <remarks>
        /// {0} : product ID
        /// </remarks>
        public static string ProductSpecificationAttributeAllByProductPrefixCacheKey => "Smi.Smi.productspecificationattribute.allbyproductid-{0}";

        /// <summary>
        /// Key for specification attributes caching (product details page)
        /// </summary>
        public static CacheKey SpecAttributesWithOptionsCacheKey => new CacheKey("Smi.productspecificationattribute.with.options");

        /// <summary>
        /// Key for specification attributes caching
        /// </summary>
        /// <remarks>
        /// {0} : specification attribute ID
        /// </remarks>
        public static CacheKey SpecAttributesOptionsCacheKey => new CacheKey("Smi.productspecificationattribute.options-{0}");

        #endregion

        #region Category template

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        public static CacheKey CategoryTemplatesAllCacheKey => new CacheKey("Smi.categorytemplate.all");

        #endregion

        #region Manufacturer template

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        public static CacheKey ManufacturerTemplatesAllCacheKey => new CacheKey("Smi.manufacturertemplate.all");

        #endregion

        #region Product template

        /// <summary>
        /// Gets a key for caching
        /// </summary>
        public static CacheKey ProductTemplatesAllCacheKey => new CacheKey("Smi.producttemplates.all");

        #endregion

        #endregion
    }
}