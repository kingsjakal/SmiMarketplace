using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a manufacturer product model
    /// </summary>
    public partial class ManufacturerProductModel : BaseSmiEntityModel
    {
        #region Properties

        public int ManufacturerId { get; set; }

        public int ProductId { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Manufacturers.Products.Fields.Product")]
        public string ProductName { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Manufacturers.Products.Fields.IsFeaturedProduct")]
        public bool IsFeaturedProduct { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Manufacturers.Products.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        #endregion
    }
}