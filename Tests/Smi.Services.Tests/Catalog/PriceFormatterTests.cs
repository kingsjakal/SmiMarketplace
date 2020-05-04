﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using FluentAssertions;
using Moq;
using Smi.Core;
using Smi.Data;
using Smi.Core.Domain.Directory;
using Smi.Core.Domain.Localization;
using Smi.Core.Domain.Tax;
using Smi.Core.Infrastructure;
using Smi.Services.Catalog;
using Smi.Services.Customers;
using Smi.Services.Directory;
using Smi.Services.Events;
using Smi.Services.Localization;
using Smi.Services.Stores;
using Smi.Services.Tests.FakeServices;
using Smi.Tests;
using NUnit.Framework;

namespace Smi.Services.Tests.Catalog
{
    [TestFixture]
    public class PriceFormatterTests : ServiceTest
    {
        private Mock<IRepository<Currency>> _currencyRepo;
        private Mock<IEventPublisher> _eventPublisher;
        private Mock<IStoreMappingService> _storeMappingService;
        private Mock<IMeasureService> _measureService;
        private IExchangeRatePluginManager _exchangeRatePluginManager;
        private ICurrencyService _currencyService;
        private CurrencySettings _currencySettings;
        private Mock<IWorkContext> _workContext;
        private Mock<ILocalizationService> _localizationService;
        private TaxSettings _taxSettings;
        private IPriceFormatter _priceFormatter;

        [SetUp]
        public new void SetUp()
        {
            _workContext = new Mock<IWorkContext>();
            _workContext.Setup(w => w.WorkingCurrency).Returns(new Currency { RoundingType = RoundingType.Rounding001 });

            _currencySettings = new CurrencySettings();
            var currency1 = new Currency
            {
                Id = 1,
                Name = "Euro",
                CurrencyCode = "EUR",
                DisplayLocale = "",
                CustomFormatting = "€0.00",
                DisplayOrder = 1,
                Published = true,
                CreatedOnUtc = DateTime.UtcNow,
                UpdatedOnUtc = DateTime.UtcNow
            };
            var currency2 = new Currency
            {
                Id = 1,
                Name = "US Dollar",
                CurrencyCode = "USD",
                DisplayLocale = "en-US",
                CustomFormatting = "",
                DisplayOrder = 2,
                Published = true,
                CreatedOnUtc = DateTime.UtcNow,
                UpdatedOnUtc = DateTime.UtcNow
            };
            _currencyRepo = new Mock<IRepository<Currency>>();
            _currencyRepo.Setup(x => x.Table).Returns(new List<Currency> { currency1, currency2 }.AsQueryable());

            _storeMappingService = new Mock<IStoreMappingService>();
            _measureService = new Mock<IMeasureService>();

            _eventPublisher = new Mock<IEventPublisher>();
            _eventPublisher.Setup(x => x.Publish(It.IsAny<object>()));

            var pluginService = new FakePluginService();
            _exchangeRatePluginManager = new ExchangeRatePluginManager(_currencySettings, new FakeCacheKeyService(), new Mock<ICustomerService>().Object, pluginService);
            _currencyService = new CurrencyService(_currencySettings,
                new FakeCacheKeyService(),
                null,
                _exchangeRatePluginManager,
                _currencyRepo.Object,
                _storeMappingService.Object);

            _taxSettings = new TaxSettings();

            _localizationService = new Mock<ILocalizationService>();
            _localizationService.Setup(x => x.GetResource("Products.InclTaxSuffix", 1, false, string.Empty, false)).Returns("{0} incl tax");
            _localizationService.Setup(x => x.GetResource("Products.ExclTaxSuffix", 1, false, string.Empty, false)).Returns("{0} excl tax");

            _priceFormatter = new PriceFormatter(_currencySettings, _currencyService, _localizationService.Object,
                _measureService.Object, _workContext.Object, _taxSettings);

            var SmiEngine = new Mock<SmiEngine>();

            SmiEngine.Setup(x => x.ServiceProvider).Returns(new TestServiceProvider());
            EngineContext.Replace(SmiEngine.Object);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            EngineContext.Replace(null);
        }

        [Test]
        public void Can_formatPrice_with_custom_currencyFormatting()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

            var currency = new Currency
            {
                Id = 1,
                Name = "Euro",
                CurrencyCode = "EUR",
                DisplayLocale = "",
                CustomFormatting = "€0.00"
            };
            var language = new Language
            {
                Id = 1,
                Name = "English",
                LanguageCulture = "en-US"
            };
            _priceFormatter.FormatPrice(1234.5M, false, currency, language.Id, false, false).Should().Be("€1234.50");
        }

        [Test]
        public void Can_formatPrice_with_distinct_currencyDisplayLocale()
        {
            var usd_currency = new Currency
            {
                Id = 1,
                Name = "US Dollar",
                CurrencyCode = "USD",
                DisplayLocale = "en-US"
            };
            var gbp_currency = new Currency
            {
                Id = 2,
                Name = "great british pound",
                CurrencyCode = "GBP",
                DisplayLocale = "en-GB"
            };
            var language = new Language
            {
                Id = 1,
                Name = "English",
                LanguageCulture = "en-US"
            };
            _priceFormatter.FormatPrice(1234.5M, false, usd_currency, language.Id, false, false).Should().Be("$1,234.50");
            _priceFormatter.FormatPrice(1234.5M, false, gbp_currency, language.Id, false, false).Should().Be("£1,234.50");
        }

        [Test]
        public void Can_formatPrice_with_showTax()
        {
            var currency = new Currency
            {
                Id = 1,
                Name = "US Dollar",
                CurrencyCode = "USD",
                DisplayLocale = "en-US"
            };
            var language = new Language
            {
                Id = 1,
                Name = "English",
                LanguageCulture = "en-US"
            };
            _priceFormatter.FormatPrice(1234.5M, false, currency, language.Id, true, true).Should().Be("$1,234.50 incl tax");
            _priceFormatter.FormatPrice(1234.5M, false, currency, language.Id, false, true).Should().Be("$1,234.50 excl tax");

        }

        [Test]
        public void Can_formatPrice_with_showCurrencyCode()
        {
            var currency = new Currency
            {
                Id = 1,
                Name = "US Dollar",
                CurrencyCode = "USD",
                DisplayLocale = "en-US"
            };
            var language = new Language
            {
                Id = 1,
                Name = "English",
                LanguageCulture = "en-US"
            };
            _currencySettings.DisplayCurrencyLabel = true;
            _priceFormatter.FormatPrice(1234.5M, true, currency, language.Id, false, false).Should().Be("$1,234.50 (USD)");

            _currencySettings.DisplayCurrencyLabel = false;
            _priceFormatter.FormatPrice(1234.5M, true, currency, language.Id, false, false).Should().Be("$1,234.50");
        }
    }
}