using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Settings
{
    /// <summary>
    /// Represents a sort option model
    /// </summary>
    public partial class SortOptionModel : BaseSmiEntityModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.Configuration.Settings.Catalog.SortOptions.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.Catalog.SortOptions.IsActive")]
        public bool IsActive { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.Catalog.SortOptions.DisplayOrder")]
        public int DisplayOrder { get; set; }

        #endregion
    }
}