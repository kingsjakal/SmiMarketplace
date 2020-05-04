using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Discounts
{
    /// <summary>
    /// Represents a discount search model
    /// </summary>
    public partial class DiscountSearchModel : BaseSearchModel
    {
        #region Ctor

        public DiscountSearchModel()
        {
            AvailableDiscountTypes = new List<SelectListItem>();
        }

        #endregion

        #region Properties

        [SmiResourceDisplayName("Admin.Promotions.Discounts.List.SearchDiscountCouponCode")]
        public string SearchDiscountCouponCode { get; set; }

        [SmiResourceDisplayName("Admin.Promotions.Discounts.List.SearchDiscountName")]
        public string SearchDiscountName { get; set; }

        [SmiResourceDisplayName("Admin.Promotions.Discounts.List.SearchDiscountType")]
        public int SearchDiscountTypeId { get; set; }

        public IList<SelectListItem> AvailableDiscountTypes { get; set; }

        [SmiResourceDisplayName("Admin.Promotions.Discounts.List.SearchStartDate")]
        [UIHint("DateNullable")]
        public DateTime? SearchStartDate { get; set; }

        [SmiResourceDisplayName("Admin.Promotions.Discounts.List.SearchEndDate")]
        [UIHint("DateNullable")]
        public DateTime? SearchEndDate { get; set; }

        #endregion
    }
}