using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Smi.Web.Framework;
using Smi.Web.Framework.Mvc.Routing;

namespace Smi.Plugin.Tax.Avalara.Infrastructure
{
    /// <summary>
    /// Represents plugin route provider
    /// </summary>
    public class RouteProvider : IRouteProvider
    {
        /// <summary>
        /// Register routes
        /// </summary>
        /// <param name="endpointRouteBuilder">Route builder</param>
        public void RegisterRoutes(IEndpointRouteBuilder endpointRouteBuilder)
        {
            endpointRouteBuilder.MapControllerRoute(AvalaraTaxDefaults.ConfigurationRouteName, "Plugins/Avalara/Configure",
                new { controller = "Avalara", action = "Configure", area = AreaNames.Admin });

            //override some of default routes in Admin area
            endpointRouteBuilder.MapControllerRoute("Plugin.Tax.Avalara.Tax.Categories", "Admin/Tax/Categories",
                new { controller = "AvalaraTax", action = "Categories", area = AreaNames.Admin });
        }

        /// <summary>
        /// Gets a priority of route provider
        /// </summary>
        public int Priority => 1; //set a value that is greater than the default one in Smi.Web to override routes
    }
}