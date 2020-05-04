using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.ExternalAuthentication
{
    /// <summary>
    /// Represents an external authentication method model
    /// </summary>
    public partial class ExternalAuthenticationMethodModel : BaseSmiModel, IPluginModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.Configuration.ExternalAuthenticationMethods.Fields.FriendlyName")]
        public string FriendlyName { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.ExternalAuthenticationMethods.Fields.SystemName")]
        public string SystemName { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.ExternalAuthenticationMethods.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.ExternalAuthenticationMethods.Fields.IsActive")]
        public bool IsActive { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.ExternalAuthenticationMethods.Configure")]
        public string ConfigurationUrl { get; set; }

        public string LogoUrl { get; set; }

        #endregion
    }
}