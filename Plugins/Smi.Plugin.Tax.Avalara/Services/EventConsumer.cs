using System;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using Smi.Core;
using Smi.Core.Domain.Orders;
using Smi.Core.Events;
using Smi.Services.Catalog;
using Smi.Services.Common;
using Smi.Services.Customers;
using Smi.Services.Events;
using Smi.Services.Orders;
using Smi.Services.Security;
using Smi.Services.Tax;
using Smi.Web.Areas.Admin.Models.Catalog;
using Smi.Web.Areas.Admin.Models.Customers;
using Smi.Web.Areas.Admin.Models.Orders;
using Smi.Web.Framework.Events;
using Smi.Web.Framework.Models;

namespace Smi.Plugin.Tax.Avalara.Services
{
    /// <summary>
    /// Represents plugin event consumer
    /// </summary>
    public class EventConsumer :
        IConsumer<EntityDeletedEvent<Order>>,
        IConsumer<ModelReceivedEvent<BaseSmiModel>>,
        IConsumer<OrderCancelledEvent>,
        IConsumer<OrderPlacedEvent>,
        IConsumer<OrderRefundedEvent>,
        IConsumer<OrderVoidedEvent>
    {
        #region Fields

        private readonly AvalaraTaxManager _avalaraTaxManager;
        private readonly ICheckoutAttributeService _checkoutAttributeService;
        private readonly ICustomerService _customerService;
        private readonly IGenericAttributeService _genericAttributeService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IPermissionService _permissionService;
        private readonly IProductService _productService;
        private readonly ITaxPluginManager _taxPluginManager;

        #endregion

        #region Ctor

        public EventConsumer(AvalaraTaxManager avalaraTaxManager,
            ICheckoutAttributeService checkoutAttributeService,
            ICustomerService customerService,
            IGenericAttributeService genericAttributeService,
            IHttpContextAccessor httpContextAccessor,
            IPermissionService permissionService,
            IProductService productService,
            ITaxPluginManager taxPluginManager)
        {
            _avalaraTaxManager = avalaraTaxManager;
            _checkoutAttributeService = checkoutAttributeService;
            _customerService = customerService;
            _genericAttributeService = genericAttributeService;
            _httpContextAccessor = httpContextAccessor;
            _permissionService = permissionService;
            _productService = productService;
            _taxPluginManager = taxPluginManager;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Handle model received event
        /// </summary>
        /// <param name="eventMessage">Event message</param>
        public void HandleEvent(ModelReceivedEvent<BaseSmiModel> eventMessage)
        {
            //get entity by received model
            var entity = eventMessage.Model switch
            {
                CustomerModel customerModel => (BaseEntity)_customerService.GetCustomerById(customerModel.Id),
                CustomerRoleModel customerRoleModel => _customerService.GetCustomerRoleById(customerRoleModel.Id),
                ProductModel productModel => _productService.GetProductById(productModel.Id),
                CheckoutAttributeModel checkoutAttributeModel => _checkoutAttributeService.GetCheckoutAttributeById(checkoutAttributeModel.Id),
                _ => null
            };
            if (entity == null)
                return;

            //ensure that Avalara tax provider is active
            if (!_taxPluginManager.IsPluginActive(AvalaraTaxDefaults.SystemName))
                return;

            if (!_permissionService.Authorize(StandardPermissionProvider.ManageTaxSettings))
                return;

            //whether there is a form value for the entity use code
            if (_httpContextAccessor.HttpContext.Request.Form.TryGetValue(AvalaraTaxDefaults.EntityUseCodeAttribute, out var entityUseCodeValue)
                && !StringValues.IsNullOrEmpty(entityUseCodeValue))
            {
                //save attribute
                var entityUseCode = !entityUseCodeValue.ToString().Equals(Guid.Empty.ToString()) ? entityUseCodeValue.ToString() : null;
                _genericAttributeService.SaveAttribute(entity, AvalaraTaxDefaults.EntityUseCodeAttribute, entityUseCode);
            }
        }

        /// <summary>
        /// Handle order placed event
        /// </summary>
        /// <param name="eventMessage">Event message</param>
        public void HandleEvent(OrderPlacedEvent eventMessage)
        {
            if (eventMessage.Order == null)
                return;

            //ensure that Avalara tax provider is active
            if (!_taxPluginManager.IsPluginActive(AvalaraTaxDefaults.SystemName))
                return;

            //create tax transaction
            _avalaraTaxManager.CreateOrderTaxTransaction(eventMessage.Order);
        }

        /// <summary>
        /// Handle order refunded event
        /// </summary>
        /// <param name="eventMessage">Event message</param>
        public void HandleEvent(OrderRefundedEvent eventMessage)
        {
            if (eventMessage.Order == null)
                return;

            //ensure that Avalara tax provider is active
            if (!_taxPluginManager.IsPluginActive(AvalaraTaxDefaults.SystemName))
                return;

            //refund tax transaction
            _avalaraTaxManager.RefundTaxTransaction(eventMessage.Order, eventMessage.Amount);
        }

        /// <summary>
        /// Handle order voided event
        /// </summary>
        /// <param name="eventMessage">Event message</param>
        public void HandleEvent(OrderVoidedEvent eventMessage)
        {
            if (eventMessage.Order == null)
                return;

            //ensure that Avalara tax provider is active
            if (!_taxPluginManager.IsPluginActive(AvalaraTaxDefaults.SystemName))
                return;

            //void tax transaction
            _avalaraTaxManager.VoidTaxTransaction(eventMessage.Order);
        }

        /// <summary>
        /// Handle order cancelled event
        /// </summary>
        /// <param name="eventMessage">Event message</param>
        public void HandleEvent(OrderCancelledEvent eventMessage)
        {
            if (eventMessage.Order == null)
                return;

            //ensure that Avalara tax provider is active
            if (!_taxPluginManager.IsPluginActive(AvalaraTaxDefaults.SystemName))
                return;

            //void tax transaction
            _avalaraTaxManager.VoidTaxTransaction(eventMessage.Order);
        }

        /// <summary>
        /// Handle order deleted event
        /// </summary>
        /// <param name="eventMessage">Event message</param>
        public void HandleEvent(EntityDeletedEvent<Order> eventMessage)
        {
            if (eventMessage.Entity == null)
                return;

            //ensure that Avalara tax provider is active
            if (!_taxPluginManager.IsPluginActive(AvalaraTaxDefaults.SystemName))
                return;

            //delete tax transaction
            _avalaraTaxManager.DeleteTaxTransaction(eventMessage.Entity);
        }

        #endregion
    }
}