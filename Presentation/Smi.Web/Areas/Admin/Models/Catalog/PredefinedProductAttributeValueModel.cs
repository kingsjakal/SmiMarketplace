﻿using System.Collections.Generic;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a predefined product attribute value model
    /// </summary>
    public partial class PredefinedProductAttributeValueModel : BaseSmiEntityModel, ILocalizedModel<PredefinedProductAttributeValueLocalizedModel>
    {
        #region Ctor

        public PredefinedProductAttributeValueModel()
        {
            Locales = new List<PredefinedProductAttributeValueLocalizedModel>();
        }

        #endregion

        #region Properties

        public int ProductAttributeId { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Attributes.ProductAttributes.PredefinedValues.Fields.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Attributes.ProductAttributes.PredefinedValues.Fields.PriceAdjustment")]
        public decimal PriceAdjustment { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Attributes.ProductAttributes.PredefinedValues.Fields.PriceAdjustment")]
        //used only on the values list page
        public string PriceAdjustmentStr { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Attributes.ProductAttributes.PredefinedValues.Fields.PriceAdjustmentUsePercentage")]
        public bool PriceAdjustmentUsePercentage { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Attributes.ProductAttributes.PredefinedValues.Fields.WeightAdjustment")]
        public decimal WeightAdjustment { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Attributes.ProductAttributes.PredefinedValues.Fields.WeightAdjustment")]
        //used only on the values list page
        public string WeightAdjustmentStr { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Attributes.ProductAttributes.PredefinedValues.Fields.Cost")]
        public decimal Cost { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Attributes.ProductAttributes.PredefinedValues.Fields.IsPreSelected")]
        public bool IsPreSelected { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Attributes.ProductAttributes.PredefinedValues.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        public IList<PredefinedProductAttributeValueLocalizedModel> Locales { get; set; }

        #endregion
    }

    public partial class PredefinedProductAttributeValueLocalizedModel : ILocalizedLocaleModel
    {
        public int LanguageId { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Attributes.ProductAttributes.PredefinedValues.Fields.Name")]
        public string Name { get; set; }
    }
}