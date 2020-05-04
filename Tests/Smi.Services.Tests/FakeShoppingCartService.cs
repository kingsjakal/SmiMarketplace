using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Moq;
using Smi.Core;
using Smi.Core.Caching;
using Smi.Core.Domain.Catalog;
using Smi.Core.Domain.Orders;
using Smi.Data;
using Smi.Services.Caching;
using Smi.Services.Catalog;
using Smi.Services.Common;
using Smi.Services.Customers;
using Smi.Services.Directory;
using Smi.Services.Events;
using Smi.Services.Helpers;
using Smi.Services.Localization;
using Smi.Services.Orders;
using Smi.Services.Security;
using Smi.Services.Seo;
using Smi.Services.Shipping;
using Smi.Services.Shipping.Date;
using Smi.Services.Stores;
using Smi.Tests;

namespace Smi.Services.Tests
{
    public class FakeShoppingCartService : ShoppingCartService
    {
        public FakeShoppingCartService(CatalogSettings catalogSettings = null,
            IAclService aclService = null,
            IActionContextAccessor actionContextAccessor = null,  
            ICacheKeyService cacheKeyService = null,
            ICheckoutAttributeParser checkoutAttributeParser = null,
            ICheckoutAttributeService checkoutAttributeService = null,
            ICurrencyService currencyService = null,
            ICustomerService customerService = null,
            IDateRangeService dateRangeService = null,
            IDateTimeHelper dateTimeHelper = null,
            IEventPublisher eventPublisher = null,
            IGenericAttributeService genericAttributeService = null,
            ILocalizationService localizationService = null,
            IPermissionService permissionService = null,
            IPriceCalculationService priceCalculationService = null,
            IPriceFormatter priceFormatter = null,
            IProductAttributeParser productAttributeParser = null,
            IProductAttributeService productAttributeService = null,
            IProductService productService = null,
            IRepository<ShoppingCartItem> sciRepository = null,
            IShippingService shippingService = null,
            IStaticCacheManager staticCacheManager = null,
            IStoreContext storeContext = null,
            IStoreMappingService storeMappingService = null,
            IUrlHelperFactory urlHelperFactory = null,
            IUrlRecordService urlRecordService = null,
            IWorkContext workContext = null,
            OrderSettings orderSettings = null,
            ShoppingCartSettings shoppingCartSettings = null) : base(
            catalogSettings ?? new CatalogSettings(),
                aclService ?? new Mock<IAclService>().Object,
                actionContextAccessor ?? new Mock<IActionContextAccessor>().Object,    
                cacheKeyService ?? new FakeCacheKeyService(),
                checkoutAttributeParser ?? new Mock<ICheckoutAttributeParser>().Object,
                checkoutAttributeService ?? new Mock<ICheckoutAttributeService>().Object,
                currencyService ?? new Mock<ICurrencyService>().Object,
                customerService ?? new Mock<ICustomerService>().Object,
                dateRangeService ?? new Mock<IDateRangeService>().Object,
                dateTimeHelper ?? new Mock<IDateTimeHelper>().Object,
                eventPublisher ?? new Mock<IEventPublisher>().Object,
                genericAttributeService ?? new Mock<IGenericAttributeService>().Object,
                localizationService ?? new Mock<ILocalizationService>().Object,
                permissionService ?? new Mock<IPermissionService>().Object,
                priceCalculationService ?? new Mock<IPriceCalculationService>().Object,
                priceFormatter ?? new Mock<IPriceFormatter>().Object,
                productAttributeParser ?? new Mock<IProductAttributeParser>().Object,
                productAttributeService ?? new Mock<IProductAttributeService>().Object,
                productService ?? new Mock<IProductService>().Object,
                sciRepository.FakeRepoNullPropagation(),
                shippingService ?? new Mock<IShippingService>().Object,
                staticCacheManager ?? new TestCacheManager(),
                storeContext ?? new Mock<IStoreContext>().Object,
                storeMappingService ?? new Mock<IStoreMappingService>().Object,
                urlHelperFactory ?? new Mock<IUrlHelperFactory>().Object,
                urlRecordService ?? new Mock<IUrlRecordService>().Object,
                workContext ?? new Mock<IWorkContext>().Object,
                orderSettings ?? new OrderSettings(),
                shoppingCartSettings ?? new ShoppingCartSettings())
        {
        }
    }
}
