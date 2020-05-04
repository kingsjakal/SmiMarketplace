using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Reports
{
    /// <summary>
    /// Represents a best customers report model
    /// </summary>
    public partial class BestCustomersReportModel : BaseSmiModel
    {
        #region Properties

        public int CustomerId { get; set; }

        [SmiResourceDisplayName("Admin.Reports.Customers.BestBy.Fields.Customer")]
        public string CustomerName { get; set; }

        [SmiResourceDisplayName("Admin.Reports.Customers.BestBy.Fields.OrderTotal")]
        public string OrderTotal { get; set; }

        [SmiResourceDisplayName("Admin.Reports.Customers.BestBy.Fields.OrderCount")]
        public decimal OrderCount { get; set; }
        
        #endregion
    }
}