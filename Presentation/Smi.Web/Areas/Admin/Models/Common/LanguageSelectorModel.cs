using System.Collections.Generic;
using Smi.Web.Areas.Admin.Models.Localization;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Common
{
    /// <summary>
    /// Represents an admin language selector model
    /// </summary>
    public partial class LanguageSelectorModel : BaseSmiModel
    {
        #region Ctor

        public LanguageSelectorModel()
        {
            AvailableLanguages = new List<LanguageModel>();
        }

        #endregion

        #region Properties

        public IList<LanguageModel> AvailableLanguages { get; set; }

        public LanguageModel CurrentLanguage { get; set; }

        #endregion
    }
}