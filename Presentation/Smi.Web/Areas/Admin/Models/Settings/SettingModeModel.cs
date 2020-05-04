using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Settings
{
    /// <summary>
    /// Represents a setting mode model
    /// </summary>
    public partial class SettingModeModel : BaseSmiModel
    {
        #region Properties

        public string ModeName { get; set; }

        public bool Enabled { get; set; }

        #endregion
    }
}