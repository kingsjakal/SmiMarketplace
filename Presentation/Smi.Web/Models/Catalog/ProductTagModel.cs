using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Catalog
{
    public partial class ProductTagModel : BaseSmiEntityModel
    {
        public string Name { get; set; }

        public string SeName { get; set; }

        public int ProductCount { get; set; }
    }
}