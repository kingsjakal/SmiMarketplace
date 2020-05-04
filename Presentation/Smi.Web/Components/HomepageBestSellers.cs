using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Smi.Core;
using Smi.Core.Caching;
using Smi.Core.Domain.Catalog;
using Smi.Services.Caching;
using Smi.Services.Catalog;
using Smi.Services.Orders;
using Smi.Services.Security;
using Smi.Services.Stores;
using Smi.Web.Factories;
using Smi.Web.Framework.Components;
using Smi.Web.Infrastructure.Cache;

namespace Smi.Web.Components
{
    public class HomepageBestSellersViewComponent : SmiViewComponent
    {
        private readonly CatalogSettings _catalogSettings;
        private readonly IAclService _aclService;
        private readonly ICacheKeyService _cacheKeyService;
        private readonly IOrderReportService _orderReportService;
        private readonly IProductModelFactory _productModelFactory;
        private readonly IProductService _productService;
        private readonly IStaticCacheManager _staticCacheManager;
        private readonly IStoreContext _storeContext;
        private readonly IStoreMappingService _storeMappingService;

        public HomepageBestSellersViewComponent(CatalogSettings catalogSettings,
            IAclService aclService,
            ICacheKeyService cacheKeyService,
            IOrderReportService orderReportService,
            IProductModelFactory productModelFactory,
            IProductService productService,
            IStaticCacheManager staticCacheManager,
            IStoreContext storeContext,
            IStoreMappingService storeMappingService)
        {
            _catalogSettings = catalogSettings;
            _aclService = aclService;
            _cacheKeyService = cacheKeyService;
            _orderReportService = orderReportService;
            _productModelFactory = productModelFactory;
            _productService = productService;
            _staticCacheManager = staticCacheManager;
            _storeContext = storeContext;
            _storeMappingService = storeMappingService;
        }

        public IViewComponentResult Invoke(int? productThumbPictureSize)
        {
            if (!_catalogSettings.ShowBestsellersOnHomepage || _catalogSettings.NumberOfBestsellersOnHomepage == 0)
                return Content("");

            //load and cache report
            var report = _staticCacheManager.Get(_cacheKeyService.PrepareKeyForDefaultCache(SmiModelCacheDefaults.HomepageBestsellersIdsKey, _storeContext.CurrentStore),
                () => _orderReportService.BestSellersReport(
                        storeId: _storeContext.CurrentStore.Id,
                        pageSize: _catalogSettings.NumberOfBestsellersOnHomepage)
                    .ToList());

            //load products
            var products = _productService.GetProductsByIds(report.Select(x => x.ProductId).ToArray());
            //ACL and store mapping
            products = products.Where(p => _aclService.Authorize(p) && _storeMappingService.Authorize(p)).ToList();
            //availability dates
            products = products.Where(p => _productService.ProductIsAvailable(p)).ToList();

            if (!products.Any())
                return Content("");

            //prepare model
            var model = _productModelFactory.PrepareProductOverviewModels(products, true, true, productThumbPictureSize).ToList();
            return View(model);
        }
    }
}