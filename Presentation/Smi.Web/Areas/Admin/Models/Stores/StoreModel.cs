using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Stores
{
    /// <summary>
    /// Represents a store model
    /// </summary>
    public partial class StoreModel : BaseSmiEntityModel, ILocalizedModel<StoreLocalizedModel>
    {
        #region Ctor

        public StoreModel()
        {
            Locales = new List<StoreLocalizedModel>();
            AvailableLanguages = new List<SelectListItem>();
        }

        #endregion

        #region Properties

        [SmiResourceDisplayName("Admin.Configuration.Stores.Fields.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Stores.Fields.Url")]
        public string Url { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Stores.Fields.SslEnabled")]
        public virtual bool SslEnabled { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Stores.Fields.Hosts")]
        public string Hosts { get; set; }

        //default language
        [SmiResourceDisplayName("Admin.Configuration.Stores.Fields.DefaultLanguage")]
        public int DefaultLanguageId { get; set; }

        public IList<SelectListItem> AvailableLanguages { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Stores.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Stores.Fields.CompanyName")]
        public string CompanyName { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Stores.Fields.CompanyAddress")]
        public string CompanyAddress { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Stores.Fields.CompanyPhoneNumber")]
        public string CompanyPhoneNumber { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Stores.Fields.CompanyVat")]
        public string CompanyVat { get; set; }
        
        public IList<StoreLocalizedModel> Locales { get; set; }

        #endregion
    }

    public partial class StoreLocalizedModel : ILocalizedLocaleModel
    {
        public int LanguageId { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Stores.Fields.Name")]
        public string Name { get; set; }
    }
}