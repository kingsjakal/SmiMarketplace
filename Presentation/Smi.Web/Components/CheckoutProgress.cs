using Microsoft.AspNetCore.Mvc;
using Smi.Web.Factories;
using Smi.Web.Framework.Components;
using Smi.Web.Models.Checkout;

namespace Smi.Web.Components
{
    public class CheckoutProgressViewComponent : SmiViewComponent
    {
        private readonly ICheckoutModelFactory _checkoutModelFactory;

        public CheckoutProgressViewComponent(ICheckoutModelFactory checkoutModelFactory)
        {
            _checkoutModelFactory = checkoutModelFactory;
        }

        public IViewComponentResult Invoke(CheckoutProgressStep step)
        {
            var model = _checkoutModelFactory.PrepareCheckoutProgressModel(step);
            return View(model);
        }
    }
}
