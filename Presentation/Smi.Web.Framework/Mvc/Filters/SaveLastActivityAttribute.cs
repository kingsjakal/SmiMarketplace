﻿using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Smi.Core;
using Smi.Core.Domain.Customers;
using Smi.Data;
using Smi.Services.Customers;

namespace Smi.Web.Framework.Mvc.Filters
{
    /// <summary>
    /// Represents filter attribute that saves last customer activity date
    /// </summary>
    public sealed class SaveLastActivityAttribute : TypeFilterAttribute
    {
        #region Ctor

        /// <summary>
        /// Create instance of the filter attribute
        /// </summary>
        public SaveLastActivityAttribute() : base(typeof(SaveLastActivityFilter))
        {
        }
        
        #endregion

        #region Nested filter

        /// <summary>
        /// Represents a filter that saves last customer activity date
        /// </summary>
        private class SaveLastActivityFilter : IActionFilter
        {
            #region Fields

            private readonly CustomerSettings _customerSettings;
            private readonly ICustomerService _customerService;
            private readonly IWorkContext _workContext;

            #endregion

            #region Ctor

            public SaveLastActivityFilter(CustomerSettings customerSettings,
                ICustomerService customerService,
                IWorkContext workContext)
            {
                _customerSettings = customerSettings;
                _customerService = customerService;
                _workContext = workContext;
            }

            #endregion

            #region Methods

            /// <summary>
            /// Called before the action executes, after model binding is complete
            /// </summary>
            /// <param name="context">A context for action filters</param>
            public void OnActionExecuting(ActionExecutingContext context)
            {
                if (context == null)
                    throw new ArgumentNullException(nameof(context));

                if (context.HttpContext.Request == null)
                    return;

                //only in GET requests
                if (!context.HttpContext.Request.Method.Equals(WebRequestMethods.Http.Get, StringComparison.InvariantCultureIgnoreCase))
                    return;

                if (!DataSettingsManager.DatabaseIsInstalled)
                    return;

                //update last activity date
                if (_workContext.CurrentCustomer.LastActivityDateUtc.AddMinutes(_customerSettings.LastActivityMinutes) < DateTime.UtcNow)
                {
                    _workContext.CurrentCustomer.LastActivityDateUtc = DateTime.UtcNow;
                    _customerService.UpdateCustomer(_workContext.CurrentCustomer);
                }
            }

            /// <summary>
            /// Called after the action executes, before the action result
            /// </summary>
            /// <param name="context">A context for action filters</param>
            public void OnActionExecuted(ActionExecutedContext context)
            {
                //do nothing
            }

            #endregion
        }

        #endregion
    }
}