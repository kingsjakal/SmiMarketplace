using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a product warehouse inventory model
    /// </summary>
    public partial class ProductWarehouseInventoryModel : BaseSmiModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductWarehouseInventory.Fields.Warehouse")]
        public int WarehouseId { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductWarehouseInventory.Fields.Warehouse")]
        public string WarehouseName { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductWarehouseInventory.Fields.WarehouseUsed")]
        public bool WarehouseUsed { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductWarehouseInventory.Fields.StockQuantity")]
        public int StockQuantity { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductWarehouseInventory.Fields.ReservedQuantity")]
        public int ReservedQuantity { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.ProductWarehouseInventory.Fields.PlannedQuantity")]
        public int PlannedQuantity { get; set; }

        #endregion
    }
}