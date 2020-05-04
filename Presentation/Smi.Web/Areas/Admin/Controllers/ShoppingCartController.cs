using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Smi.Core;
using Smi.Services.Catalog;
using Smi.Services.Customers;
using Smi.Services.Orders;
using Smi.Services.Security;
using Smi.Web.Areas.Admin.Factories;
using Smi.Web.Areas.Admin.Models.ShoppingCart;
using Smi.Web.Framework.Mvc;

namespace Smi.Web.Areas.Admin.Controllers
{
    public partial class ShoppingCartController : BaseAdminController
    {
        #region Fields

        private readonly ICustomerService _customerService;
        private readonly IPermissionService _permissionService;
        private readonly IProductService _productService;
        private readonly IShoppingCartModelFactory _shoppingCartModelFactory;
        private readonly IShoppingCartService _shoppingCartService;
        private readonly IWorkContext _workContext;
        #endregion

        #region Ctor

        public ShoppingCartController(ICustomerService customerService,
            IPermissionService permissionService,
            IProductService productService,
            IShoppingCartService shoppingCartService,
            IShoppingCartModelFactory shoppingCartModelFactory,
            IWorkContext workContext)
        {
            _customerService = customerService;
            _permissionService = permissionService;
            _productService = productService;
            _shoppingCartModelFactory = shoppingCartModelFactory;
            _shoppingCartService = shoppingCartService;
            _workContext = workContext;
        }

        #endregion
        
        #region Methods
        
        public virtual IActionResult CurrentCarts()
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManageCurrentCarts))
                return AccessDeniedView();

            //prepare model
            var model = _shoppingCartModelFactory.PrepareShoppingCartSearchModel(new ShoppingCartSearchModel());

            return View(model);
        }

        [HttpPost]
        public virtual IActionResult CurrentCarts(ShoppingCartSearchModel searchModel)
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManageCurrentCarts))
                return AccessDeniedDataTablesJson();

            //prepare model
            var model = _shoppingCartModelFactory.PrepareShoppingCartListModel(searchModel);

            return Json(model);
        }

        [HttpPost]
        public virtual IActionResult GetCartDetails(ShoppingCartItemSearchModel searchModel)
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManageCurrentCarts))
                return AccessDeniedDataTablesJson();

            //try to get a customer with the specified id
            var customer = _customerService.GetCustomerById(searchModel.CustomerId)
                ?? throw new ArgumentException("No customer found with the specified id");

            //prepare model
            var model = _shoppingCartModelFactory.PrepareShoppingCartItemListModel(searchModel, customer);

            return Json(model);
        }
        
        [HttpPost]
        public virtual IActionResult DeleteItem(int id)
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManageCurrentCarts))
                return AccessDeniedDataTablesJson();
            
            _shoppingCartService.DeleteShoppingCartItem(id);

            return new NullJsonResult();
        }

        #endregion
    }
}