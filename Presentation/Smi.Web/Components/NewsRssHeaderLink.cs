using Microsoft.AspNetCore.Mvc;
using Smi.Core.Domain.News;
using Smi.Web.Framework.Components;

namespace Smi.Web.Components
{
    public class NewsRssHeaderLinkViewComponent : SmiViewComponent
    {
        private readonly NewsSettings _newsSettings;

        public NewsRssHeaderLinkViewComponent(NewsSettings newsSettings)
        {
            _newsSettings = newsSettings;
        }

        public IViewComponentResult Invoke(int currentCategoryId, int currentProductId)
        {
            if (!_newsSettings.Enabled || !_newsSettings.ShowHeaderRssUrl)
                return Content("");

            return View();
        }
    }
}
