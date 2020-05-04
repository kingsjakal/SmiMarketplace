using Moq;
using Smi.Core;
using Smi.Core.Caching;
using Smi.Data;
using Smi.Core.Domain.Discounts;
using Smi.Core.Domain.Orders;
using Smi.Services.Caching;
using Smi.Services.Catalog;
using Smi.Services.Customers;
using Smi.Services.Discounts;
using Smi.Services.Events;
using Smi.Services.Localization;
using Smi.Tests;

namespace Smi.Services.Tests.FakeServices
{
    public class FakeDiscountService : DiscountService
    {
        public FakeDiscountService(ICacheKeyService cacheKeyService = null,
            ICustomerService customerService = null,
            IDiscountPluginManager discountPluginManager = null,
            IEventPublisher eventPublisher = null,
            ILocalizationService localizationService = null,
            IProductService productService = null,
            IRepository<Discount> discountRepository = null,
            IRepository<DiscountRequirement> discountRequirementRepository = null,
            IRepository<DiscountUsageHistory> discountUsageHistoryRepository = null,
            IRepository<Order> orderRepository = null,
            IStaticCacheManager staticCacheManager = null,
            IStoreContext storeContext = null) : base(
                cacheKeyService ?? new FakeCacheKeyService(),
                customerService ?? new Mock<ICustomerService>().Object,
                discountPluginManager ?? new Mock<IDiscountPluginManager>().Object,
                eventPublisher ?? new Mock<IEventPublisher>().Object,
                localizationService ?? new Mock<ILocalizationService>().Object,
                productService ?? new Mock<IProductService>().Object,
                discountRepository.FakeRepoNullPropagation(),
                discountRequirementRepository.FakeRepoNullPropagation(),
                discountUsageHistoryRepository.FakeRepoNullPropagation(),
                orderRepository.FakeRepoNullPropagation(),
                staticCacheManager ?? new TestCacheManager(),
                storeContext ?? new Mock<IStoreContext>().Object)
        {
        }
    }
}
