using Microsoft.AspNetCore.Mvc;
using Smi.Core.Domain.Customers;
using Smi.Web.Factories;
using Smi.Web.Framework.Components;

namespace Smi.Web.Components
{
    public class NewsletterBoxViewComponent : SmiViewComponent
    {
        private readonly CustomerSettings _customerSettings;
        private readonly INewsletterModelFactory _newsletterModelFactory;

        public NewsletterBoxViewComponent(CustomerSettings customerSettings, INewsletterModelFactory newsletterModelFactory)
        {
            _customerSettings = customerSettings;
            _newsletterModelFactory = newsletterModelFactory;
        }

        public IViewComponentResult Invoke()
        {
            if (_customerSettings.HideNewsletterBlock)
                return Content("");

            var model = _newsletterModelFactory.PrepareNewsletterBoxModel();
            return View(model);
        }
    }
}
