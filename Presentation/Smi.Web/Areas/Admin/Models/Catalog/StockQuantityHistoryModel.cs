using System;
using System.ComponentModel.DataAnnotations;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a stock quantity history model
    /// </summary>
    public partial class StockQuantityHistoryModel : BaseSmiEntityModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.Catalog.Products.StockQuantityHistory.Fields.Warehouse")]
        public string WarehouseName { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.StockQuantityHistory.Fields.Combination")]
        public string AttributeCombination { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.StockQuantityHistory.Fields.QuantityAdjustment")]
        public int QuantityAdjustment { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.StockQuantityHistory.Fields.StockQuantity")]
        public int StockQuantity { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.StockQuantityHistory.Fields.Message")]
        public string Message { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.StockQuantityHistory.Fields.CreatedOn")]
        [UIHint("DecimalNullable")]
        public DateTime CreatedOn { get; set; }

        #endregion
    }
}