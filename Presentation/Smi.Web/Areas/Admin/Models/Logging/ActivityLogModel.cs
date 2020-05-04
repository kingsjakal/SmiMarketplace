using System;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Logging
{
    /// <summary>
    /// Represents an activity log model
    /// </summary>
    public partial class ActivityLogModel : BaseSmiEntityModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.Customers.ActivityLog.Fields.ActivityLogType")]
        public string ActivityLogTypeName { get; set; }

        [SmiResourceDisplayName("Admin.Customers.ActivityLog.Fields.Customer")]
        public int CustomerId { get; set; }

        [SmiResourceDisplayName("Admin.Customers.ActivityLog.Fields.CustomerEmail")]
        public string CustomerEmail { get; set; }

        [SmiResourceDisplayName("Admin.Customers.ActivityLog.Fields.Comment")]
        public string Comment { get; set; }

        [SmiResourceDisplayName("Admin.Customers.ActivityLog.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        [SmiResourceDisplayName("Admin.Customers.ActivityLog.Fields.IpAddress")]
        public string IpAddress { get; set; }

        #endregion
    }
}