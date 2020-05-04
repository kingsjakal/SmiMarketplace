using System.Collections.Generic;
using Smi.Web.Framework.Models;
using Smi.Web.Models.Common;

namespace Smi.Web.Models.Customer
{
    public partial class CustomerAddressListModel : BaseSmiModel
    {
        public CustomerAddressListModel()
        {
            Addresses = new List<AddressModel>();
        }

        public IList<AddressModel> Addresses { get; set; }
    }
}