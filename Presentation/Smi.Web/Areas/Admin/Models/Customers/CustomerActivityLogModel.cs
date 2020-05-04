using System;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Customers
{
    /// <summary>
    /// Represents a customer activity log model
    /// </summary>
    public partial class CustomerActivityLogModel : BaseSmiEntityModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.Customers.Customers.ActivityLog.ActivityLogType")]
        public string ActivityLogTypeName { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.ActivityLog.Comment")]
        public string Comment { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.ActivityLog.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.ActivityLog.IpAddress")]
        public string IpAddress { get; set; }

        #endregion
    }
}