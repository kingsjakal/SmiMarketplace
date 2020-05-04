using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a product attribute value model
    /// </summary>
    public partial class ProductAttributeValueModel : BaseSmiEntityModel, ILocalizedModel<ProductAttributeValueLocalizedModel>
    {
        #region Ctor

        public ProductAttributeValueModel()
        {
            ProductPictureModels = new List<ProductPictureModel>();
            Locales = new List<ProductAttributeValueLocalizedModel>();
        }

        #endregion

        #region Properties

        public int ProductAttributeMappingId { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.AttributeValueType")]
        public int AttributeValueTypeId { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.AttributeValueType")]
        public string AttributeValueTypeName { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.AssociatedProduct")]
        public int AssociatedProductId { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.AssociatedProduct")]
        public string AssociatedProductName { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.ColorSquaresRgb")]
        public string ColorSquaresRgb { get; set; }

        public bool DisplayColorSquaresRgb { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.ImageSquaresPicture")]
        [UIHint("Picture")]
        public int ImageSquaresPictureId { get; set; }

        public bool DisplayImageSquaresPicture { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.PriceAdjustment")]
        public decimal PriceAdjustment { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.PriceAdjustment")]
        //used only on the values list page
        public string PriceAdjustmentStr { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.PriceAdjustmentUsePercentage")]
        public bool PriceAdjustmentUsePercentage { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.WeightAdjustment")]
        public decimal WeightAdjustment { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.WeightAdjustment")]
        //used only on the values list page
        public string WeightAdjustmentStr { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.Cost")]
        public decimal Cost { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.CustomerEntersQty")]
        public bool CustomerEntersQty { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.Quantity")]
        public int Quantity { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.IsPreSelected")]
        public bool IsPreSelected { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.Picture")]
        public int PictureId { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.Picture")]
        public string PictureThumbnailUrl { get; set; }

        public IList<ProductPictureModel> ProductPictureModels { get; set; }

        public IList<ProductAttributeValueLocalizedModel> Locales { get; set; }

        #endregion
    }

    public partial class ProductAttributeValueLocalizedModel : ILocalizedLocaleModel
    {
        public int LanguageId { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.Name")]
        public string Name { get; set; }
    }
}