using Moq;
using Smi.Core;
using Smi.Core.Domain.Catalog;
using Smi.Core.Infrastructure;
using Smi.Data.Migrations;
using Smi.Services.Customers;
using Smi.Services.Logging;
using Smi.Services.Plugins;
using Smi.Tests;

namespace Smi.Services.Tests.FakeServices
{
    public class FakePluginService : PluginService
    {
        public FakePluginService(
            CatalogSettings catalogSettings = null,
            ICustomerService customerService = null,
            IMigrationManager migrationManager = null,
            ILogger logger = null,
            ISmiFileProvider fileProvider = null,
            IWebHelper webHelper = null) : base(
            catalogSettings ?? new CatalogSettings(),
            customerService ?? new Mock<ICustomerService>().Object,
            migrationManager ?? new Mock<IMigrationManager>().Object,
            logger ?? new NullLogger(),
            fileProvider ?? CommonHelper.DefaultFileProvider,
            webHelper ?? new Mock<IWebHelper>().Object)
        {
        }
    }
}
