using System.Collections.Generic;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a product model to add to the manufacturer
    /// </summary>
    public partial class AddProductToManufacturerModel : BaseSmiModel
    {
        #region Ctor

        public AddProductToManufacturerModel()
        {
            SelectedProductIds = new List<int>();
        }
        #endregion

        #region Properties

        public int ManufacturerId { get; set; }

        public IList<int> SelectedProductIds { get; set; }

        #endregion
    }
}