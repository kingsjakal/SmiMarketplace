using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;
using System.ComponentModel.DataAnnotations;

namespace Smi.Plugin.Shipping.FixedByWeightByTotal.Models
{
    public class FixedRateModel : BaseSmiModel
    {
        public int ShippingMethodId { get; set; }

        [SmiResourceDisplayName("Plugins.Shipping.FixedByWeightByTotal.Fields.ShippingMethod")]
        public string ShippingMethodName { get; set; }

        [SmiResourceDisplayName("Plugins.Shipping.FixedByWeightByTotal.Fields.Rate")]
        public decimal Rate { get; set; }

        [UIHint("Int32Nullable")]
        [SmiResourceDisplayName("Plugins.Shipping.FixedByWeightByTotal.Fields.TransitDays")]
        public int? TransitDays { get; set; }
    }
}