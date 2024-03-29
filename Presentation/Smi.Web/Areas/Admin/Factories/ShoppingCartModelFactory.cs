﻿using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smi.Core.Domain.Catalog;
using Smi.Core.Domain.Customers;
using Smi.Core.Domain.Orders;
using Smi.Services.Catalog;
using Smi.Services.Customers;
using Smi.Services.Directory;
using Smi.Services.Helpers;
using Smi.Services.Localization;
using Smi.Services.Orders;
using Smi.Services.Stores;
using Smi.Services.Tax;
using Smi.Web.Areas.Admin.Infrastructure.Mapper.Extensions;
using Smi.Web.Areas.Admin.Models.ShoppingCart;
using Smi.Web.Framework.Extensions;
using Smi.Web.Framework.Models.Extensions;

namespace Smi.Web.Areas.Admin.Factories
{
    /// <summary>
    /// Represents the shopping cart model factory implementation
    /// </summary>
    public partial class ShoppingCartModelFactory : IShoppingCartModelFactory
    {
        #region Fields

        private readonly CatalogSettings _catalogSettings;
        private readonly IBaseAdminModelFactory _baseAdminModelFactory;
        private readonly ICountryService _countryService;
        private readonly ICustomerService _customerService;
        private readonly IDateTimeHelper _dateTimeHelper;
        private readonly ILocalizationService _localizationService;
        private readonly IPriceFormatter _priceFormatter;
        private readonly IProductAttributeFormatter _productAttributeFormatter;
        private readonly IProductService _productService;
        private readonly IShoppingCartService _shoppingCartService;
        private readonly IStoreService _storeService;
        private readonly ITaxService _taxService;

        #endregion

        #region Ctor

        public ShoppingCartModelFactory(CatalogSettings catalogSettings,
            IBaseAdminModelFactory baseAdminModelFactory,
            ICountryService countryService,
            ICustomerService customerService,
            IDateTimeHelper dateTimeHelper,
            ILocalizationService localizationService,
            IPriceFormatter priceFormatter,
            IProductAttributeFormatter productAttributeFormatter,
            IProductService productService,
            IShoppingCartService shoppingCartService,
            IStoreService storeService,
            ITaxService taxService)
        {
            _catalogSettings = catalogSettings;
            _baseAdminModelFactory = baseAdminModelFactory;
            _countryService = countryService;
            _customerService = customerService;
            _dateTimeHelper = dateTimeHelper;
            _localizationService = localizationService;
            _priceFormatter = priceFormatter;
            _productAttributeFormatter = productAttributeFormatter;
            _productService = productService;
            _shoppingCartService = shoppingCartService;
            _storeService = storeService;
            _taxService = taxService;
        }

        #endregion

        #region Utilities

        /// <summary>
        /// Prepare shopping cart item search model
        /// </summary>
        /// <param name="searchModel">Shopping cart item search model</param>
        /// <returns>Shopping cart item search model</returns>
        protected virtual ShoppingCartItemSearchModel PrepareShoppingCartItemSearchModel(ShoppingCartItemSearchModel searchModel)
        {
            if (searchModel == null)
                throw new ArgumentNullException(nameof(searchModel));

            //prepare page parameters
            searchModel.SetGridPageSize();

            return searchModel;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Prepare shopping cart search model
        /// </summary>
        /// <param name="searchModel">Shopping cart search model</param>
        /// <returns>Shopping cart search model</returns>
        public virtual ShoppingCartSearchModel PrepareShoppingCartSearchModel(ShoppingCartSearchModel searchModel)
        {
            if (searchModel == null)
                throw new ArgumentNullException(nameof(searchModel));

            //prepare available shopping cart types
            _baseAdminModelFactory.PrepareShoppingCartTypes(searchModel.AvailableShoppingCartTypes, false);

            //set default search values
            searchModel.ShoppingCartType = ShoppingCartType.ShoppingCart;

            //prepare available billing countries
            searchModel.AvailableCountries = _countryService.GetAllCountriesForBilling(showHidden: true)
                .Select(country => new SelectListItem { Text = country.Name, Value = country.Id.ToString() }).ToList();
            searchModel.AvailableCountries.Insert(0, new SelectListItem { Text = _localizationService.GetResource("Admin.Common.All"), Value = "0" });

            //prepare available stores
            _baseAdminModelFactory.PrepareStores(searchModel.AvailableStores);

            searchModel.HideStoresList = _catalogSettings.IgnoreStoreLimitations || searchModel.AvailableStores.SelectionIsNotPossible();

            //prepare nested search model
            PrepareShoppingCartItemSearchModel(searchModel.ShoppingCartItemSearchModel);

            //prepare page parameters
            searchModel.SetGridPageSize();

            return searchModel;
        }

        /// <summary>
        /// Prepare paged shopping cart list model
        /// </summary>
        /// <param name="searchModel">Shopping cart search model</param>
        /// <returns>Shopping cart list model</returns>
        public virtual ShoppingCartListModel PrepareShoppingCartListModel(ShoppingCartSearchModel searchModel)
        {
            if (searchModel == null)
                throw new ArgumentNullException(nameof(searchModel));

            //get customers with shopping carts
            var customers = _customerService.GetCustomersWithShoppingCarts(searchModel.ShoppingCartType,
                storeId: searchModel.StoreId,
                productId: searchModel.ProductId,
                createdFromUtc: searchModel.StartDate,
                createdToUtc: searchModel.EndDate,
                countryId: searchModel.BillingCountryId,
                pageIndex: searchModel.Page - 1, pageSize: searchModel.PageSize);

            //prepare list model
            var model = new ShoppingCartListModel().PrepareToGrid(searchModel, customers, () =>
            {
                return customers.Select(customer =>
                {
                    //fill in model values from the entity
                    var shoppingCartModel = new ShoppingCartModel
                    {
                        CustomerId = customer.Id
                    };

                    //fill in additional values (not existing in the entity)
                    shoppingCartModel.CustomerEmail = _customerService.IsRegistered(customer)
                        ? customer.Email : _localizationService.GetResource("Admin.Customers.Guest");
                    shoppingCartModel.TotalItems = _shoppingCartService.GetShoppingCart(customer, searchModel.ShoppingCartType,
                        searchModel.StoreId, searchModel.ProductId, searchModel.StartDate, searchModel.EndDate).Sum(item => item.Quantity);

                    return shoppingCartModel;
                });
            });

            return model;
        }

        /// <summary>
        /// Prepare paged shopping cart item list model
        /// </summary>
        /// <param name="searchModel">Shopping cart item search model</param>
        /// <param name="customer">Customer</param>
        /// <returns>Shopping cart item list model</returns>
        public virtual ShoppingCartItemListModel PrepareShoppingCartItemListModel(ShoppingCartItemSearchModel searchModel, Customer customer)
        {
            if (searchModel == null)
                throw new ArgumentNullException(nameof(searchModel));

            if (customer == null)
                throw new ArgumentNullException(nameof(customer));

            //get shopping cart items
            var items = _shoppingCartService.GetShoppingCart(customer, searchModel.ShoppingCartType,
                searchModel.StoreId, searchModel.ProductId, searchModel.StartDate, searchModel.EndDate).ToPagedList(searchModel);
            
            var isSearchProduct = searchModel.ProductId > 0;

            Product product = null;

            if (isSearchProduct)
            {
                product = _productService.GetProductById(searchModel.ProductId) ?? throw new Exception("Product is not found");
            }

            //prepare list model
            var model = new ShoppingCartItemListModel().PrepareToGrid(searchModel, items, () =>
            {
                return items.Select(item =>
                {
                    //fill in model values from the entity
                    var itemModel = item.ToModel<ShoppingCartItemModel>();

                    if (!isSearchProduct)
                        product = _productService.GetProductById(item.ProductId);

                    //convert dates to the user time
                    itemModel.UpdatedOn = _dateTimeHelper.ConvertToUserTime(item.UpdatedOnUtc, DateTimeKind.Utc);

                    //fill in additional values (not existing in the entity)
                    itemModel.Store = _storeService.GetStoreById(item.StoreId)?.Name ?? "Deleted";
                    itemModel.AttributeInfo = _productAttributeFormatter.FormatAttributes(product, item.AttributesXml, customer);
                    var unitPrice = _shoppingCartService.GetUnitPrice(item);
                    itemModel.UnitPrice = _priceFormatter.FormatPrice(_taxService.GetProductPrice(product, unitPrice, out var _));
                    var subTotal = _shoppingCartService.GetSubTotal(item);
                    itemModel.Total = _priceFormatter.FormatPrice(_taxService.GetProductPrice(product, subTotal, out _));

                    //set product name since it does not survive mapping
                    itemModel.ProductName = product.Name;

                    return itemModel;
                });
            });

            return model;
        }

        #endregion
    }
}