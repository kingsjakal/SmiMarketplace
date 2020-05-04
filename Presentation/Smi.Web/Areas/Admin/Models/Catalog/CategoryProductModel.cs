using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a category product model
    /// </summary>
    public partial class CategoryProductModel : BaseSmiEntityModel
    {
        #region Properties

        public int CategoryId { get; set; }

        public int ProductId { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Categories.Products.Fields.Product")]
        public string ProductName { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Categories.Products.Fields.IsFeaturedProduct")]
        public bool IsFeaturedProduct { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Categories.Products.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        #endregion
    }
}