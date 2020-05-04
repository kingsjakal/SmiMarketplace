using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Reports
{
    /// <summary>
    /// Represents a never sold products report model
    /// </summary>
    public partial class NeverSoldReportModel : BaseSmiModel
    {
        #region Properties

        public int ProductId { get; set; }

        [SmiResourceDisplayName("Admin.Reports.Sales.NeverSold.Fields.Name")]
        public string ProductName { get; set; }

        #endregion
    }
}