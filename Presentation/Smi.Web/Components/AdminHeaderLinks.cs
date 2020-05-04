using Microsoft.AspNetCore.Mvc;
using Smi.Web.Factories;
using Smi.Web.Framework.Components;

namespace Smi.Web.Components
{
    public class AdminHeaderLinksViewComponent : SmiViewComponent
    {
        private readonly ICommonModelFactory _commonModelFactory;

        public AdminHeaderLinksViewComponent(ICommonModelFactory commonModelFactory)
        {
            _commonModelFactory = commonModelFactory;
        }

        public IViewComponentResult Invoke()
        {
            var model = _commonModelFactory.PrepareAdminHeaderLinksModel();
            return View(model);
        }
    }
}
