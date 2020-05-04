using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Templates
{
    /// <summary>
    /// Represents a category template model
    /// </summary>
    public partial class CategoryTemplateModel : BaseSmiEntityModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.System.Templates.Category.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.System.Templates.Category.ViewPath")]
        public string ViewPath { get; set; }

        [SmiResourceDisplayName("Admin.System.Templates.Category.DisplayOrder")]
        public int DisplayOrder { get; set; }

        #endregion
    }
}