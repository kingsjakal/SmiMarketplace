using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Settings
{
    /// <summary>
    /// Represents an external authentication settings model
    /// </summary>
    public partial class ExternalAuthenticationSettingsModel : BaseSmiModel, ISettingsModel
    {
        #region Properties

        public int ActiveStoreScopeConfiguration { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.CustomerUser.AllowCustomersToRemoveAssociations")]
        public bool AllowCustomersToRemoveAssociations { get; set; }

        #endregion
    }
}