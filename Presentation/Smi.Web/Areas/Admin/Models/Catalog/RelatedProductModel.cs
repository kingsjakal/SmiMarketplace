using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a related product model
    /// </summary>
    public partial class RelatedProductModel : BaseSmiEntityModel
    {
        #region Properties

        public int ProductId2 { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.RelatedProducts.Fields.Product")]
        public string Product2Name { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.RelatedProducts.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        #endregion
    }
}