using Microsoft.AspNetCore.Mvc;
using Smi.Web.Factories;
using Smi.Web.Framework.Components;

namespace Smi.Web.Components
{
    public class CustomerNavigationViewComponent : SmiViewComponent
    {
        private readonly ICustomerModelFactory _customerModelFactory;

        public CustomerNavigationViewComponent(ICustomerModelFactory customerModelFactory)
        {
            _customerModelFactory = customerModelFactory;
        }

        public IViewComponentResult Invoke(int selectedTabId = 0)
        {
            var model = _customerModelFactory.PrepareCustomerNavigationModel(selectedTabId);
            return View(model);
        }
    }
}
