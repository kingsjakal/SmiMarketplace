using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Plugin.Tax.FixedOrByCountryStateZip.Models
{
    public class FixedTaxRateModel: BaseSmiModel
    {
        public int TaxCategoryId { get; set; }

        [SmiResourceDisplayName("Plugins.Tax.FixedOrByCountryStateZip.Fields.TaxCategoryName")]
        public string TaxCategoryName { get; set; }

        [SmiResourceDisplayName("Plugins.Tax.FixedOrByCountryStateZip.Fields.Rate")]
        public decimal Rate { get; set; }
    }
}