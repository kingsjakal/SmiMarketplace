using Autofac;
using Smi.Core.Configuration;
using Smi.Core.Infrastructure;
using Smi.Core.Infrastructure.DependencyManagement;
using Smi.Plugin.Pickup.PickupInStore.Factories;
using Smi.Plugin.Pickup.PickupInStore.Services;

namespace Smi.Plugin.Pickup.PickupInStore.Infrastructure
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
            builder.RegisterType<StorePickupPointService>().As<IStorePickupPointService>().InstancePerLifetimeScope();
            builder.RegisterType<StorePickupPointModelFactory>().As<IStorePickupPointModelFactory>().InstancePerLifetimeScope();
        }

        /// <summary>
        /// Order of this dependency registrar implementation
        /// </summary>
        public int Order => 1;
    }
}