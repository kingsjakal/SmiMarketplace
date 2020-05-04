using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Settings
{
    /// <summary>
    /// Represents a security settings model
    /// </summary>
    public partial class SecuritySettingsModel : BaseSmiModel, ISettingsModel
    {
        #region Properties

        public int ActiveStoreScopeConfiguration { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.EncryptionKey")]
        public string EncryptionKey { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.AdminAreaAllowedIpAddresses")]
        public string AdminAreaAllowedIpAddresses { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.HoneypotEnabled")]
        public bool HoneypotEnabled { get; set; }

        #endregion
    }
}