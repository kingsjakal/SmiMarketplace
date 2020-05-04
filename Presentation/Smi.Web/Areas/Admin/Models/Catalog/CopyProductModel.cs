using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a copy product model
    /// </summary>
    public partial class CopyProductModel : BaseSmiEntityModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.Catalog.Products.Copy.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Copy.CopyImages")]
        public bool CopyImages { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.Copy.Published")]
        public bool Published { get; set; }

        #endregion
    }
}