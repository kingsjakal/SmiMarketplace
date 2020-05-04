using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;
using System.Collections.Generic;

namespace Smi.Web.Areas.Admin.Models.Settings
{
    /// <summary>
    /// Represents a GDPR consent model
    /// </summary>
    public partial class GdprConsentModel : BaseSmiEntityModel, ILocalizedModel<GdprConsentLocalizedModel>
    {
        #region Ctor

        public GdprConsentModel()
        {
            Locales = new List<GdprConsentLocalizedModel>();
        }

        #endregion

        #region Properties

        [SmiResourceDisplayName("Admin.Configuration.Settings.Gdpr.Consent.Message")]
        public string Message { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.Gdpr.Consent.IsRequired")]
        public bool IsRequired { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.Gdpr.Consent.RequiredMessage")]
        public string RequiredMessage { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.Gdpr.Consent.DisplayDuringRegistration")]
        public bool DisplayDuringRegistration { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.Gdpr.Consent.DisplayOnCustomerInfoPage")]
        public bool DisplayOnCustomerInfoPage { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.Gdpr.Consent.DisplayOrder")]
        public int DisplayOrder { get; set; }

        public IList<GdprConsentLocalizedModel> Locales { get; set; }

        #endregion
    }
}