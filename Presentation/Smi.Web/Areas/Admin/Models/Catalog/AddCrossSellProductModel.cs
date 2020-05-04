using System.Collections.Generic;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a cross-sell product model to add to the product
    /// </summary>
    public partial class AddCrossSellProductModel : BaseSmiModel
    {
        #region Ctor

        public AddCrossSellProductModel()
        {
            SelectedProductIds = new List<int>();
        }
        #endregion

        #region Properties

        public int ProductId { get; set; }

        public IList<int> SelectedProductIds { get; set; }

        #endregion
    }
}