using Microsoft.AspNetCore.Mvc;
using Smi.Web.Factories;
using Smi.Web.Framework.Components;

namespace Smi.Web.Components
{
    public class LanguageSelectorViewComponent : SmiViewComponent
    {
        private readonly ICommonModelFactory _commonModelFactory;

        public LanguageSelectorViewComponent(ICommonModelFactory commonModelFactory)
        {
            _commonModelFactory = commonModelFactory;
        }

        public IViewComponentResult Invoke()
        {
            var model = _commonModelFactory.PrepareLanguageSelectorModel();

            if (model.AvailableLanguages.Count == 1)
                return Content("");

            return View(model);
        }
    }
}
