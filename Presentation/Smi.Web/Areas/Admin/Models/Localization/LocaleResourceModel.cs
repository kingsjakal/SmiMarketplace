using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Localization
{
    /// <summary>
    /// Represents a locale resource model
    /// </summary>
    public partial class LocaleResourceModel : BaseSmiEntityModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.Configuration.Languages.Resources.Fields.Name")]
        public string ResourceName { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Languages.Resources.Fields.Value")]
        public string ResourceValue { get; set; }

        public int LanguageId { get; set; }

        #endregion
    }
}