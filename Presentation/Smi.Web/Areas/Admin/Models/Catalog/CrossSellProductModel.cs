using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a cross-sell product model
    /// </summary>
    public partial class CrossSellProductModel : BaseSmiEntityModel
    {
        #region Properties

        public int ProductId2 { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.CrossSells.Fields.Product")]
        public string Product2Name { get; set; }

        #endregion
    }
}