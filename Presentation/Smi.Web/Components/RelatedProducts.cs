using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Smi.Services.Catalog;
using Smi.Services.Security;
using Smi.Services.Stores;
using Smi.Web.Factories;
using Smi.Web.Framework.Components;

namespace Smi.Web.Components
{
    public class RelatedProductsViewComponent : SmiViewComponent
    {
        private readonly IAclService _aclService;
        private readonly IProductModelFactory _productModelFactory;
        private readonly IProductService _productService;
        private readonly IStoreMappingService _storeMappingService;

        public RelatedProductsViewComponent(IAclService aclService,
            IProductModelFactory productModelFactory,
            IProductService productService,
            IStoreMappingService storeMappingService)
        {
            _aclService = aclService;
            _productModelFactory = productModelFactory;
            _productService = productService;
            _storeMappingService = storeMappingService;
        }

        public IViewComponentResult Invoke(int productId, int? productThumbPictureSize)
        {
            //load and cache report
            var productIds = _productService.GetRelatedProductsByProductId1(productId).Select(x => x.ProductId2).ToArray();

            //load products
            var products = _productService.GetProductsByIds(productIds);
            //ACL and store mapping
            products = products.Where(p => _aclService.Authorize(p) && _storeMappingService.Authorize(p)).ToList();
            //availability dates
            products = products.Where(p => _productService.ProductIsAvailable(p)).ToList();
            //visible individually
            products = products.Where(p => p.VisibleIndividually).ToList();

            if (!products.Any())
                return Content(string.Empty);

            var model = _productModelFactory.PrepareProductOverviewModels(products, true, true, productThumbPictureSize).ToList();
            return View(model);
        }
    }
}