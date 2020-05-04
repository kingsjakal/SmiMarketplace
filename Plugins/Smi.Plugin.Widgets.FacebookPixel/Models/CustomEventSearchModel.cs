using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Plugin.Widgets.FacebookPixel.Models
{
    /// <summary>
    /// Represents a custom event search model
    /// </summary>
    public partial class CustomEventSearchModel : BaseSearchModel
    {
        #region Ctor

        public CustomEventSearchModel()
        {
            AddCustomEvent = new CustomEventModel();
        }

        #endregion

        #region Properties

        public int ConfigurationId { get; set; }

        [SmiResourceDisplayName("Plugins.Widgets.FacebookPixel.Configuration.CustomEvents.Search.WidgetZone")]
        public string WidgetZone { get; set; }

        public CustomEventModel AddCustomEvent { get; set; }

        #endregion
    }
}