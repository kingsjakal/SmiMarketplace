using Microsoft.AspNetCore.Mvc;
using Smi.Web.Factories;
using Smi.Web.Framework.Components;

namespace Smi.Web.Components
{
    public class SocialButtonsViewComponent : SmiViewComponent
    {
        private readonly ICommonModelFactory _commonModelFactory;

        public SocialButtonsViewComponent(ICommonModelFactory commonModelFactory)
        {
            _commonModelFactory = commonModelFactory;
        }

        public IViewComponentResult Invoke()
        {
            var model = _commonModelFactory.PrepareSocialModel();
            return View(model);
        }
    }
}
