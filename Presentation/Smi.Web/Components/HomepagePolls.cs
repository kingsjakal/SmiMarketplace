using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Smi.Web.Factories;
using Smi.Web.Framework.Components;

namespace Smi.Web.Components
{
    public class HomepagePollsViewComponent : SmiViewComponent
    {
        private readonly IPollModelFactory _pollModelFactory;

        public HomepagePollsViewComponent(IPollModelFactory pollModelFactory)
        {
            _pollModelFactory = pollModelFactory;
        }

        public IViewComponentResult Invoke()
        {
            var model = _pollModelFactory.PrepareHomepagePollModels();
            if (!model.Any())
                return Content("");

            return View(model);
        }
    }
}
