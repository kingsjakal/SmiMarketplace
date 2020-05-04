using Smi.Core.Caching;
using Smi.Core.Domain.Blogs;
using Smi.Core.Domain.Catalog;
using Smi.Core.Domain.Configuration;
using Smi.Core.Domain.Localization;
using Smi.Core.Domain.Media;
using Smi.Core.Domain.News;
using Smi.Core.Domain.Orders;
using Smi.Core.Domain.Polls;
using Smi.Core.Domain.Topics;
using Smi.Core.Domain.Vendors;
using Smi.Core.Events;
using Smi.Services.Cms;
using Smi.Services.Events;
using Smi.Services.Plugins;

namespace Smi.Web.Infrastructure.Cache
{
    /// <summary>
    /// Model cache event consumer (used for caching of presentation layer models)
    /// </summary>
    public partial class ModelCacheEventConsumer :
        //languages
        IConsumer<EntityInsertedEvent<Language>>,
        IConsumer<EntityUpdatedEvent<Language>>,
        IConsumer<EntityDeletedEvent<Language>>,
        //settings
        IConsumer<EntityUpdatedEvent<Setting>>,
        //manufacturers
        IConsumer<EntityInsertedEvent<Manufacturer>>,
        IConsumer<EntityUpdatedEvent<Manufacturer>>,
        IConsumer<EntityDeletedEvent<Manufacturer>>,
        //vendors
        IConsumer<EntityInsertedEvent<Vendor>>,
        IConsumer<EntityUpdatedEvent<Vendor>>,
        IConsumer<EntityDeletedEvent<Vendor>>,
        //product manufacturers
        IConsumer<EntityInsertedEvent<ProductManufacturer>>,
        IConsumer<EntityUpdatedEvent<ProductManufacturer>>,
        IConsumer<EntityDeletedEvent<ProductManufacturer>>,
        //categories
        IConsumer<EntityInsertedEvent<Category>>,
        IConsumer<EntityUpdatedEvent<Category>>,
        IConsumer<EntityDeletedEvent<Category>>,
        //product categories
        IConsumer<EntityInsertedEvent<ProductCategory>>,
        IConsumer<EntityUpdatedEvent<ProductCategory>>,
        IConsumer<EntityDeletedEvent<ProductCategory>>,
        //products
        IConsumer<EntityInsertedEvent<Product>>,
        IConsumer<EntityUpdatedEvent<Product>>,
        IConsumer<EntityDeletedEvent<Product>>,
        //product tags
        IConsumer<EntityInsertedEvent<ProductTag>>,
        IConsumer<EntityUpdatedEvent<ProductTag>>,
        IConsumer<EntityDeletedEvent<ProductTag>>,
        //specification attributes
        IConsumer<EntityUpdatedEvent<SpecificationAttribute>>,
        IConsumer<EntityDeletedEvent<SpecificationAttribute>>,
        //specification attribute options
        IConsumer<EntityUpdatedEvent<SpecificationAttributeOption>>,
        IConsumer<EntityDeletedEvent<SpecificationAttributeOption>>,
        //Product specification attribute
        IConsumer<EntityInsertedEvent<ProductSpecificationAttribute>>,
        IConsumer<EntityUpdatedEvent<ProductSpecificationAttribute>>,
        IConsumer<EntityDeletedEvent<ProductSpecificationAttribute>>,
        //Product attribute values
        IConsumer<EntityUpdatedEvent<ProductAttributeValue>>,
        //Topics
        IConsumer<EntityInsertedEvent<Topic>>,
        IConsumer<EntityUpdatedEvent<Topic>>,
        IConsumer<EntityDeletedEvent<Topic>>,
        //Orders
        IConsumer<EntityInsertedEvent<Order>>,
        IConsumer<EntityUpdatedEvent<Order>>,
        IConsumer<EntityDeletedEvent<Order>>,
        //Picture
        IConsumer<EntityInsertedEvent<Picture>>,
        IConsumer<EntityUpdatedEvent<Picture>>,
        IConsumer<EntityDeletedEvent<Picture>>,
        //Product picture mapping
        IConsumer<EntityInsertedEvent<ProductPicture>>,
        IConsumer<EntityUpdatedEvent<ProductPicture>>,
        IConsumer<EntityDeletedEvent<ProductPicture>>,
        //Product review
        IConsumer<EntityDeletedEvent<ProductReview>>,
        //polls
        IConsumer<EntityInsertedEvent<Poll>>,
        IConsumer<EntityUpdatedEvent<Poll>>,
        IConsumer<EntityDeletedEvent<Poll>>,
        //blog posts
        IConsumer<EntityInsertedEvent<BlogPost>>,
        IConsumer<EntityUpdatedEvent<BlogPost>>,
        IConsumer<EntityDeletedEvent<BlogPost>>,
        //news items
        IConsumer<EntityInsertedEvent<NewsItem>>,
        IConsumer<EntityUpdatedEvent<NewsItem>>,
        IConsumer<EntityDeletedEvent<NewsItem>>,
        //shopping cart items
        IConsumer<EntityUpdatedEvent<ShoppingCartItem>>,
        //plugins
        IConsumer<PluginUpdatedEvent>
    {
        #region Fields

        private readonly CatalogSettings _catalogSettings;
        private readonly IStaticCacheManager _staticCacheManager;

        #endregion

        #region Ctor

        public ModelCacheEventConsumer(CatalogSettings catalogSettings, IStaticCacheManager staticCacheManager)
        {
            _staticCacheManager = staticCacheManager;
            _catalogSettings = catalogSettings;
        }

        #endregion

        #region Methods

        #region Languages

        public void HandleEvent(EntityInsertedEvent<Language> eventMessage)
        {
            //clear all localizable models
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.ManufacturerNavigationPrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.SpecsFilterPrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.CategoryAllPrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.CategoryXmlAllPrefixCacheKey);
        }

        public void HandleEvent(EntityUpdatedEvent<Language> eventMessage)
        {
            //clear all localizable models
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.ManufacturerNavigationPrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.SpecsFilterPrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.CategoryAllPrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.CategoryXmlAllPrefixCacheKey);
        }

        public void HandleEvent(EntityDeletedEvent<Language> eventMessage)
        {
            //clear all localizable models
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.ManufacturerNavigationPrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.SpecsFilterPrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.CategoryAllPrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.CategoryXmlAllPrefixCacheKey);
        }

        #endregion
        
        #region Setting

        public void HandleEvent(EntityUpdatedEvent<Setting> eventMessage)
        {
            //clear models which depend on settings
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.ManufacturerNavigationPrefixCacheKey); //depends on CatalogSettings.ManufacturersBlockItemsToDisplay
            _staticCacheManager.Remove(SmiModelCacheDefaults.VendorNavigationModelKey); //depends on VendorSettings.VendorBlockItemsToDisplay
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.CategoryAllPrefixCacheKey); //depends on CatalogSettings.ShowCategoryProductNumber and CatalogSettings.ShowCategoryProductNumberIncludingSubcategories
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.CategoryXmlAllPrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.HomepageBestsellersIdsPrefixCacheKey); //depends on CatalogSettings.NumberOfBestsellersOnHomepage
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.ProductsAlsoPurchasedIdsPrefixCacheKey); //depends on CatalogSettings.ProductsAlsoPurchasedNumber
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.BlogPrefixCacheKey); //depends on BlogSettings.NumberOfTags
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.NewsPrefixCacheKey); //depends on NewsSettings.MainPageNewsCount
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.SitemapPrefixCacheKey); //depends on distinct sitemap settings
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.WidgetPrefixCacheKey); //depends on WidgetSettings and certain settings of widgets
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.StoreLogoPathPrefixCacheKey); //depends on StoreInformationSettings.LogoPictureId
        }

        #endregion

        #region Vendors

        public void HandleEvent(EntityInsertedEvent<Vendor> eventMessage)
        {
            _staticCacheManager.Remove(SmiModelCacheDefaults.VendorNavigationModelKey);
        }

        public void HandleEvent(EntityUpdatedEvent<Vendor> eventMessage)
        {
            _staticCacheManager.Remove(SmiModelCacheDefaults.VendorNavigationModelKey);
            _staticCacheManager.RemoveByPrefix(string.Format(SmiModelCacheDefaults.VendorPicturePrefixCacheKeyById, eventMessage.Entity.Id));
        }

        public void HandleEvent(EntityDeletedEvent<Vendor> eventMessage)
        {
            _staticCacheManager.Remove(SmiModelCacheDefaults.VendorNavigationModelKey);
        }

        #endregion

        #region  Manufacturers

        public void HandleEvent(EntityInsertedEvent<Manufacturer> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.ManufacturerNavigationPrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.SitemapPrefixCacheKey);
        }

        public void HandleEvent(EntityUpdatedEvent<Manufacturer> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.ManufacturerNavigationPrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.SitemapPrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(string.Format(SmiModelCacheDefaults.ManufacturerPicturePrefixCacheKeyById, eventMessage.Entity.Id));
        }

        public void HandleEvent(EntityDeletedEvent<Manufacturer> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.ManufacturerNavigationPrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.SitemapPrefixCacheKey);
        }

        #endregion

        #region  Product manufacturers

        public void HandleEvent(EntityInsertedEvent<ProductManufacturer> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(string.Format(SmiModelCacheDefaults.ManufacturerHasFeaturedProductsPrefixCacheKeyById, eventMessage.Entity.ManufacturerId));
        }

        public void HandleEvent(EntityUpdatedEvent<ProductManufacturer> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(string.Format(SmiModelCacheDefaults.ManufacturerHasFeaturedProductsPrefixCacheKeyById, eventMessage.Entity.ManufacturerId));
        }

        public void HandleEvent(EntityDeletedEvent<ProductManufacturer> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(string.Format(SmiModelCacheDefaults.ManufacturerHasFeaturedProductsPrefixCacheKeyById, eventMessage.Entity.ManufacturerId));
        }

        #endregion

        #region Categories

        public void HandleEvent(EntityInsertedEvent<Category> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.CategoryAllPrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.CategoryXmlAllPrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.CategoryHomepagePrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.SitemapPrefixCacheKey);
        }

        public void HandleEvent(EntityUpdatedEvent<Category> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.CategoryAllPrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.CategoryXmlAllPrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.CategoryHomepagePrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.SitemapPrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(string.Format(SmiModelCacheDefaults.CategoryPicturePrefixCacheKeyById, eventMessage.Entity.Id));
        }

        public void HandleEvent(EntityDeletedEvent<Category> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.CategoryAllPrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.CategoryXmlAllPrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.CategoryHomepagePrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.SitemapPrefixCacheKey);
        }

        #endregion

        #region Product categories

        public void HandleEvent(EntityInsertedEvent<ProductCategory> eventMessage)
        {
            if (_catalogSettings.ShowCategoryProductNumber)
            {
                //depends on CatalogSettings.ShowCategoryProductNumber (when enabled)
                //so there's no need to clear this cache in other cases
                _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.CategoryAllPrefixCacheKey);
                _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.CategoryXmlAllPrefixCacheKey);
            }

            _staticCacheManager.RemoveByPrefix(string.Format(SmiModelCacheDefaults.CategoryHasFeaturedProductsPrefixCacheKeyById, eventMessage.Entity.CategoryId));
        }

        public void HandleEvent(EntityUpdatedEvent<ProductCategory> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(string.Format(SmiModelCacheDefaults.CategoryHasFeaturedProductsPrefixCacheKeyById, eventMessage.Entity.CategoryId));
        }

        public void HandleEvent(EntityDeletedEvent<ProductCategory> eventMessage)
        {
            if (_catalogSettings.ShowCategoryProductNumber)
            {
                //depends on CatalogSettings.ShowCategoryProductNumber (when enabled)
                //so there's no need to clear this cache in other cases
                _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.CategoryAllPrefixCacheKey);
                _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.CategoryXmlAllPrefixCacheKey);
            }

            _staticCacheManager.RemoveByPrefix(string.Format(SmiModelCacheDefaults.CategoryHasFeaturedProductsPrefixCacheKeyById, eventMessage.Entity.CategoryId));
        }

        #endregion

        #region Products

        public void HandleEvent(EntityInsertedEvent<Product> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.SitemapPrefixCacheKey);
        }

        public void HandleEvent(EntityUpdatedEvent<Product> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.HomepageBestsellersIdsPrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.ProductsAlsoPurchasedIdsPrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.SitemapPrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(string.Format(SmiModelCacheDefaults.ProductReviewsPrefixCacheKeyById, eventMessage.Entity.Id));
        }

        public void HandleEvent(EntityDeletedEvent<Product> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.HomepageBestsellersIdsPrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.ProductsAlsoPurchasedIdsPrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.SitemapPrefixCacheKey);
        }

        #endregion

        #region Product tags

        public void HandleEvent(EntityInsertedEvent<ProductTag> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.SitemapPrefixCacheKey);
        }

        public void HandleEvent(EntityUpdatedEvent<ProductTag> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.SitemapPrefixCacheKey);
        }

        public void HandleEvent(EntityDeletedEvent<ProductTag> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.SitemapPrefixCacheKey);
        }

        #endregion

        #region Specification attributes

        public void HandleEvent(EntityUpdatedEvent<SpecificationAttribute> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.SpecsFilterPrefixCacheKey);
        }

        public void HandleEvent(EntityDeletedEvent<SpecificationAttribute> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.SpecsFilterPrefixCacheKey);
        }

        #endregion

        #region Specification attribute options

        public void HandleEvent(EntityUpdatedEvent<SpecificationAttributeOption> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.SpecsFilterPrefixCacheKey);
        }

        public void HandleEvent(EntityDeletedEvent<SpecificationAttributeOption> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.SpecsFilterPrefixCacheKey);
        }

        #endregion

        #region Product specification attribute

        public void HandleEvent(EntityInsertedEvent<ProductSpecificationAttribute> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.SpecsFilterPrefixCacheKey);
        }

        public void HandleEvent(EntityUpdatedEvent<ProductSpecificationAttribute> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.SpecsFilterPrefixCacheKey);
        }

        public void HandleEvent(EntityDeletedEvent<ProductSpecificationAttribute> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.SpecsFilterPrefixCacheKey);
        }

        #endregion

        #region Product attributes

        public void HandleEvent(EntityUpdatedEvent<ProductAttributeValue> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.ProductAttributePicturePrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.ProductAttributeImageSquarePicturePrefixCacheKey);
        }

        #endregion

        #region Topics

        public void HandleEvent(EntityInsertedEvent<Topic> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.SitemapPrefixCacheKey);
        }

        public void HandleEvent(EntityUpdatedEvent<Topic> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.SitemapPrefixCacheKey);
        }

        public void HandleEvent(EntityDeletedEvent<Topic> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.SitemapPrefixCacheKey);
        }

        #endregion

        #region Orders

        public void HandleEvent(EntityInsertedEvent<Order> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.HomepageBestsellersIdsPrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.ProductsAlsoPurchasedIdsPrefixCacheKey);
        }

        public void HandleEvent(EntityUpdatedEvent<Order> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.HomepageBestsellersIdsPrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.ProductsAlsoPurchasedIdsPrefixCacheKey);
        }

        public void HandleEvent(EntityDeletedEvent<Order> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.HomepageBestsellersIdsPrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.ProductsAlsoPurchasedIdsPrefixCacheKey);
        }

        #endregion

        #region Pictures

        public void HandleEvent(EntityInsertedEvent<Picture> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.ProductAttributePicturePrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.CartPicturePrefixCacheKey);
        }

        public void HandleEvent(EntityUpdatedEvent<Picture> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.ProductAttributePicturePrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.CartPicturePrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.ProductDetailsPicturesPrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.ProductDefaultPicturePrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.CategoryPicturePrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.ManufacturerPicturePrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.VendorPicturePrefixCacheKey);
        }

        public void HandleEvent(EntityDeletedEvent<Picture> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.ProductAttributePicturePrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.CartPicturePrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.ProductDetailsPicturesPrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.ProductDefaultPicturePrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.CategoryPicturePrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.ManufacturerPicturePrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.VendorPicturePrefixCacheKey);
        }

        #endregion

        #region Product picture mappings

        public void HandleEvent(EntityInsertedEvent<ProductPicture> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(string.Format(SmiModelCacheDefaults.ProductDefaultPicturePrefixCacheKeyById, eventMessage.Entity.ProductId));
            _staticCacheManager.RemoveByPrefix(string.Format(SmiModelCacheDefaults.ProductDetailsPicturesPrefixCacheKeyById, eventMessage.Entity.ProductId));
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.ProductAttributePicturePrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.CartPicturePrefixCacheKey);
        }

        public void HandleEvent(EntityUpdatedEvent<ProductPicture> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(string.Format(SmiModelCacheDefaults.ProductDefaultPicturePrefixCacheKeyById, eventMessage.Entity.ProductId));
            _staticCacheManager.RemoveByPrefix(string.Format(SmiModelCacheDefaults.ProductDetailsPicturesPrefixCacheKeyById, eventMessage.Entity.ProductId));
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.ProductAttributePicturePrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.CartPicturePrefixCacheKey);
        }

        public void HandleEvent(EntityDeletedEvent<ProductPicture> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(string.Format(SmiModelCacheDefaults.ProductDefaultPicturePrefixCacheKeyById, eventMessage.Entity.ProductId));
            _staticCacheManager.RemoveByPrefix(string.Format(SmiModelCacheDefaults.ProductDetailsPicturesPrefixCacheKeyById, eventMessage.Entity.ProductId));
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.ProductAttributePicturePrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.CartPicturePrefixCacheKey);
        }

        #endregion

        #region Polls

        public void HandleEvent(EntityInsertedEvent<Poll> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.PollsPrefixCacheKey);
        }

        public void HandleEvent(EntityUpdatedEvent<Poll> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.PollsPrefixCacheKey);
        }

        public void HandleEvent(EntityDeletedEvent<Poll> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.PollsPrefixCacheKey);
        }

        #endregion

        #region Blog posts

        public void HandleEvent(EntityInsertedEvent<BlogPost> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.BlogPrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.SitemapPrefixCacheKey);
        }

        public void HandleEvent(EntityUpdatedEvent<BlogPost> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.BlogPrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.SitemapPrefixCacheKey);
        }

        public void HandleEvent(EntityDeletedEvent<BlogPost> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.BlogPrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.SitemapPrefixCacheKey);
        }

        #endregion

        #region News items

        public void HandleEvent(EntityInsertedEvent<NewsItem> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.NewsPrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.SitemapPrefixCacheKey);
        }

        public void HandleEvent(EntityUpdatedEvent<NewsItem> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.NewsPrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.SitemapPrefixCacheKey);
        }

        public void HandleEvent(EntityDeletedEvent<NewsItem> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.NewsPrefixCacheKey);
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.SitemapPrefixCacheKey);
        }

        #endregion
        
        #region Shopping cart items

        public void HandleEvent(EntityUpdatedEvent<ShoppingCartItem> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.CartPicturePrefixCacheKey);
        }

        #endregion

        #region Product reviews

        public void HandleEvent(EntityDeletedEvent<ProductReview> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(string.Format(SmiModelCacheDefaults.ProductReviewsPrefixCacheKeyById, eventMessage.Entity.ProductId));
        }

        #endregion

        #region Plugin

        /// <summary>
        /// Handle plugin updated event
        /// </summary>
        /// <param name="eventMessage">Event message</param>
        public void HandleEvent(PluginUpdatedEvent eventMessage)
        {
            if (eventMessage?.Plugin?.Instance<IWidgetPlugin>() != null)
                _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.WidgetPrefixCacheKey);
        }

        #endregion

        #endregion
    }
}