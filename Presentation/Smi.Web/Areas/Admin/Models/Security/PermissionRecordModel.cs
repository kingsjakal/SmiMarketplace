using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Security
{
    /// <summary>
    /// Represents a permission record model
    /// </summary>
    public partial class PermissionRecordModel : BaseSmiModel
    {
        #region Properties

        public string Name { get; set; }

        public string SystemName { get; set; }

        #endregion
    }
}