using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Customers
{
    /// <summary>
    /// Represents a product model to add to the customer role 
    /// </summary>
    public partial class AddProductToCustomerRoleModel : BaseSmiEntityModel
    {
        #region Properties

        public int AssociatedToProductId { get; set; }

        #endregion
    }
}