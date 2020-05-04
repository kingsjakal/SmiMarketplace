using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Plugins
{
    /// <summary>
    /// Represents a plugin model that is used for admin navigation
    /// </summary>
    public partial class AdminNavigationPluginModel : BaseSmiModel
    {
        #region Properties

        public string FriendlyName { get; set; }

        public string ConfigurationUrl { get; set; }

        #endregion
    }
}