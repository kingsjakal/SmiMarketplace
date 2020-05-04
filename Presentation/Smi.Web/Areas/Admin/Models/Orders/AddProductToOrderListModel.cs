using Smi.Web.Areas.Admin.Models.Catalog;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Orders
{
    /// <summary>
    /// Represents a product list model to add to the order
    /// </summary>
    public partial class AddProductToOrderListModel : BasePagedListModel<ProductModel>
    {
    }
}