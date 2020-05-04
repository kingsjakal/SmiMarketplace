using Microsoft.AspNetCore.Mvc;
using Smi.Core.Domain.Blogs;
using Smi.Web.Framework.Components;

namespace Smi.Web.Components
{
    public class BlogRssHeaderLinkViewComponent : SmiViewComponent
    {
        private readonly BlogSettings _blogSettings;

        public BlogRssHeaderLinkViewComponent(BlogSettings blogSettings)
        {
            _blogSettings = blogSettings;
        }

        public IViewComponentResult Invoke(int currentCategoryId, int currentProductId)
        {
            if (!_blogSettings.Enabled || !_blogSettings.ShowHeaderRssUrl)
                return Content("");

            return View();
        }
    }
}
