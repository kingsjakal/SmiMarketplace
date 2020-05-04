using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Checkout
{
    public partial class CheckoutCompletedModel : BaseSmiModel
    {
        public int OrderId { get; set; }
        public string CustomOrderNumber { get; set; }
        public bool OnePageCheckoutEnabled { get; set; }
    }
}