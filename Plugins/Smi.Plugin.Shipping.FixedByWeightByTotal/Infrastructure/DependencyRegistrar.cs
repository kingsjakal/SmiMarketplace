using Autofac;
using Smi.Core.Configuration;
using Smi.Core.Infrastructure;
using Smi.Core.Infrastructure.DependencyManagement;
using Smi.Plugin.Shipping.FixedByWeightByTotal.Services;

namespace Smi.Plugin.Shipping.FixedByWeightByTotal.Infrastructure
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
            builder.RegisterType<ShippingByWeightByTotalService>().As<IShippingByWeightByTotalService>().InstancePerLifetimeScope();
        }

        /// <summary>
        /// Order of this dependency registrar implementation
        /// </summary>
        public int Order => 1;
    }
}