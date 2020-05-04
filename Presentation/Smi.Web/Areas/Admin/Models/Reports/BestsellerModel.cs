using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Reports
{
    /// <summary>
    /// Represents a bestseller model
    /// </summary>
    public partial class BestsellerModel : BaseSmiModel
    {
        #region Properties

        public int ProductId { get; set; }

        [SmiResourceDisplayName("Admin.Reports.Sales.Bestsellers.Fields.Name")]
        public string ProductName { get; set; }

        [SmiResourceDisplayName("Admin.Reports.Sales.Bestsellers.Fields.TotalAmount")]
        public string TotalAmount { get; set; }

        [SmiResourceDisplayName("Admin.Reports.Sales.Bestsellers.Fields.TotalQuantity")]
        public decimal TotalQuantity { get; set; }

        #endregion
    }
}