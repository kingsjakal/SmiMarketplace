using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Directory
{
    /// <summary>
    /// Represents a currency model
    /// </summary>
    public partial class CurrencyModel : BaseSmiEntityModel, ILocalizedModel<CurrencyLocalizedModel>, IStoreMappingSupportedModel
    {
        #region Ctor

        public CurrencyModel()
        {
            Locales = new List<CurrencyLocalizedModel>();

            SelectedStoreIds = new List<int>();
            AvailableStores = new List<SelectListItem>();
        }

        #endregion

        #region Properties

        [SmiResourceDisplayName("Admin.Configuration.Currencies.Fields.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Currencies.Fields.CurrencyCode")]
        public string CurrencyCode { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Currencies.Fields.DisplayLocale")]
        public string DisplayLocale { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Currencies.Fields.Rate")]
        public decimal Rate { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Currencies.Fields.CustomFormatting")]
        public string CustomFormatting { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Currencies.Fields.Published")]
        public bool Published { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Currencies.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Currencies.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Currencies.Fields.IsPrimaryExchangeRateCurrency")]
        public bool IsPrimaryExchangeRateCurrency { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Currencies.Fields.IsPrimaryStoreCurrency")]
        public bool IsPrimaryStoreCurrency { get; set; }

        public IList<CurrencyLocalizedModel> Locales { get; set; }

        //store mapping
        [SmiResourceDisplayName("Admin.Configuration.Currencies.Fields.LimitedToStores")]
        public IList<int> SelectedStoreIds { get; set; }
        public IList<SelectListItem> AvailableStores { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Currencies.Fields.RoundingType")]
        public int RoundingTypeId { get; set; }

        #endregion
    }

    public partial class CurrencyLocalizedModel : ILocalizedLocaleModel
    {
        public int LanguageId { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Currencies.Fields.Name")]
        public string Name { get; set; }
    }
}