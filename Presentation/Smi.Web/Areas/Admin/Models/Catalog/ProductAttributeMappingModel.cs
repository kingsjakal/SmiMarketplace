using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a product attribute mapping model
    /// </summary>
    public partial class ProductAttributeMappingModel : BaseSmiEntityModel, ILocalizedModel<ProductAttributeMappingLocalizedModel>
    {
        #region Ctor

        public ProductAttributeMappingModel()
        {
            AvailableProductAttributes = new List<SelectListItem>();
            Locales = new List<ProductAttributeMappingLocalizedModel>();
            ConditionModel = new ProductAttributeConditionModel();
            ProductAttributeValueSearchModel = new ProductAttributeValueSearchModel();
        }

        #endregion

        #region Properties

        public int ProductId { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Fields.Attribute")]
        public int ProductAttributeId { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Fields.Attribute")]
        public string ProductAttribute { get; set; }

        public IList<SelectListItem> AvailableProductAttributes { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Fields.TextPrompt")]
        public string TextPrompt { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Fields.IsRequired")]
        public bool IsRequired { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Fields.AttributeControlType")]
        public int AttributeControlTypeId { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Fields.AttributeControlType")]
        public string AttributeControlType { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        //validation fields
        [SmiResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.ValidationRules.MinLength")]
        [UIHint("Int32Nullable")]
        public int? ValidationMinLength { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.ValidationRules.MaxLength")]
        [UIHint("Int32Nullable")]
        public int? ValidationMaxLength { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.ValidationRules.FileAllowedExtensions")]
        public string ValidationFileAllowedExtensions { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.ValidationRules.FileMaximumSize")]
        [UIHint("Int32Nullable")]
        public int? ValidationFileMaximumSize { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.ValidationRules.DefaultValue")]
        public string DefaultValue { get; set; }

        public string ValidationRulesString { get; set; }

        //condition
        [SmiResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Condition")]
        public bool ConditionAllowed { get; set; }

        public string ConditionString { get; set; }

        public ProductAttributeConditionModel ConditionModel { get; set; }

        public IList<ProductAttributeMappingLocalizedModel> Locales { get; set; }

        public ProductAttributeValueSearchModel ProductAttributeValueSearchModel { get; set; }

        #endregion
    }

    public partial class ProductAttributeMappingLocalizedModel : ILocalizedLocaleModel
    {
        public int LanguageId { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Fields.TextPrompt")]
        public string TextPrompt { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.ValidationRules.DefaultValue")]
        public string DefaultValue { get; set; }
    }
}