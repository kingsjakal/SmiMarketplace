﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Customers
{
    /// <summary>
    /// Represents a customer role model
    /// </summary>
    public partial class CustomerRoleModel : BaseSmiEntityModel
    {
        #region Ctor

        public CustomerRoleModel()
        {
            TaxDisplayTypeValues = new List<SelectListItem>();
        }

        #endregion

        #region Properties

        [SmiResourceDisplayName("Admin.Customers.CustomerRoles.Fields.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.Customers.CustomerRoles.Fields.FreeShipping")]
        public bool FreeShipping { get; set; }

        [SmiResourceDisplayName("Admin.Customers.CustomerRoles.Fields.TaxExempt")]
        public bool TaxExempt { get; set; }

        [SmiResourceDisplayName("Admin.Customers.CustomerRoles.Fields.Active")]
        public bool Active { get; set; }

        [SmiResourceDisplayName("Admin.Customers.CustomerRoles.Fields.IsSystemRole")]
        public bool IsSystemRole { get; set; }

        [SmiResourceDisplayName("Admin.Customers.CustomerRoles.Fields.SystemName")]
        public string SystemName { get; set; }

        [SmiResourceDisplayName("Admin.Customers.CustomerRoles.Fields.EnablePasswordLifetime")]
        public bool EnablePasswordLifetime { get; set; }

        [SmiResourceDisplayName("Admin.Customers.CustomerRoles.Fields.OverrideTaxDisplayType")]
        public bool OverrideTaxDisplayType { get; set; }

        [SmiResourceDisplayName("Admin.Customers.CustomerRoles.Fields.DefaultTaxDisplayType")]
        public int DefaultTaxDisplayTypeId { get; set; }

        public IList<SelectListItem> TaxDisplayTypeValues { get; set; }

        [SmiResourceDisplayName("Admin.Customers.CustomerRoles.Fields.PurchasedWithProduct")]
        public int PurchasedWithProductId { get; set; }

        [SmiResourceDisplayName("Admin.Customers.CustomerRoles.Fields.PurchasedWithProduct")]
        public string PurchasedWithProductName { get; set; }

        #endregion
    }
}