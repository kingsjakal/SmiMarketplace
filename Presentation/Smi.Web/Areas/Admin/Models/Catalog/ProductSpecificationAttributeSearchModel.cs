using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a product specification attribute search model
    /// </summary>
    public partial class ProductSpecificationAttributeSearchModel : BaseSearchModel
    {
        #region Properties

        public int ProductId { get; set; }
        
        #endregion
    }
}