using Moq;
using Smi.Core;
using Smi.Core.Infrastructure;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Tests;
using Smi.Web.Areas.Admin.Validators.Common;
using NUnit.Framework;

namespace Smi.Web.MVC.Tests.Public.Validators
{
    [TestFixture]
    public abstract class BaseValidatorTests
    {
        protected ILocalizationService _localizationService;
        private Mock<ISmiDataProvider> _dataProvider;
        protected Mock<IWorkContext> _workContext;
        
        [SetUp]
        public void Setup()
        {
            var SmiEngine = new Mock<SmiEngine>();
            var serviceProvider = new TestServiceProvider();
            SmiEngine.Setup(x => x.ServiceProvider).Returns(serviceProvider);
            _dataProvider = new Mock<ISmiDataProvider>();
            _localizationService = serviceProvider.LocalizationService.Object;
            SmiEngine.Setup(x => x.ResolveUnregistered(typeof(AddressValidator))).Returns(new AddressValidator(_localizationService, _dataProvider.Object));
            EngineContext.Replace(SmiEngine.Object);
        }
    }
}
