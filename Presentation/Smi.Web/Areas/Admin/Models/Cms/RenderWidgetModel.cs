using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Cms
{
    public partial class RenderWidgetModel : BaseSmiModel
    {
        public string WidgetViewComponentName { get; set; }
        public object WidgetViewComponentArguments { get; set; }
    }
}