using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Reports
{
    /// <summary>
    /// Represents a registered customers report model
    /// </summary>
    public partial class RegisteredCustomersReportModel : BaseSmiModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.Reports.Customers.RegisteredCustomers.Fields.Period")]
        public string Period { get; set; }

        [SmiResourceDisplayName("Admin.Reports.Customers.RegisteredCustomers.Fields.Customers")]
        public int Customers { get; set; }

        #endregion
    }
}