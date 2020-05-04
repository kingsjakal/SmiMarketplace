using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Templates
{
    /// <summary>
    /// Represents a product template model
    /// </summary>
    public partial class ProductTemplateModel : BaseSmiEntityModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.System.Templates.Product.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.System.Templates.Product.ViewPath")]
        public string ViewPath { get; set; }

        [SmiResourceDisplayName("Admin.System.Templates.Product.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [SmiResourceDisplayName("Admin.System.Templates.Product.IgnoredProductTypes")]
        public string IgnoredProductTypes { get; set; }

        #endregion
    }
}