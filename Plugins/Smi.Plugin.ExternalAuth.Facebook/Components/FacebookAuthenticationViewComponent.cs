using Microsoft.AspNetCore.Mvc;
using Smi.Web.Framework.Components;

namespace Smi.Plugin.ExternalAuth.Facebook.Components
{
    /// <summary>
    /// Represents view component to display login button
    /// </summary>
    [ViewComponent(Name = FacebookAuthenticationDefaults.VIEW_COMPONENT_NAME)]
    public class FacebookAuthenticationViewComponent : SmiViewComponent
    {
        /// <summary>
        /// Invoke view component
        /// </summary>
        /// <param name="widgetZone">Widget zone name</param>
        /// <param name="additionalData">Additional data</param>
        /// <returns>View component result</returns>
        public IViewComponentResult Invoke(string widgetZone, object additionalData)
        {
            return View("~/Plugins/ExternalAuth.Facebook/Views/PublicInfo.cshtml");
        }
    }
}