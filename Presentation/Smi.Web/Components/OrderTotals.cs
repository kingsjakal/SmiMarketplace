using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Smi.Core;
using Smi.Core.Domain.Orders;
using Smi.Services.Orders;
using Smi.Web.Factories;
using Smi.Web.Framework.Components;

namespace Smi.Web.Components
{
    public class OrderTotalsViewComponent : SmiViewComponent
    {
        private readonly IShoppingCartModelFactory _shoppingCartModelFactory;
        private readonly IShoppingCartService _shoppingCartService;
        private readonly IStoreContext _storeContext;
        private readonly IWorkContext _workContext;

        public OrderTotalsViewComponent(IShoppingCartModelFactory shoppingCartModelFactory,
            IShoppingCartService shoppingCartService,
            IStoreContext storeContext,
            IWorkContext workContext)
        {
            _shoppingCartModelFactory = shoppingCartModelFactory;
            _shoppingCartService = shoppingCartService;
            _storeContext = storeContext;
            _workContext = workContext;
        }

        public IViewComponentResult Invoke(bool isEditable)
        {
            var cart = _shoppingCartService.GetShoppingCart(_workContext.CurrentCustomer, ShoppingCartType.ShoppingCart, _storeContext.CurrentStore.Id);

            var model = _shoppingCartModelFactory.PrepareOrderTotalsModel(cart, isEditable);
            return View(model);
        }
    }
}
