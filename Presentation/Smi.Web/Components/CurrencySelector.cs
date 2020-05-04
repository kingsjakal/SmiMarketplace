using Microsoft.AspNetCore.Mvc;
using Smi.Web.Factories;
using Smi.Web.Framework.Components;

namespace Smi.Web.Components
{
    public class CurrencySelectorViewComponent : SmiViewComponent
    {
        private readonly ICommonModelFactory _commonModelFactory;

        public CurrencySelectorViewComponent(ICommonModelFactory commonModelFactory)
        {
            _commonModelFactory = commonModelFactory;
        }

        public IViewComponentResult Invoke()
        {
            var model = _commonModelFactory.PrepareCurrencySelectorModel();
            if (model.AvailableCurrencies.Count == 1)
                return Content("");

            return View(model);
        }
    }
}
