using System;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Discounts
{
    /// <summary>
    /// Represents a discount usage history model
    /// </summary>
    public partial class DiscountUsageHistoryModel : BaseSmiEntityModel
    {
        #region Properties

        public int DiscountId { get; set; }

        public int OrderId { get; set; }

        [SmiResourceDisplayName("Admin.Promotions.Discounts.History.CustomOrderNumber")]
        public string CustomOrderNumber { get; set; }

        [SmiResourceDisplayName("Admin.Promotions.Discounts.History.OrderTotal")]
        public string OrderTotal { get; set; }

        [SmiResourceDisplayName("Admin.Promotions.Discounts.History.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        #endregion
    }
}