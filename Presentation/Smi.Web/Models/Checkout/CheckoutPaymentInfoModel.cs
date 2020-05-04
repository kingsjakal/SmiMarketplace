using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Checkout
{
    public partial class CheckoutPaymentInfoModel : BaseSmiModel
    {
        public string PaymentViewComponentName { get; set; }

        /// <summary>
        /// Used on one-page checkout page
        /// </summary>
        public bool DisplayOrderTotals { get; set; }
    }
}