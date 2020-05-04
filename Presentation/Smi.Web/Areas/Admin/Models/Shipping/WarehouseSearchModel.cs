using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Shipping
{
    /// <summary>
    /// Represents a warehouse search model
    /// </summary>
    public partial class WarehouseSearchModel : BaseSearchModel
    {
        [SmiResourceDisplayName("Admin.Orders.Shipments.List.Warehouse.SearchName")]
        public string SearchName { get; set; }
    }
}