using Autofac;
using Smi.Core.Configuration;
using Smi.Core.Infrastructure;
using Smi.Core.Infrastructure.DependencyManagement;
using Smi.Plugin.Misc.SendinBlue.Services;
using Smi.Services.Messages;

namespace Smi.Plugin.Misc.SendinBlue.Infrastructure
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
        public void Register(ContainerBuilder builder, ITypeFinder typeFinder, SmiConfig config)
        {
            //register custom services
            builder.RegisterType<SendinBlueManager>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<SendinBlueMarketingAutomationManager>().AsSelf().InstancePerLifetimeScope();

            //override services
            builder.RegisterType<SendinBlueMessageService>().As<IWorkflowMessageService>().InstancePerLifetimeScope();
            builder.RegisterType<SendinBlueEmailSender>().As<IEmailSender>().InstancePerLifetimeScope();
        }

        /// <summary>
        /// Order of this dependency registrar implementation
        /// </summary>
        public int Order => 2;
    }
}