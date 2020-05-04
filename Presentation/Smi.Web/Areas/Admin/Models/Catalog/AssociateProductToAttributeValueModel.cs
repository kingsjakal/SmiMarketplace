using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a product model to associate to the product attribute value
    /// </summary>
    public partial class AssociateProductToAttributeValueModel : BaseSmiModel
    {
        #region Properties
        
        public int AssociatedToProductId { get; set; }

        #endregion
    }
}