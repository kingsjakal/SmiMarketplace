using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Checkout
{
    public partial class OnePageCheckoutModel : BaseSmiModel
    {
        public bool ShippingRequired { get; set; }
        public bool DisableBillingAddressCheckoutStep { get; set; }

        public CheckoutBillingAddressModel BillingAddress { get; set; }
    }
}