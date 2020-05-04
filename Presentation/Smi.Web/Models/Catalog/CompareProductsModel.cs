using System.Collections.Generic;
using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Catalog
{
    public partial class CompareProductsModel : BaseSmiEntityModel
    {
        public CompareProductsModel()
        {
            Products = new List<ProductOverviewModel>();
        }
        public IList<ProductOverviewModel> Products { get; set; }

        public bool IncludeShortDescriptionInCompareProducts { get; set; }
        public bool IncludeFullDescriptionInCompareProducts { get; set; }
    }
}