using Moq;
using Smi.Core;
using Smi.Core.Caching;
using Smi.Core.Domain.Catalog;
using Smi.Core.Domain.Common;
using Smi.Core.Domain.Discounts;
using Smi.Core.Domain.Localization;
using Smi.Core.Domain.Security;
using Smi.Core.Domain.Shipping;
using Smi.Core.Domain.Stores;
using Smi.Data;
using Smi.Services.Caching;
using Smi.Services.Catalog;
using Smi.Services.Customers;
using Smi.Services.Events;
using Smi.Services.Localization;
using Smi.Services.Security;
using Smi.Services.Shipping.Date;
using Smi.Services.Stores;
using Smi.Tests;

namespace Smi.Services.Tests
{
    public class FakeProductService : ProductService
    {
        public FakeProductService(CatalogSettings catalogSettings = null,
            CommonSettings commonSettings = null,
            IAclService aclService = null,
            ICacheKeyService cacheKeyService = null,
            ICustomerService customerService = null,
            ISmiDataProvider dataProvider = null,
            IDateRangeService dateRangeService = null,
            IEventPublisher eventPublisher = null,
            ILanguageService languageService = null,
            ILocalizationService localizationService = null,
            IProductAttributeParser productAttributeParser = null,
            IProductAttributeService productAttributeService = null,
            IRepository<AclRecord> aclRepository = null,
            IRepository<CrossSellProduct> crossSellProductRepository = null,
            IRepository<DiscountProductMapping> discountProductMappingRepository = null,
            IRepository<Product> productRepository = null,
            IRepository<ProductAttributeCombination> productAttributeCombinationRepository = null,
            IRepository<ProductAttributeMapping> productAttributeMappingRepository = null,
            IRepository<ProductCategory> productCategoryRepository = null,
            IRepository<ProductPicture> productPictureRepository = null,
            IRepository<ProductReview> productReviewRepository = null,
            IRepository<ProductReviewHelpfulness> productReviewHelpfulnessRepository = null,
            IRepository<ProductWarehouseInventory> productWarehouseInventoryRepository = null,
            IRepository<RelatedProduct> relatedProductRepository = null,
            IRepository<Shipment> shipmentRepository = null,
            IRepository<StockQuantityHistory> stockQuantityHistoryRepository = null,
            IRepository<StoreMapping> storeMappingRepository = null,
            IRepository<TierPrice> tierPriceRepository = null,
            IRepository<Warehouse> warehouseRepository = null,
            IStaticCacheManager staticCacheManager = null,
            IStoreService storeService = null,
            IStoreMappingService storeMappingService = null,
            IWorkContext workContext = null,
            LocalizationSettings localizationSettings = null) : base(
                catalogSettings ?? new CatalogSettings(),
                commonSettings ?? new CommonSettings(),
                aclService ?? new Mock<IAclService>().Object,
                cacheKeyService ?? new FakeCacheKeyService(),
                customerService ?? new Mock<ICustomerService>().Object,
                dataProvider ?? new Mock<ISmiDataProvider>().Object,
                dateRangeService ?? new Mock<IDateRangeService>().Object,
                eventPublisher ?? new Mock<IEventPublisher>().Object,
                languageService ?? new Mock<ILanguageService>().Object,
                localizationService ?? new Mock<ILocalizationService>().Object,
                productAttributeParser ?? new Mock<IProductAttributeParser>().Object,
                productAttributeService ?? new Mock<IProductAttributeService>().Object,
                aclRepository.FakeRepoNullPropagation(),
                crossSellProductRepository.FakeRepoNullPropagation(),
                discountProductMappingRepository.FakeRepoNullPropagation(),
                productRepository.FakeRepoNullPropagation(),
                productAttributeCombinationRepository.FakeRepoNullPropagation(),
                productAttributeMappingRepository.FakeRepoNullPropagation(),
                productCategoryRepository.FakeRepoNullPropagation(),
                productPictureRepository.FakeRepoNullPropagation(),
                productReviewRepository.FakeRepoNullPropagation(),
                productReviewHelpfulnessRepository.FakeRepoNullPropagation(),
                productWarehouseInventoryRepository.FakeRepoNullPropagation(),
                relatedProductRepository.FakeRepoNullPropagation(),
                shipmentRepository.FakeRepoNullPropagation(),
                stockQuantityHistoryRepository.FakeRepoNullPropagation(),
                storeMappingRepository.FakeRepoNullPropagation(),
                tierPriceRepository.FakeRepoNullPropagation(),
                warehouseRepository.FakeRepoNullPropagation(),
                staticCacheManager ?? new TestCacheManager(),
                storeService ?? new Mock<IStoreService>().Object,
                storeMappingService ?? new Mock<IStoreMappingService>().Object,
                workContext ?? new Mock<IWorkContext>().Object,
                localizationSettings ?? new LocalizationSettings())
        {
        }
    }
}
