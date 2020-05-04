using System;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Affiliates
{
    /// <summary>
    /// Represents an affiliated order model
    /// </summary>
    public partial class AffiliatedOrderModel : BaseSmiEntityModel
    {
        #region Properties

        public override int Id { get; set; }

        [SmiResourceDisplayName("Admin.Affiliates.Orders.CustomOrderNumber")]
        public string CustomOrderNumber { get; set; }

        [SmiResourceDisplayName("Admin.Affiliates.Orders.OrderStatus")]
        public string OrderStatus { get; set; }
        [SmiResourceDisplayName("Admin.Affiliates.Orders.OrderStatus")]
        public int OrderStatusId { get; set; }

        [SmiResourceDisplayName("Admin.Affiliates.Orders.PaymentStatus")]
        public string PaymentStatus { get; set; }

        [SmiResourceDisplayName("Admin.Affiliates.Orders.ShippingStatus")]
        public string ShippingStatus { get; set; }

        [SmiResourceDisplayName("Admin.Affiliates.Orders.OrderTotal")]
        public string OrderTotal { get; set; }

        [SmiResourceDisplayName("Admin.Affiliates.Orders.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        #endregion
    }
}