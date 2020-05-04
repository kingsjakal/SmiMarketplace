using System;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Orders
{
    /// <summary>
    /// Represents a recurring payment history model
    /// </summary>
    public partial class RecurringPaymentHistoryModel : BaseSmiEntityModel
    {
        #region Properties

        public int OrderId { get; set; }

        [SmiResourceDisplayName("Admin.RecurringPayments.History.CustomOrderNumber")]
        public string CustomOrderNumber { get; set; }

        public int RecurringPaymentId { get; set; }

        [SmiResourceDisplayName("Admin.RecurringPayments.History.OrderStatus")]
        public string OrderStatus { get; set; }

        [SmiResourceDisplayName("Admin.RecurringPayments.History.PaymentStatus")]
        public string PaymentStatus { get; set; }

        [SmiResourceDisplayName("Admin.RecurringPayments.History.ShippingStatus")]
        public string ShippingStatus { get; set; }

        [SmiResourceDisplayName("Admin.RecurringPayments.History.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        #endregion
    }
}