using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Common
{
    /// <summary>
    /// Represents a popular search term model
    /// </summary>
    public partial class PopularSearchTermModel : BaseSmiModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.SearchTermReport.Keyword")]
        public string Keyword { get; set; }

        [SmiResourceDisplayName("Admin.SearchTermReport.Count")]
        public int Count { get; set; }

        #endregion
    }
}
