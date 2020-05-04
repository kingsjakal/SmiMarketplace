using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Smi.Core;
using Smi.Core.Domain.Orders;
using Smi.Services.Orders;
using Smi.Web.Factories;
using Smi.Web.Framework.Components;
using Smi.Web.Models.ShoppingCart;

namespace Smi.Web.Components
{
    public class OrderSummaryViewComponent : SmiViewComponent
    {
        private readonly IShoppingCartModelFactory _shoppingCartModelFactory;
        private readonly IShoppingCartService _shoppingCartService;
        private readonly IStoreContext _storeContext;
        private readonly IWorkContext _workContext;

        public OrderSummaryViewComponent(IShoppingCartModelFactory shoppingCartModelFactory,
            IShoppingCartService shoppingCartService,
            IStoreContext storeContext,
            IWorkContext workContext)
        {
            _shoppingCartModelFactory = shoppingCartModelFactory;
            _shoppingCartService = shoppingCartService;
            _storeContext = storeContext;
            _workContext = workContext;
        }

        public IViewComponentResult Invoke(bool? prepareAndDisplayOrderReviewData, ShoppingCartModel overriddenModel)
        {
            //use already prepared (shared) model
            if (overriddenModel != null)
                return View(overriddenModel);

            //if not passed, then create a new model
            var cart = _shoppingCartService.GetShoppingCart(_workContext.CurrentCustomer, ShoppingCartType.ShoppingCart, _storeContext.CurrentStore.Id);

            var model = new ShoppingCartModel();
            model = _shoppingCartModelFactory.PrepareShoppingCartModel(model, cart,
                isEditable: false,
                prepareAndDisplayOrderReviewData: prepareAndDisplayOrderReviewData.GetValueOrDefault());
            return View(model);
        }
    }
}
