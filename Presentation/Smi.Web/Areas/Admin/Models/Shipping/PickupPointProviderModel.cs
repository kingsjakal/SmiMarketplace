using Microsoft.AspNetCore.Routing;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Shipping
{
    /// <summary>
    /// Represents a pickup point provider model
    /// </summary>
    public partial class PickupPointProviderModel : BaseSmiModel, IPluginModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.Configuration.Shipping.PickupPointProviders.Fields.FriendlyName")]
        public string FriendlyName { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Shipping.PickupPointProviders.Fields.SystemName")]
        public string SystemName { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Shipping.PickupPointProviders.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Shipping.PickupPointProviders.Fields.IsActive")]
        public bool IsActive { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Shipping.PickupPointProviders.Fields.Logo")]
        public string LogoUrl { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Shipping.PickupPointProviders.Configure")]
        public string ConfigurationUrl { get; set; }

        #endregion
    }
}