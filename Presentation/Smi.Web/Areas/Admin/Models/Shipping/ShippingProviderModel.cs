using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Shipping
{
    /// <summary>
    /// Represents a shipping provider model
    /// </summary>
    public partial class ShippingProviderModel : BaseSmiModel, IPluginModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.Configuration.Shipping.Providers.Fields.FriendlyName")]
        public string FriendlyName { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Shipping.Providers.Fields.SystemName")]
        public string SystemName { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Shipping.Providers.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Shipping.Providers.Fields.IsActive")]
        public bool IsActive { get; set; }
        
        [SmiResourceDisplayName("Admin.Configuration.Shipping.Providers.Fields.Logo")]
        public string LogoUrl { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Shipping.Providers.Configure")]
        public string ConfigurationUrl { get; set; }

        #endregion
    }
}