using Microsoft.AspNetCore.Mvc;
using Smi.Web.Factories;
using Smi.Web.Framework.Components;

namespace Smi.Web.Components
{
    public class SearchBoxViewComponent : SmiViewComponent
    {
        private readonly ICatalogModelFactory _catalogModelFactory;

        public SearchBoxViewComponent(ICatalogModelFactory catalogModelFactory)
        {
            _catalogModelFactory = catalogModelFactory;
        }

        public IViewComponentResult Invoke()
        {
            var model = _catalogModelFactory.PrepareSearchBoxModel();
            return View(model);
        }
    }
}
