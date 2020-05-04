using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Reports
{
    /// <summary>
    /// Represents a low stock product model
    /// </summary>
    public partial class LowStockProductModel : BaseSmiEntityModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.Name")]
        public string Name { get; set; }

        public string Attributes { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.ManageInventoryMethod")]
        public string ManageInventoryMethod { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.StockQuantity")]
        public int StockQuantity { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Fields.Published")]
        public bool Published { get; set; }

        #endregion
    }
}