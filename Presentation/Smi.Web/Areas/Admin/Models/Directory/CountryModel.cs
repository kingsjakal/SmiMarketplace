using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Directory
{
    /// <summary>
    /// Represents a country model
    /// </summary>
    public partial class CountryModel : BaseSmiEntityModel, ILocalizedModel<CountryLocalizedModel>, IStoreMappingSupportedModel
    {
        #region Ctor

        public CountryModel()
        {
            Locales = new List<CountryLocalizedModel>();
            SelectedStoreIds = new List<int>();
            AvailableStores = new List<SelectListItem>();
            StateProvinceSearchModel = new StateProvinceSearchModel();
        }

        #endregion

        #region Properties

        [SmiResourceDisplayName("Admin.Configuration.Countries.Fields.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Countries.Fields.AllowsBilling")]
        public bool AllowsBilling { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Countries.Fields.AllowsShipping")]
        public bool AllowsShipping { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Countries.Fields.TwoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Countries.Fields.ThreeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Countries.Fields.NumericIsoCode")]
        public int NumericIsoCode { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Countries.Fields.SubjectToVat")]
        public bool SubjectToVat { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Countries.Fields.Published")]
        public bool Published { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Countries.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Countries.Fields.NumberOfStates")]
        public int NumberOfStates { get; set; }

        public IList<CountryLocalizedModel> Locales { get; set; }

        //store mapping
        [SmiResourceDisplayName("Admin.Configuration.Countries.Fields.LimitedToStores")]
        public IList<int> SelectedStoreIds { get; set; }
        public IList<SelectListItem> AvailableStores { get; set; }

        public StateProvinceSearchModel StateProvinceSearchModel { get; set; }

        #endregion
    }

    public partial class CountryLocalizedModel : ILocalizedLocaleModel
    {
        public int LanguageId { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Countries.Fields.Name")]
        public string Name { get; set; }
    }
}