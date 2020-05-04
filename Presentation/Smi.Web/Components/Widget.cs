using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Smi.Web.Factories;
using Smi.Web.Framework.Components;

namespace Smi.Web.Components
{
    public class WidgetViewComponent : SmiViewComponent
    {
        private readonly IWidgetModelFactory _widgetModelFactory;

        public WidgetViewComponent(IWidgetModelFactory widgetModelFactory)
        {
            _widgetModelFactory = widgetModelFactory;
        }

        public IViewComponentResult Invoke(string widgetZone, object additionalData = null)
        {
            var model = _widgetModelFactory.PrepareRenderWidgetModel(widgetZone, additionalData);

            //no data?
            if (!model.Any())
                return Content("");

            return View(model);
        }
    }
}