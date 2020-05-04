using Smi.Web.Areas.Admin.Models.Common;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Customers
{
    /// <summary>
    /// Represents a customer address model
    /// </summary>
    public partial class CustomerAddressModel : BaseSmiModel
    {
        #region Ctor

        public CustomerAddressModel()
        {
            Address = new AddressModel();
        }

        #endregion

        #region Properties

        public int CustomerId { get; set; }

        public AddressModel Address { get; set; }

        #endregion
    }
}