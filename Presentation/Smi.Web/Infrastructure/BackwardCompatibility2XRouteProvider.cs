using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Smi.Core.Domain.Common;
using Smi.Core.Infrastructure;
using Smi.Data;
using Smi.Web.Framework.Mvc.Routing;

namespace Smi.Web.Infrastructure
{
    /// <summary>
    /// Represents provider that provided routes used for backward compatibility with 2.x versions of SmiMarketplace
    /// </summary>
    public partial class BackwardCompatibility2XRouteProvider : IRouteProvider
    {
        #region Methods

        /// <summary>
        /// Register routes
        /// </summary>
        /// <param name="endpointRouteBuilder">Route builder</param>
        public void RegisterRoutes(IEndpointRouteBuilder endpointRouteBuilder)
        {
            if (DataSettingsManager.DatabaseIsInstalled && !EngineContext.Current.Resolve<CommonSettings>().SupportPreviousSmiMarketplaceVersions)
                return;

            //products
            endpointRouteBuilder.MapControllerRoute("", "p/{productId:min(0)}/{SeName?}",
                new { controller = "BackwardCompatibility2X", action = "RedirectProductById" });

            //categories
            endpointRouteBuilder.MapControllerRoute("", "c/{categoryId:min(0)}/{SeName?}",
                new { controller = "BackwardCompatibility2X", action = "RedirectCategoryById" });

            //manufacturers
            endpointRouteBuilder.MapControllerRoute("", "m/{manufacturerId:min(0)}/{SeName?}",
                new { controller = "BackwardCompatibility2X", action = "RedirectManufacturerById" });

            //news
            endpointRouteBuilder.MapControllerRoute("", "news/{newsItemId:min(0)}/{SeName?}",
                new { controller = "BackwardCompatibility2X", action = "RedirectNewsItemById" });

            //blog
            endpointRouteBuilder.MapControllerRoute("", "blog/{blogPostId:min(0)}/{SeName?}",
                new { controller = "BackwardCompatibility2X", action = "RedirectBlogPostById" });

            //topic
            endpointRouteBuilder.MapControllerRoute("", "t/{SystemName}",
                new { controller = "BackwardCompatibility2X", action = "RedirectTopicBySystemName" });

            //vendors
            endpointRouteBuilder.MapControllerRoute("", "vendor/{vendorId:min(0)}/{SeName?}",
                new { controller = "BackwardCompatibility2X", action = "RedirectVendorById" });

            //product tags
            endpointRouteBuilder.MapControllerRoute("", "producttag/{productTagId:min(0)}/{SeName?}",
                new { controller = "BackwardCompatibility2X", action = "RedirectProductTagById" });
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets a priority of route provider
        /// </summary>
        public int Priority => -1000; //register it after all other IRouteProvider are processed

        #endregion
    }
}