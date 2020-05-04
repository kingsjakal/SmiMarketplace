using Smi.Web.Framework.Models;
using Smi.Web.Models.Common;

namespace Smi.Web.Models.Customer
{
    public partial class CustomerAddressEditModel : BaseSmiModel
    {
        public CustomerAddressEditModel()
        {
            Address = new AddressModel();
        }
        
        public AddressModel Address { get; set; }
    }
}