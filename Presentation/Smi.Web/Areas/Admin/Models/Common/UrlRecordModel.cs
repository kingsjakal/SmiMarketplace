using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Common
{
    /// <summary>
    /// Represents an URL record model
    /// </summary>
    public partial class UrlRecordModel : BaseSmiEntityModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.System.SeNames.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.System.SeNames.EntityId")]
        public int EntityId { get; set; }

        [SmiResourceDisplayName("Admin.System.SeNames.EntityName")]
        public string EntityName { get; set; }

        [SmiResourceDisplayName("Admin.System.SeNames.IsActive")]
        public bool IsActive { get; set; }

        [SmiResourceDisplayName("Admin.System.SeNames.Language")]
        public string Language { get; set; }

        [SmiResourceDisplayName("Admin.System.SeNames.Details")]
        public string DetailsUrl { get; set; }

        #endregion
    }
}