using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Plugin.Tax.FixedOrByCountryStateZip.Models
{
    public class CountryStateZipModel : BaseSmiEntityModel
    {
        [SmiResourceDisplayName("Plugins.Tax.FixedOrByCountryStateZip.Fields.Store")]
        public int StoreId { get; set; }
        [SmiResourceDisplayName("Plugins.Tax.FixedOrByCountryStateZip.Fields.Store")]
        public string StoreName { get; set; }

        [SmiResourceDisplayName("Plugins.Tax.FixedOrByCountryStateZip.Fields.TaxCategory")]
        public int TaxCategoryId { get; set; }
        [SmiResourceDisplayName("Plugins.Tax.FixedOrByCountryStateZip.Fields.TaxCategory")]
        public string TaxCategoryName { get; set; }

        [SmiResourceDisplayName("Plugins.Tax.FixedOrByCountryStateZip.Fields.Country")]
        public int CountryId { get; set; }
        [SmiResourceDisplayName("Plugins.Tax.FixedOrByCountryStateZip.Fields.Country")]
        public string CountryName { get; set; }

        [SmiResourceDisplayName("Plugins.Tax.FixedOrByCountryStateZip.Fields.StateProvince")]
        public int StateProvinceId { get; set; }
        [SmiResourceDisplayName("Plugins.Tax.FixedOrByCountryStateZip.Fields.StateProvince")]
        public string StateProvinceName { get; set; }

        [SmiResourceDisplayName("Plugins.Tax.FixedOrByCountryStateZip.Fields.Zip")]
        public string Zip { get; set; }

        [SmiResourceDisplayName("Plugins.Tax.FixedOrByCountryStateZip.Fields.Percentage")]
        public decimal Percentage { get; set; }
    }
}