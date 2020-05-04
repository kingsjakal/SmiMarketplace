using Microsoft.AspNetCore.Mvc;
using Smi.Web.Framework.Components;

namespace Smi.Plugin.Payments.PayPalStandard.Components
{
    [ViewComponent(Name = "PaymentPayPalStandard")]
    public class PaymentPayPalStandardViewComponent : SmiViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Plugins/Payments.PayPalStandard/Views/PaymentInfo.cshtml");
        }
    }
}
