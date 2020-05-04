using Microsoft.AspNetCore.Mvc;
using Smi.Core.Domain.News;
using Smi.Web.Factories;
using Smi.Web.Framework.Components;

namespace Smi.Web.Components
{
    public class HomepageNewsViewComponent : SmiViewComponent
    {
        private readonly INewsModelFactory _newsModelFactory;
        private readonly NewsSettings _newsSettings;

        public HomepageNewsViewComponent(INewsModelFactory newsModelFactory, NewsSettings newsSettings)
        {
            _newsModelFactory = newsModelFactory;
            _newsSettings = newsSettings;
        }

        public IViewComponentResult Invoke()
        {
            if (!_newsSettings.Enabled || !_newsSettings.ShowNewsOnMainPage)
                return Content("");

            var model = _newsModelFactory.PrepareHomepageNewsItemsModel();
            return View(model);
        }
    }
}
