using Microsoft.AspNetCore.Mvc;
using Smi.Core.Domain.Tax;
using Smi.Web.Factories;
using Smi.Web.Framework.Components;

namespace Smi.Web.Components
{
    public class TaxTypeSelectorViewComponent : SmiViewComponent
    {
        private readonly ICommonModelFactory _commonModelFactory;
        private readonly TaxSettings _taxSettings;

        public TaxTypeSelectorViewComponent(ICommonModelFactory commonModelFactory,
            TaxSettings taxSettings)
        {
            _commonModelFactory = commonModelFactory;
            _taxSettings = taxSettings;
        }

        public IViewComponentResult Invoke()
        {
            if (!_taxSettings.AllowCustomersToSelectTaxDisplayType)
                return Content("");

            var model = _commonModelFactory.PrepareTaxTypeSelectorModel();
            return View(model);
        }
    }
}
