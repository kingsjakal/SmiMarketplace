﻿using System;
using Microsoft.AspNetCore.Http;
using Moq;
using Smi.Core;
using Smi.Core.Caching;
using Smi.Core.Domain.Catalog;
using Smi.Core.Domain.Customers;
using Smi.Core.Domain.Directory;
using Smi.Core.Domain.Discounts;
using Smi.Core.Domain.Localization;
using Smi.Data;
using Smi.Services.Caching;
using Smi.Services.Catalog;
using Smi.Services.Common;
using Smi.Services.Customers;
using Smi.Services.Directory;
using Smi.Services.Discounts;
using Smi.Services.Localization;
using Smi.Services.Seo;

namespace Smi.Tests
{
    public class TestServiceProvider : IServiceProvider
    {
        public TestServiceProvider()
        {
            LocalizationService = new Mock<ILocalizationService>();
            GenericAttributeService = new Mock<IGenericAttributeService>();
            WorkContext = new Mock<IWorkContext>();

            DiscountCategoryMappingRepository = new Mock<IRepository<DiscountCategoryMapping>>();
            DiscountManufacturerMappingRepository = new Mock<IRepository<DiscountManufacturerMapping>>();
            DiscountProductMappingRepository = new Mock<IRepository<DiscountProductMapping>>();

            PriceCalculationService = new PriceCalculationService(new CatalogSettings(), new CurrencySettings(),
                new Mock<ICacheKeyService>().Object, new Mock<ICategoryService>().Object,
                new Mock<ICurrencyService>().Object, new Mock<ICustomerService>().Object,
                new Mock<IDiscountService>().Object, new Mock<IManufacturerService>().Object,
                new Mock<IProductAttributeParser>().Object, new Mock<IProductService>().Object,
                new TestCacheManager(), new Mock<IStoreContext>().Object, WorkContext.Object);

            LocalizationService.Setup(l => l.GetResource(It.IsAny<string>())).Returns("Invalid");
            WorkContext.Setup(p => p.WorkingLanguage).Returns(new Language { Id = 1 });
            WorkContext.Setup(w => w.WorkingCurrency).Returns(new Currency { RoundingType = RoundingType.Rounding001 });

            CurrencyService = new Mock<ICurrencyService>();
            CurrencyService.Setup(x => x.GetCurrencyById(1)).Returns(new Currency { Id = 1, RoundingTypeId = 0 });

            GenericAttributeService.Setup(p => p.GetAttribute(It.IsAny<Customer>(), "product-advanced-mode", It.IsAny<int>(), false))
                .Returns(true);

            GenericAttributeService.Setup(p => p.GetAttribute(It.IsAny<Customer>(), "manufacturer-advanced-mode", It.IsAny<int>(), false))
                .Returns(true);

            GenericAttributeService.Setup(p => p.GetAttribute(It.IsAny<Customer>(), "category-advanced-mode", It.IsAny<int>(), false))
                .Returns(true);

            GenericAttributeService.Setup(x => x.GetAttribute<string>(It.IsAny<Customer>(), SmiCustomerDefaults.SelectedPaymentMethodAttribute, It.IsAny<int>(), null))
                .Returns("test1");
        }

        public Mock<ILocalizationService> LocalizationService { get; }
        public Mock<IWorkContext> WorkContext { get; }
        public Mock<IGenericAttributeService> GenericAttributeService { get; }
        public IPriceCalculationService PriceCalculationService { get; }
        public Mock<ICurrencyService> CurrencyService { get; }

        public Mock<IRepository<DiscountCategoryMapping>> DiscountCategoryMappingRepository { get; }
        public Mock<IRepository<DiscountManufacturerMapping>> DiscountManufacturerMappingRepository { get; }
        public Mock<IRepository<DiscountProductMapping>> DiscountProductMappingRepository { get; }

        public virtual object GetService(Type serviceType)
        {
            if (serviceType == typeof(IHttpContextAccessor))
                return new Mock<IHttpContextAccessor>().Object;

            if (serviceType == typeof(ILocalizationService))
                return LocalizationService.Object;

            if (serviceType == typeof(IWorkContext))
                return WorkContext.Object;

            if (serviceType == typeof(CurrencySettings))
                return new CurrencySettings { PrimaryStoreCurrencyId = 1 };

            if (serviceType == typeof(CatalogSettings))
                return new CatalogSettings();

            if (serviceType == typeof(ICurrencyService))
                return CurrencyService.Object;

            if (serviceType == typeof(IUrlRecordService))
                return new Mock<IUrlRecordService>().Object;

            if (serviceType == typeof(IGenericAttributeService))
                return GenericAttributeService.Object;

            if (serviceType == typeof(IPriceCalculationService))
                return PriceCalculationService;

            if (serviceType == typeof(IStaticCacheManager))
                return new TestCacheManager();

            if (serviceType == typeof(IRepository<DiscountCategoryMapping>))
                return DiscountCategoryMappingRepository.Object;

            if (serviceType == typeof(IRepository<DiscountManufacturerMapping>))
                return DiscountManufacturerMappingRepository.Object;

            if (serviceType == typeof(IRepository<DiscountProductMapping>))
                return DiscountProductMappingRepository.Object;

            if (serviceType == typeof(ICacheKeyService))
                return new FakeCacheKeyService();

            return null;
        }
    }
}
