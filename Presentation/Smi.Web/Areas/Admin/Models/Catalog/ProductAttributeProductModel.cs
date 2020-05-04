using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a model of products that use the product attribute
    /// </summary>
    public partial class ProductAttributeProductModel : BaseSmiEntityModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.Catalog.Attributes.ProductAttributes.UsedByProducts.Product")]
        public string ProductName { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Attributes.ProductAttributes.UsedByProducts.Published")]
        public bool Published { get; set; }

        #endregion
    }
}