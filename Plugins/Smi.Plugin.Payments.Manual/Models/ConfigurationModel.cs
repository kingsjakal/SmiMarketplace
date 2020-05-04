using Microsoft.AspNetCore.Mvc.Rendering;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Plugin.Payments.Manual.Models
{
    public class ConfigurationModel : BaseSmiModel
    {
        public int ActiveStoreScopeConfiguration { get; set; }

        [SmiResourceDisplayName("Plugins.Payments.Manual.Fields.AdditionalFeePercentage")]
        public bool AdditionalFeePercentage { get; set; }
        public bool AdditionalFeePercentage_OverrideForStore { get; set; }

        [SmiResourceDisplayName("Plugins.Payments.Manual.Fields.AdditionalFee")]
        public decimal AdditionalFee { get; set; }
        public bool AdditionalFee_OverrideForStore { get; set; }

        public int TransactModeId { get; set; }
        [SmiResourceDisplayName("Plugins.Payments.Manual.Fields.TransactMode")]
        public SelectList TransactModeValues { get; set; }
        public bool TransactModeId_OverrideForStore { get; set; }
    }
}