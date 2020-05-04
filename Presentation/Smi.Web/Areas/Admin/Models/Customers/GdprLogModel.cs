using System;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Customers
{
    /// <summary>
    /// Represents a GDPR log (request) model
    /// </summary>
    public partial class GdprLogModel : BaseSmiEntityModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.Customers.GdprLog.Fields.CustomerInfo")]
        public string CustomerInfo { get; set; }

        [SmiResourceDisplayName("Admin.Customers.GdprLog.Fields.RequestType")]
        public string RequestType { get; set; }

        [SmiResourceDisplayName("Admin.Customers.GdprLog.Fields.RequestDetails")]
        public string RequestDetails { get; set; }

        [SmiResourceDisplayName("Admin.Customers.GdprLog.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        #endregion
    }
}