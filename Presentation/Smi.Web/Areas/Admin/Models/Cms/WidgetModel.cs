using Microsoft.AspNetCore.Routing;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Cms
{
    /// <summary>
    /// Represents a widget model
    /// </summary>
    public partial class WidgetModel : BaseSmiModel, IPluginModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.ContentManagement.Widgets.Fields.FriendlyName")]
        public string FriendlyName { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.Widgets.Fields.SystemName")]
        public string SystemName { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.Widgets.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.Widgets.Fields.IsActive")]
        public bool IsActive { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.Widgets.Configure")]
        public string ConfigurationUrl { get; set; }

        public string LogoUrl { get; set; }

        public string WidgetViewComponentName { get; set; }

        public RouteValueDictionary WidgetViewComponentArguments { get; set; }

        #endregion
    }
}