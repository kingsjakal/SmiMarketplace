using Smi.Web.Areas.Admin.Models.ShoppingCart;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Customers
{
    /// <summary>
    /// Represents a customer shopping cart list model
    /// </summary>
    public partial class CustomerShoppingCartListModel : BasePagedListModel<ShoppingCartItemModel>
    {
    }
}