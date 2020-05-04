using Smi.Web.Areas.Admin.Models.Common;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Shipping
{
    /// <summary>
    /// Represents a warehouse model
    /// </summary>
    public partial class WarehouseModel : BaseSmiEntityModel
    {
        #region Ctor

        public WarehouseModel()
        {
            Address = new AddressModel();
        }

        #endregion

        #region Properties

        [SmiResourceDisplayName("Admin.Configuration.Shipping.Warehouses.Fields.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Shipping.Warehouses.Fields.AdminComment")]
        public string AdminComment { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Shipping.Warehouses.Fields.Address")]
        public AddressModel Address { get; set; }

        #endregion
    }
}