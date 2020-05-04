using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Common
{
    /// <summary>
    /// Represents an URL record search model
    /// </summary>
    public partial class UrlRecordSearchModel : BaseSearchModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.System.SeNames.Name")]
        public string SeName { get; set; }

        #endregion
    }
}