using Smi.Web.Areas.Admin.Models.Common;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Orders
{
    public partial class OrderAddressModel : BaseSmiModel
    {
        #region Ctor

        public OrderAddressModel()
        {
            Address = new AddressModel();
        }

        #endregion

        #region Properties

        public int OrderId { get; set; }

        public AddressModel Address { get; set; }

        #endregion
    }
}