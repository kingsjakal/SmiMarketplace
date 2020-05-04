using Microsoft.AspNetCore.Mvc;
using Smi.Web.Factories;
using Smi.Web.Framework.Components;

namespace Smi.Web.Components
{
    public class TopicBlockViewComponent : SmiViewComponent
    {
        private readonly ITopicModelFactory _topicModelFactory;

        public TopicBlockViewComponent(ITopicModelFactory topicModelFactory)
        {
            _topicModelFactory = topicModelFactory;
        }

        public IViewComponentResult Invoke(string systemName)
        {
            var model = _topicModelFactory.PrepareTopicModelBySystemName(systemName);
            if (model == null)
                return Content("");
            return View(model);
        }
    }
}
