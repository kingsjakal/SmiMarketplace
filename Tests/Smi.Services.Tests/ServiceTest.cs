using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;
using Moq;
using Smi.Core;
using Smi.Core.Infrastructure;
using Smi.Services.Plugins;
using Smi.Services.Tests.Directory;
using Smi.Services.Tests.Discounts;
using Smi.Services.Tests.Payments;
using Smi.Services.Tests.Shipping;
using Smi.Services.Tests.Tax;
using Smi.Tests;
using NUnit.Framework;

namespace Smi.Services.Tests
{
    [TestFixture]
    public abstract class ServiceTest
    {
        protected readonly FakeDataStore _fakeDataStore = new FakeDataStore();

        [SetUp]
        public virtual void SetUp()
        {
           
        }

        public void RunWithTestServiceProvider(Action action)
        {
            var SmiEngine = new Mock<SmiEngine>();
            SmiEngine.Setup(x => x.ServiceProvider).Returns(new TestServiceProvider());
            EngineContext.Replace(SmiEngine.Object);

            action();

            EngineContext.Replace(null);
        }
        
        protected ServiceTest()
        {
            //init plugins
            InitPlugins();
        }

        private void InitPlugins()
        {
            var webHostEnvironment = new Mock<IWebHostEnvironment>();
            webHostEnvironment.Setup(x => x.ContentRootPath).Returns(System.Reflection.Assembly.GetExecutingAssembly().Location);
            webHostEnvironment.Setup(x => x.WebRootPath).Returns(System.IO.Directory.GetCurrentDirectory());
            CommonHelper.DefaultFileProvider = new SmiFileProvider(webHostEnvironment.Object);

            Singleton<IPluginsInfo>.Instance = new PluginsInfo(CommonHelper.DefaultFileProvider)
            {
                PluginDescriptors = new List<PluginDescriptor>
                {
                    new PluginDescriptor(typeof(FixedRateTestTaxProvider).Assembly)
                    {
                        PluginType = typeof(FixedRateTestTaxProvider),
                        SystemName = "FixedTaxRateTest",
                        FriendlyName = "Fixed tax test rate provider",
                        Installed = true
                    },
                    new PluginDescriptor(typeof(FixedRateTestShippingRateComputationMethod).Assembly)
                    {
                        PluginType = typeof(FixedRateTestShippingRateComputationMethod),
                        SystemName = "FixedRateTestShippingRateComputationMethod",
                        FriendlyName = "Fixed rate test shipping computation method",
                        Installed = true
                    },
                    new PluginDescriptor(typeof(TestPaymentMethod).Assembly)
                    {
                        PluginType = typeof(TestPaymentMethod),
                        SystemName = "Payments.TestMethod",
                        FriendlyName = "Test payment method",
                        Installed = true
                    },
                    new PluginDescriptor(typeof(TestDiscountRequirementRule).Assembly)
                    {
                        PluginType = typeof(TestDiscountRequirementRule),
                        SystemName = "TestDiscountRequirementRule",
                        FriendlyName = "Test discount requirement rule",
                        Installed = true
                    },
                    new PluginDescriptor(typeof(TestExchangeRateProvider).Assembly)
                    {
                        PluginType = typeof(TestExchangeRateProvider),
                        SystemName = "CurrencyExchange.TestProvider",
                        FriendlyName = "Test exchange rate provider",
                        Installed = true
                    }
                }
            };
        }
    }
}
