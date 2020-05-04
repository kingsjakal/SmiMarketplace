using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a review type localized model
    /// </summary>
    public partial class ReviewTypeLocalizedModel : ILocalizedLocaleModel
    {
        public int LanguageId { get; set; }

        [SmiResourceDisplayName("Admin.Settings.ReviewType.Fields.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.Settings.ReviewType.Fields.Description")]
        public string Description { get; set; }
    }
}
