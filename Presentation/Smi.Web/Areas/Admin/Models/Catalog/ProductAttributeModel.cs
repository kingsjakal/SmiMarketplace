using System.Collections.Generic;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a product attribute model
    /// </summary>
    public partial class ProductAttributeModel : BaseSmiEntityModel, ILocalizedModel<ProductAttributeLocalizedModel>
    {
        #region Ctor

        public ProductAttributeModel()
        {
            Locales = new List<ProductAttributeLocalizedModel>();
            PredefinedProductAttributeValueSearchModel = new PredefinedProductAttributeValueSearchModel();
            ProductAttributeProductSearchModel = new ProductAttributeProductSearchModel();
        }

        #endregion

        #region Properties

        [SmiResourceDisplayName("Admin.Catalog.Attributes.ProductAttributes.Fields.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Attributes.ProductAttributes.Fields.Description")]
        public string Description {get;set;}

        public IList<ProductAttributeLocalizedModel> Locales { get; set; }

        public PredefinedProductAttributeValueSearchModel PredefinedProductAttributeValueSearchModel { get; set; }

        public ProductAttributeProductSearchModel ProductAttributeProductSearchModel { get; set; }

        #endregion
    }

    public partial class ProductAttributeLocalizedModel : ILocalizedLocaleModel
    {
        public int LanguageId { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Attributes.ProductAttributes.Fields.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Attributes.ProductAttributes.Fields.Description")]
        public string Description {get;set;}
    }
}