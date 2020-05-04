using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.ShoppingCart
{
    /// <summary>
    /// Represents a shopping cart model
    /// </summary>
    public partial class ShoppingCartModel : BaseSmiModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.CurrentCarts.Customer")]
        public int CustomerId { get; set; }

        [SmiResourceDisplayName("Admin.CurrentCarts.Customer")]
        public string CustomerEmail { get; set; }

        [SmiResourceDisplayName("Admin.CurrentCarts.TotalItems")]
        public int TotalItems { get; set; }

        #endregion
    }
}