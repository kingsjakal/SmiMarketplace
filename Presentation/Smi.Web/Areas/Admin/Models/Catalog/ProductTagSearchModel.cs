using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a product tag search model
    /// </summary>
    public partial class ProductTagSearchModel : BaseSearchModel
    {
        [SmiResourceDisplayName("Admin.Catalog.ProductTags.Fields.SearchTagName")]
        public string SearchTagName { get; set; }
    }
}