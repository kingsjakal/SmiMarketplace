using Microsoft.AspNetCore.Mvc;
using Smi.Web.Factories;
using Smi.Web.Framework.Components;

namespace Smi.Web.Components
{
    public class HeaderLinksViewComponent : SmiViewComponent
    {
        private readonly ICommonModelFactory _commonModelFactory;

        public HeaderLinksViewComponent(ICommonModelFactory commonModelFactory)
        {
            _commonModelFactory = commonModelFactory;
        }

        public IViewComponentResult Invoke()
        {
            var model = _commonModelFactory.PrepareHeaderLinksModel();
            return View(model);
        }
    }
}
