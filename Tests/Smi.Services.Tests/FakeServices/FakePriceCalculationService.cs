using Moq;
using Smi.Core;
using Smi.Core.Caching;
using Smi.Core.Domain.Catalog;
using Smi.Core.Domain.Directory;
using Smi.Services.Caching;
using Smi.Services.Catalog;
using Smi.Services.Customers;
using Smi.Services.Directory;
using Smi.Services.Discounts;
using Smi.Tests;

namespace Smi.Services.Tests.FakeServices
{
    public class FakePriceCalculationService : PriceCalculationService
    {
        public FakePriceCalculationService(CatalogSettings catalogSettings = null,
            CurrencySettings currencySettings = null,
            ICacheKeyService cacheKeyService = null,
            ICategoryService categoryService = null,
            ICurrencyService currencyService = null,
            ICustomerService customerService = null,
            IDiscountService discountService = null,
            IManufacturerService manufacturerService = null,
            IProductAttributeParser productAttributeParser = null,
            IProductService productService = null,
            IStaticCacheManager staticCacheManager = null,
            IStoreContext storeContext = null,
            IWorkContext workContext = null) : base(
                catalogSettings ?? new CatalogSettings(),
                currencySettings ?? new CurrencySettings(),
                cacheKeyService ?? new FakeCacheKeyService(),
                categoryService ?? new Mock<ICategoryService>().Object,
                currencyService ?? new Mock<ICurrencyService>().Object,
                customerService ?? new Mock<ICustomerService>().Object,
                discountService ?? new Mock<IDiscountService>().Object,
                manufacturerService ?? new Mock<IManufacturerService>().Object,
                productAttributeParser ?? new Mock<IProductAttributeParser>().Object,
                productService ?? new Mock<IProductService>().Object,
                staticCacheManager ?? new TestCacheManager(),
                storeContext ?? new Mock<IStoreContext>().Object,
                workContext ?? new Mock<IWorkContext>().Object)
        {
        }
    }
}
