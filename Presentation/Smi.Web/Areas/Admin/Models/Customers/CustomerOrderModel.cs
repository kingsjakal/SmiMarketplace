using System;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Customers
{
    /// <summary>
    /// Represents a customer order model
    /// </summary>
    public partial class CustomerOrderModel : BaseSmiEntityModel
    {
        #region Properties

        public override int Id { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.Orders.CustomOrderNumber")]
        public string CustomOrderNumber { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.Orders.OrderStatus")]
        public string OrderStatus { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.Orders.OrderStatus")]
        public int OrderStatusId { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.Orders.PaymentStatus")]
        public string PaymentStatus { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.Orders.ShippingStatus")]
        public string ShippingStatus { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.Orders.OrderTotal")]
        public string OrderTotal { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.Orders.Store")]
        public string StoreName { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.Orders.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        #endregion
    }
}