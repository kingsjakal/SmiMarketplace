using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Settings
{
    /// <summary>
    /// Represents a localization settings model
    /// </summary>
    public partial class LocalizationSettingsModel : BaseSmiModel, ISettingsModel
    {
        #region Properties

        public int ActiveStoreScopeConfiguration { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.UseImagesForLanguageSelection")]
        public bool UseImagesForLanguageSelection { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.SeoFriendlyUrlsForLanguagesEnabled")]
        public bool SeoFriendlyUrlsForLanguagesEnabled { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.AutomaticallyDetectLanguage")]
        public bool AutomaticallyDetectLanguage { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.LoadAllLocaleRecordsOnStartup")]
        public bool LoadAllLocaleRecordsOnStartup { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.LoadAllLocalizedPropertiesOnStartup")]
        public bool LoadAllLocalizedPropertiesOnStartup { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.GeneralCommon.LoadAllUrlRecordsOnStartup")]
        public bool LoadAllUrlRecordsOnStartup { get; set; }

        #endregion
    }
}