using Microsoft.AspNetCore.Mvc.Rendering;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Settings
{
    /// <summary>
    /// Represents a GDPR settings model
    /// </summary>
    public partial class GdprSettingsModel : BaseSmiModel, ISettingsModel
    {
        #region Ctor

        public GdprSettingsModel()
        {
            GdprConsentSearchModel = new GdprConsentSearchModel();
        }

        #endregion

        #region Properties

        public int ActiveStoreScopeConfiguration { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.Gdpr.GdprEnabled")]
        public bool GdprEnabled { get; set; }
        public bool GdprEnabled_OverrideForStore { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.Gdpr.LogPrivacyPolicyConsent")]
        public bool LogPrivacyPolicyConsent { get; set; }
        public bool LogPrivacyPolicyConsent_OverrideForStore { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.Gdpr.LogNewsletterConsent")]
        public bool LogNewsletterConsent { get; set; }
        public bool LogNewsletterConsent_OverrideForStore { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.Gdpr.LogUserProfileChanges")]
        public bool LogUserProfileChanges { get; set; }
        public bool LogUserProfileChanges_OverrideForStore { get; set; }

        public GdprConsentSearchModel GdprConsentSearchModel { get; set; }

        #endregion
    }
}