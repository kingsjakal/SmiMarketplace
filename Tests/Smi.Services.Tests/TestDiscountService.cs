﻿using System;
using System.Collections.Generic;
using System.Linq;
using Moq;
using Smi.Core;
using Smi.Core.Caching;
using Smi.Data;
using Smi.Core.Domain.Customers;
using Smi.Core.Domain.Discounts;
using Smi.Core.Domain.Orders;
using Smi.Core.Domain.Stores;
using Smi.Services.Caching;
using Smi.Services.Catalog;
using Smi.Services.Customers;
using Smi.Services.Discounts;
using Smi.Services.Events;
using Smi.Services.Localization;
using Smi.Services.Tests.FakeServices;
using Smi.Tests;

namespace Smi.Services.Tests
{
    public class TestDiscountService : DiscountService
    {
        private readonly List<Discount> _discounts;

        public TestDiscountService(ICacheKeyService cacheKeyService,
            ICustomerService customerService,
            IDiscountPluginManager discountPluginManager,
            IEventPublisher eventPublisher,
            ILocalizationService localizationService,
            IProductService productService,
            IRepository<Discount> discountRepository,
            IRepository<DiscountRequirement> discountRequirementRepository,
            IRepository<DiscountUsageHistory> discountUsageHistoryRepository,
            IRepository<Order> orderRepository,
            IStaticCacheManager staticCacheManager,
            IStoreContext storeContext) : base(
            cacheKeyService,
            customerService,
            discountPluginManager,
            eventPublisher,
            localizationService,
            productService,
            discountRepository,
            discountRequirementRepository,
            discountUsageHistoryRepository,
            orderRepository,
            staticCacheManager,
            storeContext)
        {
            _discounts = new List<Discount>();
        }

        public override DiscountValidationResult ValidateDiscount(Discount discount, Customer customer)
        {
            return new DiscountValidationResult { IsValid = true };
        }

        public override IList<Discount> GetAllDiscounts(DiscountType? discountType = null,
            string couponCode = null, string discountName = null, bool showHidden = false,
            DateTime? startDateUtc = null, DateTime? endDateUtc = null)
        {
            return _discounts
                .Where(x => !discountType.HasValue || x.DiscountType == discountType.Value)
                .Where(x => string.IsNullOrEmpty(couponCode) || x.CouponCode == couponCode)
                //UNDONE other filtering such as discountName, showHidden (not actually required in unit tests)
                .ToList();
        }

        public void AddDiscount(DiscountType discountType)
        {
            _discounts.Clear();

            //discounts
            var discount = new Discount
            {
                Id = 1,
                Name = "Discount 1",
                DiscountType = discountType,
                DiscountAmount = 3,
                DiscountLimitation = DiscountLimitationType.Unlimited
            };

            _discounts.Add(discount);
        }

        public void ClearDiscount()
        {
            _discounts.Clear();
        }

        public static IDiscountService Init(IQueryable<Discount> discounts = default, IQueryable<DiscountProductMapping> productDiscountMapping = null)
        {
            var staticCacheManager = new TestCacheManager();
            var discountRepo = new Mock<IRepository<Discount>>();

            discountRepo.Setup(r => r.Table).Returns(discounts);

            var discountRequirementRepo = new Mock<IRepository<DiscountRequirement>>();
            discountRequirementRepo.Setup(x => x.Table).Returns(new List<DiscountRequirement>().AsQueryable());
            var discountUsageHistoryRepo = new Mock<IRepository<DiscountUsageHistory>>();

            var discountMappingRepo = new Mock<IRepository<DiscountMapping>>();

            discountMappingRepo.Setup(x => x.Table).Returns(productDiscountMapping);

            var customerService = new Mock<ICustomerService>();
            var localizationService = new Mock<ILocalizationService>();
            var productService = new Mock<IProductService>();

            var eventPublisher = new Mock<IEventPublisher>();
           
            var pluginService = new FakePluginService();

            var discountPluginManager = new DiscountPluginManager(new FakeCacheKeyService(), customerService.Object, pluginService);
            var store = new Store { Id = 1 };
            var storeContext = new Mock<IStoreContext>();
            storeContext.Setup(x => x.CurrentStore).Returns(store);

            var orderRepo = new Mock<IRepository<Order>>();

            var discountService = new TestDiscountService(
                new FakeCacheKeyService(),
                customerService.Object,
                discountPluginManager,
                eventPublisher.Object,
                localizationService.Object,
                productService.Object,
                discountRepo.Object,
                discountRequirementRepo.Object,
                discountUsageHistoryRepo.Object,
                orderRepo.Object,
                staticCacheManager,
                storeContext.Object);

            return discountService;
        }
    }
}
