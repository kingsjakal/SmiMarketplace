using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Catalog
{
    public partial class SearchBoxModel : BaseSmiModel
    {
        public bool AutoCompleteEnabled { get; set; }
        public bool ShowProductImagesInSearchAutoComplete { get; set; }
        public int SearchTermMinimumLength { get; set; }
        public bool ShowSearchBox { get; set; }
    }
}