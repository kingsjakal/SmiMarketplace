using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Orders
{
    /// <summary>
    /// Represents an incomplete order report model
    /// </summary>
    public partial class OrderIncompleteReportModel : BaseSmiModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.SalesReport.Incomplete.Item")]
        public string Item { get; set; }

        [SmiResourceDisplayName("Admin.SalesReport.Incomplete.Total")]
        public string Total { get; set; }

        [SmiResourceDisplayName("Admin.SalesReport.Incomplete.Count")]
        public int Count { get; set; }

        [SmiResourceDisplayName("Admin.SalesReport.Incomplete.View")]
        public string ViewLink { get; set; }

        #endregion
    }
}