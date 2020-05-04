using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Smi.Web.Factories;
using Smi.Web.Framework.Components;

namespace Smi.Web.Components
{
    public class ForumActiveDiscussionsSmallViewComponent : SmiViewComponent
    {
        private readonly IForumModelFactory _forumModelFactory;

        public ForumActiveDiscussionsSmallViewComponent(IForumModelFactory forumModelFactory)
        {
            _forumModelFactory = forumModelFactory;
        }

        public IViewComponentResult Invoke()
        {
            var model = _forumModelFactory.PrepareActiveDiscussionsModel();
            if (!model.ForumTopics.Any())
                return Content("");

            return View(model);
        }
    }
}
