using Microsoft.AspNetCore.Mvc;
using Smi.Core;
using Smi.Core.Domain.Orders;
using Smi.Services.Orders;
using Smi.Web.Factories;
using Smi.Web.Framework.Components;

namespace Smi.Web.Components
{
    /// <summary>
    /// Represents a estimate shipping view component on shopping cart page
    /// </summary>
    public class ShoppingCartEstimateShippingViewComponent : SmiViewComponent
    {
        private readonly IShoppingCartModelFactory _shoppingCartModelFactory;
        private readonly IShoppingCartService _shoppingCartService;
        private readonly IStoreContext _storeContext;
        private readonly IWorkContext _workContext;

        public ShoppingCartEstimateShippingViewComponent(IShoppingCartModelFactory shoppingCartModelFactory,
            IShoppingCartService shoppingCartService,
            IStoreContext storeContext,
            IWorkContext workContext)
        {
            _shoppingCartModelFactory = shoppingCartModelFactory;
            _shoppingCartService = shoppingCartService;
            _storeContext = storeContext;
            _workContext = workContext;
        }

        public IViewComponentResult Invoke(bool? prepareAndDisplayOrderReviewData)
        {
            var cart = _shoppingCartService.GetShoppingCart(_workContext.CurrentCustomer, ShoppingCartType.ShoppingCart, _storeContext.CurrentStore.Id);

            var model = _shoppingCartModelFactory.PrepareEstimateShippingModel(cart);
            if (!model.Enabled)
                return Content("");

            return View(model);
        }
    }
}
