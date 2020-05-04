﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Reports
{
    /// <summary>
    /// Represents a country report search model
    /// </summary>
    public partial class CountryReportSearchModel : BaseSearchModel
    {
        #region Ctor

        public CountryReportSearchModel()
        {
            AvailableOrderStatuses = new List<SelectListItem>();
            AvailablePaymentStatuses = new List<SelectListItem>();
        }

        #endregion

        #region Properties

        [SmiResourceDisplayName("Admin.Reports.Sales.Country.StartDate")]
        [UIHint("DateNullable")]
        public DateTime? StartDate { get; set; }

        [SmiResourceDisplayName("Admin.Reports.Sales.Country.EndDate")]
        [UIHint("DateNullable")]
        public DateTime? EndDate { get; set; }

        [SmiResourceDisplayName("Admin.Reports.Sales.Country.OrderStatus")]
        public int OrderStatusId { get; set; }

        [SmiResourceDisplayName("Admin.Reports.Sales.Country.PaymentStatus")]
        public int PaymentStatusId { get; set; }

        public IList<SelectListItem> AvailableOrderStatuses { get; set; }

        public IList<SelectListItem> AvailablePaymentStatuses { get; set; }

        #endregion
    }
}