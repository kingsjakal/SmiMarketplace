using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Plugin.Widgets.GoogleAnalytics.Models
{
    public class ConfigurationModel : BaseSmiModel
    {
        public int ActiveStoreScopeConfiguration { get; set; }
        
        [SmiResourceDisplayName("Plugins.Widgets.GoogleAnalytics.GoogleId")]
        public string GoogleId { get; set; }
        public bool GoogleId_OverrideForStore { get; set; }

        [SmiResourceDisplayName("Plugins.Widgets.GoogleAnalytics.EnableEcommerce")]
        public bool EnableEcommerce { get; set; }
        public bool EnableEcommerce_OverrideForStore { get; set; }

        [SmiResourceDisplayName("Plugins.Widgets.GoogleAnalytics.UseJsToSendEcommerceInfo")]
        public bool UseJsToSendEcommerceInfo { get; set; }
        public bool UseJsToSendEcommerceInfo_OverrideForStore { get; set; }

        [SmiResourceDisplayName("Plugins.Widgets.GoogleAnalytics.TrackingScript")]
        public string TrackingScript { get; set; }
        public bool TrackingScript_OverrideForStore { get; set; }
        
        [SmiResourceDisplayName("Plugins.Widgets.GoogleAnalytics.IncludingTax")]
        public bool IncludingTax { get; set; }
        public bool IncludingTax_OverrideForStore { get; set; }

        [SmiResourceDisplayName("Plugins.Widgets.GoogleAnalytics.IncludeCustomerId")]
        public bool IncludeCustomerId { get; set; }
        public bool IncludeCustomerId_OverrideForStore { get; set; }
    }
}