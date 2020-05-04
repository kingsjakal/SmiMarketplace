using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Plugin.Tax.FixedOrByCountryStateZip.Models
{
    public class ConfigurationModel : BaseSearchModel
    {
        public ConfigurationModel()
        {
            AvailableStores = new List<SelectListItem>();
            AvailableCountries = new List<SelectListItem>();
            AvailableStates = new List<SelectListItem>();
            AvailableTaxCategories = new List<SelectListItem>();
        }

        [SmiResourceDisplayName("Plugins.Tax.FixedOrByCountryStateZip.Fields.Store")]
        public int AddStoreId { get; set; }
        [SmiResourceDisplayName("Plugins.Tax.FixedOrByCountryStateZip.Fields.Country")]
        public int AddCountryId { get; set; }
        [SmiResourceDisplayName("Plugins.Tax.FixedOrByCountryStateZip.Fields.StateProvince")]
        public int AddStateProvinceId { get; set; }
        [SmiResourceDisplayName("Plugins.Tax.FixedOrByCountryStateZip.Fields.Zip")]
        public string AddZip { get; set; }
        [SmiResourceDisplayName("Plugins.Tax.FixedOrByCountryStateZip.Fields.TaxCategory")]
        public int AddTaxCategoryId { get; set; }
        [SmiResourceDisplayName("Plugins.Tax.FixedOrByCountryStateZip.Fields.Percentage")]
        public decimal AddPercentage { get; set; }

        public bool CountryStateZipEnabled { get; set; }

        public IList<SelectListItem> AvailableStores { get; set; }
        public IList<SelectListItem> AvailableCountries { get; set; }
        public IList<SelectListItem> AvailableStates { get; set; }
        public IList<SelectListItem> AvailableTaxCategories { get; set; }
    }
}