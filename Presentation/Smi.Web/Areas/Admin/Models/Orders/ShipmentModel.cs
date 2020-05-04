using System;
using System.Collections.Generic;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Orders
{
    /// <summary>
    /// Represents a shipment model
    /// </summary>
    public partial class ShipmentModel : BaseSmiEntityModel
    {
        #region Ctor

        public ShipmentModel()
        {
            ShipmentStatusEvents = new List<ShipmentStatusEventModel>();
            Items = new List<ShipmentItemModel>();
        }

        #endregion

        #region Properties

        [SmiResourceDisplayName("Admin.Orders.Shipments.ID")]
        public override int Id { get; set; }

        public int OrderId { get; set; }

        [SmiResourceDisplayName("Admin.Orders.Shipments.CustomOrderNumber")]
        public string CustomOrderNumber { get; set; }

        [SmiResourceDisplayName("Admin.Orders.Shipments.TotalWeight")]
        public string TotalWeight { get; set; }

        [SmiResourceDisplayName("Admin.Orders.Shipments.TrackingNumber")]
        public string TrackingNumber { get; set; }

        public string TrackingNumberUrl { get; set; }

        [SmiResourceDisplayName("Admin.Orders.Shipments.ShippedDate")]
        public string ShippedDate { get; set; }

        [SmiResourceDisplayName("Admin.Orders.Shipments.CanShip")]
        public bool CanShip { get; set; }

        public DateTime? ShippedDateUtc { get; set; }

        [SmiResourceDisplayName("Admin.Orders.Shipments.DeliveryDate")]
        public string DeliveryDate { get; set; }

        [SmiResourceDisplayName("Admin.Orders.Shipments.CanDeliver")]
        public bool CanDeliver { get; set; }

        public DateTime? DeliveryDateUtc { get; set; }

        [SmiResourceDisplayName("Admin.Orders.Shipments.AdminComment")]
        public string AdminComment { get; set; }

        public List<ShipmentItemModel> Items { get; set; }

        public IList<ShipmentStatusEventModel> ShipmentStatusEvents { get; set; }

        #endregion
    }
}