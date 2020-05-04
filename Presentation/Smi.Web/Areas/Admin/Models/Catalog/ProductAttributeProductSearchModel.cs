using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a search model of products that use the product attribute
    /// </summary>
    public partial class ProductAttributeProductSearchModel : BaseSearchModel
    {
        #region Properties

        public int ProductAttributeId { get; set; }

        #endregion
    }
}