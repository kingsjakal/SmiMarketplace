using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Reports
{
    /// <summary>
    /// Represents a country report model
    /// </summary>
    public partial class CountryReportModel : BaseSmiModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.Reports.Sales.Country.Fields.CountryName")]
        public string CountryName { get; set; }

        [SmiResourceDisplayName("Admin.Reports.Sales.Country.Fields.TotalOrders")]
        public int TotalOrders { get; set; }

        [SmiResourceDisplayName("Admin.Reports.Sales.Country.Fields.SumOrders")]
        public string SumOrders { get; set; }

        #endregion
    }
}