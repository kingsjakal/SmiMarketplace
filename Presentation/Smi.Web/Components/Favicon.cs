using Microsoft.AspNetCore.Mvc;
using Smi.Web.Factories;
using Smi.Web.Framework.Components;

namespace Smi.Web.Components
{
    public class FaviconViewComponent : SmiViewComponent
    {
        private readonly ICommonModelFactory _commonModelFactory;

        public FaviconViewComponent(ICommonModelFactory commonModelFactory)
        {
            _commonModelFactory = commonModelFactory;
        }

        public IViewComponentResult Invoke()
        {
            var model = _commonModelFactory.PrepareFaviconAndAppIconsModel();
            if (string.IsNullOrEmpty(model.HeadCode))
                return Content("");
            return View(model);
        }
    }
}
