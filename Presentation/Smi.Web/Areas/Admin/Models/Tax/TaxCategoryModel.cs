using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Tax
{
    /// <summary>
    /// Represents a tax category model
    /// </summary>
    public partial class TaxCategoryModel : BaseSmiEntityModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.Configuration.Tax.Categories.Fields.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Tax.Categories.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        #endregion
    }
}