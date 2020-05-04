using System;
using Microsoft.AspNetCore.Mvc;
using Smi.Core;
using Smi.Core.Domain.Orders;
using Smi.Services.Catalog;
using Smi.Web.Factories;
using Smi.Web.Framework.Components;
using Smi.Web.Models.Catalog;

namespace Smi.Web.Components
{
    /// <summary>
    /// Represents a estimate shipping view component on product page
    /// </summary>
    public class ProductEstimateShippingViewComponent : SmiViewComponent
    {
        private readonly IShoppingCartModelFactory _shoppingCartModelFactory;
        private readonly IProductService _productService;
        private readonly IStoreContext _storeContext;
        private readonly IWorkContext _workContext;

        public ProductEstimateShippingViewComponent(IShoppingCartModelFactory shoppingCartModelFactory,
            IProductService productService,
            IStoreContext storeContext,
            IWorkContext workContext)
        {
            _shoppingCartModelFactory = shoppingCartModelFactory;
            _productService = productService;
            _storeContext = storeContext;
            _workContext = workContext;
        }

        public IViewComponentResult Invoke(int productId)
        {
            var product = _productService.GetProductById(productId);
            if (product == null)
                return Content("");

            var wrappedProduct = new ShoppingCartItem()
            {
                StoreId = _storeContext.CurrentStore.Id,
                ShoppingCartTypeId = (int)ShoppingCartType.ShoppingCart,
                CustomerId = _workContext.CurrentCustomer.Id,
                ProductId = product.Id,
                CreatedOnUtc = DateTime.UtcNow
            };

            var model = _shoppingCartModelFactory.PrepareEstimateShippingModel(new[] { wrappedProduct });
            if (!model.Enabled)
                return Content("");

            var wrappedModel = new ProductEstimateShippingModel()
            {
                ProductId = product.Id,
                Enabled = model.Enabled,
                CountryId = model.CountryId,
                StateProvinceId = model.StateProvinceId,
                ZipPostalCode = model.ZipPostalCode,
                AvailableCountries = model.AvailableCountries,
                AvailableStates = model.AvailableStates
            };

            return View(wrappedModel);
        }
    }
}
