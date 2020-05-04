using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Smi.Web.Factories;
using Smi.Web.Framework.Components;

namespace Smi.Web.Components
{
    public class PopularProductTagsViewComponent : SmiViewComponent
    {
        private readonly ICatalogModelFactory _catalogModelFactory;

        public PopularProductTagsViewComponent(ICatalogModelFactory catalogModelFactory)
        {
            _catalogModelFactory = catalogModelFactory;
        }

        public IViewComponentResult Invoke()
        {
            var model = _catalogModelFactory.PreparePopularProductTagsModel();

            if (!model.Tags.Any())
                return Content("");

            return View(model);
        }
    }
}
