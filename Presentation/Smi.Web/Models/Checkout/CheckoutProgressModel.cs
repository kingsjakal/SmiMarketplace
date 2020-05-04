using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Checkout
{
    public partial class CheckoutProgressModel : BaseSmiModel
    {
        public CheckoutProgressStep CheckoutProgressStep { get; set; }
    }

    public enum CheckoutProgressStep
    {
        Cart,
        Address,
        Shipping,
        Payment,
        Confirm,
        Complete
    }
}