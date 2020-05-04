using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Smi.Core.Infrastructure;
using Smi.Web.Framework.Infrastructure.Extensions;

namespace Smi.Web.Framework.Infrastructure
{
    /// <summary>
    /// Represents object for the configuring MVC on application startup
    /// </summary>
    public class SmiMvcStartup : ISmiStartup
    {
        /// <summary>
        /// Add and configure any of the middleware
        /// </summary>
        /// <param name="services">Collection of service descriptors</param>
        /// <param name="configuration">Configuration of the application</param>
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            //add MiniProfiler services
            services.AddSmiMiniProfiler();

            //add WebMarkupMin services to the services container
            services.AddSmiWebMarkupMin();

            //add and configure MVC feature
            services.AddSmiMvc();

            //add custom redirect result executor
            services.AddSmiRedirectResultExecutor();
        }

        /// <summary>
        /// Configure the using of added middleware
        /// </summary>
        /// <param name="application">Builder for configuring an application's request pipeline</param>
        public void Configure(IApplicationBuilder application)
        {
            //use MiniProfiler
            application.UseMiniProfiler();

            //use WebMarkupMin
            application.UseSmiWebMarkupMin();

            //Endpoints routing
            application.UseSmiEndpoints();
        }

        /// <summary>
        /// Gets order of this startup configuration implementation
        /// </summary>
        public int Order => 1000; //MVC should be loaded last
    }
}