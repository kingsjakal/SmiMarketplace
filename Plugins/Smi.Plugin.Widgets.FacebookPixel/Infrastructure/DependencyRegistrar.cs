using Autofac;
using Smi.Core.Configuration;
using Smi.Core.Infrastructure;
using Smi.Core.Infrastructure.DependencyManagement;
using Smi.Plugin.Widgets.FacebookPixel.Services;

namespace Smi.Plugin.Widgets.FacebookPixel.Infrastructure
{
    /// <summary>
    /// Represents a plugin dependency registrar
    /// </summary>
    public class DependencyRegistrar : IDependencyRegistrar
    {
        /// <summary>
        /// Register services and interfaces
        /// </summary>
        /// <param name="builder">Container builder</param>
        /// <param name="typeFinder">Type finder</param>
        /// <param name="config">Config</param>
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder, SmiConfig config)
        {
            builder.RegisterType<FacebookPixelService>().AsSelf().InstancePerLifetimeScope();
        }

        /// <summary>
        /// Order of this dependency registrar implementation
        /// </summary>
        public int Order => 1;
    }
}