using Microsoft.AspNetCore.Mvc;
using Smi.Web.Factories;
using Smi.Web.Framework.Components;

namespace Smi.Web.Components
{
    public class TopMenuViewComponent : SmiViewComponent
    {
        private readonly ICatalogModelFactory _catalogModelFactory;

        public TopMenuViewComponent(ICatalogModelFactory catalogModelFactory)
        {
            _catalogModelFactory = catalogModelFactory;
        }

        public IViewComponentResult Invoke(int? productThumbPictureSize)
        {
            var model = _catalogModelFactory.PrepareTopMenuModel();
            return View(model);
        }
    }
}
