using Microsoft.AspNetCore.Mvc;
using Smi.Web.Factories;
using Smi.Web.Framework.Components;

namespace Smi.Web.Components
{
    public class LogoViewComponent : SmiViewComponent
    {
        private readonly ICommonModelFactory _commonModelFactory;

        public LogoViewComponent(ICommonModelFactory commonModelFactory)
        {
            _commonModelFactory = commonModelFactory;
        }

        public IViewComponentResult Invoke()
        {
            var model = _commonModelFactory.PrepareLogoModel();
            return View(model);
        }
    }
}
