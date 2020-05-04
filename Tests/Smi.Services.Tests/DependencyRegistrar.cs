using Autofac;
using Smi.Core.Caching;
using Smi.Core.Configuration;
using Smi.Core.Infrastructure;
using Smi.Core.Infrastructure.DependencyManagement;
using Smi.Tests;

namespace Smi.Services.Tests
{
    /// <summary>
    /// Dependency registrar
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
            //cache managers
            builder.RegisterType<TestCacheManager>().As<IStaticCacheManager>().Named<IStaticCacheManager>("Smi_cache_static").SingleInstance();

        }

        /// <summary>
        /// Order of this dependency registrar implementation
        /// </summary>
        public int Order => 0;
    }

}
