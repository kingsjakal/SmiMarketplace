using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Logging
{
    /// <summary>
    /// Represents an activity log search model
    /// </summary>
    public partial class ActivityLogSearchModel : BaseSearchModel
    {
        #region Ctor

        public ActivityLogSearchModel()
        {
            ActivityLogType = new List<SelectListItem>();
        }

        #endregion

        #region Properties

        [SmiResourceDisplayName("Admin.Customers.ActivityLog.Fields.CreatedOnFrom")]
        [UIHint("DateNullable")]
        public DateTime? CreatedOnFrom { get; set; }

        [SmiResourceDisplayName("Admin.Customers.ActivityLog.Fields.CreatedOnTo")]
        [UIHint("DateNullable")]
        public DateTime? CreatedOnTo { get; set; }

        [SmiResourceDisplayName("Admin.Customers.ActivityLog.Fields.ActivityLogType")]
        public int ActivityLogTypeId { get; set; }

        [SmiResourceDisplayName("Admin.Customers.ActivityLog.Fields.ActivityLogType")]
        public IList<SelectListItem> ActivityLogType { get; set; }
        
        [SmiResourceDisplayName("Admin.Customers.ActivityLog.Fields.IpAddress")]
        public string IpAddress { get; set; }

        #endregion
    }
}