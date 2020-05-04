using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Logging
{
    /// <summary>
    /// Represents an activity log type model
    /// </summary>
    public partial class ActivityLogTypeModel : BaseSmiEntityModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.Customers.ActivityLogType.Fields.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.Customers.ActivityLogType.Fields.Enabled")]
        public bool Enabled { get; set; }

        #endregion
    }
}