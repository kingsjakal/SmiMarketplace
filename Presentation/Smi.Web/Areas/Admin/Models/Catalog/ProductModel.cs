using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smi.Web.Areas.Admin.Models.Settings;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a product model
    /// </summary>
    public partial class ProductModel : BaseSmiEntityModel, 
        IAclSupportedModel, IDiscountSupportedModel, ILocalizedModel<ProductLocalizedModel>, IStoreMappingSupportedModel
    {
        #region Ctor

        public ProductModel()
        {
            ProductPictureModels = new List<ProductPictureModel>();
            Locales = new List<ProductLocalizedModel>();
            CopyProductModel = new CopyProductModel();
            AddPictureModel = new ProductPictureModel();
            ProductWarehouseInventoryModels = new List<ProductWarehouseInventoryModel>();
            ProductEditorSettingsModel = new ProductEditorSettingsModel();
            StockQuantityHistory = new StockQuantityHistoryModel();

            AvailableBasepriceUnits = new List<SelectListItem>();
            AvailableBasepriceBaseUnits = new List<SelectListItem>();
            AvailableProductTemplates = new List<SelectListItem>();
            AvailableTaxCategories = new List<SelectListItem>();
            AvailableDeliveryDates = new List<SelectListItem>();
            AvailableProductAvailabilityRanges = new List<SelectListItem>();
            AvailableWarehouses = new List<SelectListItem>();
            ProductsTypesSupportedByProductTemplates = new Dictionary<int, IList<SelectListItem>>();

            AvailableVendors = new List<SelectListItem>();

            SelectedStoreIds = new List<int>();
            AvailableStores = new List<SelectListItem>();

            SelectedManufacturerIds = new List<int>();
            AvailableManufacturers = new List<SelectListItem>();

            SelectedCategoryIds = new List<int>();
            AvailableCategories = new List<SelectListItem>();

            SelectedCustomerRoleIds = new List<int>();
            AvailableCustomerRoles = new List<SelectListItem>();

            SelectedDiscountIds = new List<int>();
            AvailableDiscounts = new List<SelectListItem>();

            RelatedProductSearchModel = new RelatedProductSearchModel();
            CrossSellProductSearchModel = new CrossSellProductSearchModel();
            AssociatedProductSearchModel = new AssociatedProductSearchModel();
            ProductPictureSearchModel = new ProductPictureSearchModel();
            ProductSpecificationAttributeSearchModel = new ProductSpecificationAttributeSearchModel();
            ProductOrderSearchModel = new ProductOrderSearchModel();
            TierPriceSearchModel = new TierPriceSearchModel();
            StockQuantityHistorySearchModel = new StockQuantityHistorySearchModel();
            ProductAttributeMappingSearchModel = new ProductAttributeMappingSearchModel();
            ProductAttributeCombinationSearchModel = new ProductAttributeCombinationSearchModel();
        }

        #endregion

        #region Properties
        
        //picture thumbnail
        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.PictureThumbnailUrl")]
        public string PictureThumbnailUrl { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.ProductType")]
        public int ProductTypeId { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.ProductType")]
        public string ProductTypeName { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.AssociatedToProductName")]
        public int AssociatedToProductId { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.AssociatedToProductName")]
        public string AssociatedToProductName { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.VisibleIndividually")]
        public bool VisibleIndividually { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.ProductTemplate")]
        public int ProductTemplateId { get; set; }
        public IList<SelectListItem> AvailableProductTemplates { get; set; }

        //<product type ID, list of supported product template IDs>
        public Dictionary<int, IList<SelectListItem>> ProductsTypesSupportedByProductTemplates { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.ShortDescription")]
        public string ShortDescription { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.FullDescription")]
        public string FullDescription { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.AdminComment")]
        public string AdminComment { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.ShowOnHomepage")]
        public bool ShowOnHomepage { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.MetaKeywords")]
        public string MetaKeywords { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.MetaDescription")]
        public string MetaDescription { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.MetaTitle")]
        public string MetaTitle { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.SeName")]
        public string SeName { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.AllowCustomerReviews")]
        public bool AllowCustomerReviews { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.ProductTags")]
        public string ProductTags { get; set; }

        public string InitialProductTags { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.Sku")]
        public string Sku { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.ManufacturerPartNumber")]
        public string ManufacturerPartNumber { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.GTIN")]
        public virtual string Gtin { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.IsGiftCard")]
        public bool IsGiftCard { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.GiftCardType")]
        public int GiftCardTypeId { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.OverriddenGiftCardAmount")]
        [UIHint("DecimalNullable")]
        public decimal? OverriddenGiftCardAmount { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.RequireOtherProducts")]
        public bool RequireOtherProducts { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.RequiredProductIds")]
        public string RequiredProductIds { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.AutomaticallyAddRequiredProducts")]
        public bool AutomaticallyAddRequiredProducts { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.IsDownload")]
        public bool IsDownload { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.Download")]
        [UIHint("Download")]
        public int DownloadId { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.UnlimitedDownloads")]
        public bool UnlimitedDownloads { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.MaxNumberOfDownloads")]
        public int MaxNumberOfDownloads { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.DownloadExpirationDays")]
        [UIHint("Int32Nullable")]
        public int? DownloadExpirationDays { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.DownloadActivationType")]
        public int DownloadActivationTypeId { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.HasSampleDownload")]
        public bool HasSampleDownload { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.SampleDownload")]
        [UIHint("Download")]
        public int SampleDownloadId { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.HasUserAgreement")]
        public bool HasUserAgreement { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.UserAgreementText")]
        public string UserAgreementText { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.IsRecurring")]
        public bool IsRecurring { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.RecurringCycleLength")]
        public int RecurringCycleLength { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.RecurringCyclePeriod")]
        public int RecurringCyclePeriodId { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.RecurringTotalCycles")]
        public int RecurringTotalCycles { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.IsRental")]
        public bool IsRental { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.RentalPriceLength")]
        public int RentalPriceLength { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.RentalPricePeriod")]
        public int RentalPricePeriodId { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.IsShipEnabled")]
        public bool IsShipEnabled { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.IsFreeShipping")]
        public bool IsFreeShipping { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.ShipSeparately")]
        public bool ShipSeparately { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.AdditionalShippingCharge")]
        public decimal AdditionalShippingCharge { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.DeliveryDate")]
        public int DeliveryDateId { get; set; }
        public IList<SelectListItem> AvailableDeliveryDates { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.IsTaxExempt")]
        public bool IsTaxExempt { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.TaxCategory")]
        public int TaxCategoryId { get; set; }
        public IList<SelectListItem> AvailableTaxCategories { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.IsTelecommunicationsOrBroadcastingOrElectronicServices")]
        public bool IsTelecommunicationsOrBroadcastingOrElectronicServices { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.ManageInventoryMethod")]
        public int ManageInventoryMethodId { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.ProductAvailabilityRange")]
        public int ProductAvailabilityRangeId { get; set; }
        public IList<SelectListItem> AvailableProductAvailabilityRanges { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.UseMultipleWarehouses")]
        public bool UseMultipleWarehouses { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.Warehouse")]
        public int WarehouseId { get; set; }
        public IList<SelectListItem> AvailableWarehouses { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.StockQuantity")]
        public int StockQuantity { get; set; }

        public int LastStockQuantity { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.StockQuantity")]
        public string StockQuantityStr { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.DisplayStockAvailability")]
        public bool DisplayStockAvailability { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.DisplayStockQuantity")]
        public bool DisplayStockQuantity { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.MinStockQuantity")]
        public int MinStockQuantity { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.LowStockActivity")]
        public int LowStockActivityId { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.NotifyAdminForQuantityBelow")]
        public int NotifyAdminForQuantityBelow { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.BackorderMode")]
        public int BackorderModeId { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.AllowBackInStockSubscriptions")]
        public bool AllowBackInStockSubscriptions { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.OrderMinimumQuantity")]
        public int OrderMinimumQuantity { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.OrderMaximumQuantity")]
        public int OrderMaximumQuantity { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.AllowedQuantities")]
        public string AllowedQuantities { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.AllowAddingOnlyExistingAttributeCombinations")]
        public bool AllowAddingOnlyExistingAttributeCombinations { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.NotReturnable")]
        public bool NotReturnable { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.DisableBuyButton")]
        public bool DisableBuyButton { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.DisableWishlistButton")]
        public bool DisableWishlistButton { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.AvailableForPreOrder")]
        public bool AvailableForPreOrder { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.PreOrderAvailabilityStartDateTimeUtc")]
        [UIHint("DateTimeNullable")]
        public DateTime? PreOrderAvailabilityStartDateTimeUtc { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.CallForPrice")]
        public bool CallForPrice { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.Price")]
        public decimal Price { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.OldPrice")]
        public decimal OldPrice { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.ProductCost")]
        public decimal ProductCost { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.CustomerEntersPrice")]
        public bool CustomerEntersPrice { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.MinimumCustomerEnteredPrice")]
        public decimal MinimumCustomerEnteredPrice { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.MaximumCustomerEnteredPrice")]
        public decimal MaximumCustomerEnteredPrice { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.BasepriceEnabled")]
        public bool BasepriceEnabled { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.BasepriceAmount")]
        public decimal BasepriceAmount { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.BasepriceUnit")]
        public int BasepriceUnitId { get; set; }
        public IList<SelectListItem> AvailableBasepriceUnits { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.BasepriceBaseAmount")]
        public decimal BasepriceBaseAmount { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.BasepriceBaseUnit")]
        public int BasepriceBaseUnitId { get; set; }
        public IList<SelectListItem> AvailableBasepriceBaseUnits { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.MarkAsNew")]
        public bool MarkAsNew { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.MarkAsNewStartDateTimeUtc")]
        [UIHint("DateTimeNullable")]
        public DateTime? MarkAsNewStartDateTimeUtc { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.MarkAsNewEndDateTimeUtc")]
        [UIHint("DateTimeNullable")]
        public DateTime? MarkAsNewEndDateTimeUtc { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.Weight")]
        public decimal Weight { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.Length")]
        public decimal Length { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.Width")]
        public decimal Width { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.Height")]
        public decimal Height { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.AvailableStartDateTime")]
        [UIHint("DateTimeNullable")]
        public DateTime? AvailableStartDateTimeUtc { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.AvailableEndDateTime")]
        [UIHint("DateTimeNullable")]
        public DateTime? AvailableEndDateTimeUtc { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.Published")]
        public bool Published { get; set; }

        public string PrimaryStoreCurrencyCode { get; set; }

        public string BaseDimensionIn { get; set; }

        public string BaseWeightIn { get; set; }

        public IList<ProductLocalizedModel> Locales { get; set; }

        //ACL (customer roles)
        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.AclCustomerRoles")]
        public IList<int> SelectedCustomerRoleIds { get; set; }
        public IList<SelectListItem> AvailableCustomerRoles { get; set; }

        //store mapping
        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.LimitedToStores")]
        public IList<int> SelectedStoreIds { get; set; }
        public IList<SelectListItem> AvailableStores { get; set; }

        //categories
        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.Categories")]
        public IList<int> SelectedCategoryIds { get; set; }
        public IList<SelectListItem> AvailableCategories { get; set; }

        //manufacturers
        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.Manufacturers")]
        public IList<int> SelectedManufacturerIds { get; set; }
        public IList<SelectListItem> AvailableManufacturers { get; set; }

        //vendors
        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.Vendor")]
        public int VendorId { get; set; }
        public IList<SelectListItem> AvailableVendors { get; set; }

        //discounts
        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.Discounts")]
        public IList<int> SelectedDiscountIds { get; set; }
        public IList<SelectListItem> AvailableDiscounts { get; set; }

        //vendor
        public bool IsLoggedInAsVendor { get; set; }

        //pictures
        public ProductPictureModel AddPictureModel { get; set; }
        public IList<ProductPictureModel> ProductPictureModels { get; set; }

        //product attributes
        public bool ProductAttributesExist { get; set; }

        //multiple warehouses
        [SmiResourceDisplayName("Admin.Catalog.Products.ProductWarehouseInventory")]
        public IList<ProductWarehouseInventoryModel> ProductWarehouseInventoryModels { get; set; }

        //specification attributes
        public bool HasAvailableSpecificationAttributes { get; set; }

        //copy product
        public CopyProductModel CopyProductModel { get; set; }

        //editor settings
        public ProductEditorSettingsModel ProductEditorSettingsModel { get; set; }

        //stock quantity history
        public StockQuantityHistoryModel StockQuantityHistory { get; set; }

        public RelatedProductSearchModel RelatedProductSearchModel { get; set; }

        public CrossSellProductSearchModel CrossSellProductSearchModel { get; set; }

        public AssociatedProductSearchModel AssociatedProductSearchModel { get; set; }

        public ProductPictureSearchModel ProductPictureSearchModel { get; set; }

        public ProductSpecificationAttributeSearchModel ProductSpecificationAttributeSearchModel { get; set; }

        public ProductOrderSearchModel ProductOrderSearchModel { get; set; }

        public TierPriceSearchModel TierPriceSearchModel { get; set; }

        public StockQuantityHistorySearchModel StockQuantityHistorySearchModel { get; set; }

        public ProductAttributeMappingSearchModel ProductAttributeMappingSearchModel { get; set; }

        public ProductAttributeCombinationSearchModel ProductAttributeCombinationSearchModel { get; set; }

        #endregion
    }

    public partial class ProductLocalizedModel : ILocalizedLocaleModel
    {
        public int LanguageId { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.ShortDescription")]
        public string ShortDescription { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.FullDescription")]
        public string FullDescription { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.MetaKeywords")]
        public string MetaKeywords { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.MetaDescription")]
        public string MetaDescription { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.MetaTitle")]
        public string MetaTitle { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.SeName")]
        public string SeName { get; set; }
    }
}