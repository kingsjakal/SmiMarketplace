using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Smi.Web.Factories;
using Smi.Web.Framework.Components;

namespace Smi.Web.Components
{
    public class HomepageCategoriesViewComponent : SmiViewComponent
    {
        private readonly ICatalogModelFactory _catalogModelFactory;

        public HomepageCategoriesViewComponent(ICatalogModelFactory catalogModelFactory)
        {
            _catalogModelFactory = catalogModelFactory;
        }

        public IViewComponentResult Invoke()
        {
            var model = _catalogModelFactory.PrepareHomepageCategoryModels();
            if (!model.Any())
                return Content("");

            return View(model);
        }
    }
}
