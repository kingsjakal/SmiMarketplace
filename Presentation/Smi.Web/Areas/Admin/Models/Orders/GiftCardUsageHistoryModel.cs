using System;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Orders
{
    /// <summary>
    /// Represents a gift card usage history model
    /// </summary>
    public partial class GiftCardUsageHistoryModel : BaseSmiEntityModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.GiftCards.History.UsedValue")]
        public string UsedValue { get; set; }

        public int OrderId { get; set; }

        [SmiResourceDisplayName("Admin.GiftCards.History.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        [SmiResourceDisplayName("Admin.GiftCards.History.CustomOrderNumber")]
        public string CustomOrderNumber { get; set; }

        #endregion
    }
}