using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Plugin.ExternalAuth.Facebook.Models
{
    /// <summary>
    /// Represents plugin configuration model
    /// </summary>
    public class ConfigurationModel : BaseSmiModel
    {
        [SmiResourceDisplayName("Plugins.ExternalAuth.Facebook.ClientKeyIdentifier")]
        public string ClientId { get; set; }

        [SmiResourceDisplayName("Plugins.ExternalAuth.Facebook.ClientSecret")]
        public string ClientSecret { get; set; }
    }
}