using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Templates
{
    /// <summary>
    /// Represents a manufacturer template model
    /// </summary>
    public partial class ManufacturerTemplateModel : BaseSmiEntityModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.System.Templates.Manufacturer.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.System.Templates.Manufacturer.ViewPath")]
        public string ViewPath { get; set; }

        [SmiResourceDisplayName("Admin.System.Templates.Manufacturer.DisplayOrder")]
        public int DisplayOrder { get; set; }

        #endregion
    }
}