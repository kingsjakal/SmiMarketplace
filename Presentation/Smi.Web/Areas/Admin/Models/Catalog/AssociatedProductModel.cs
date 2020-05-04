using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents an associated product model
    /// </summary>
    public partial class AssociatedProductModel : BaseSmiEntityModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.Catalog.Products.AssociatedProducts.Fields.Product")]
        public string ProductName { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.AssociatedProducts.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        #endregion
    }
}