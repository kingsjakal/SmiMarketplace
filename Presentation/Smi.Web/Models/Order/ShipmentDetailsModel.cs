using System;
using System.Collections.Generic;
using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Order
{
    public partial class ShipmentDetailsModel : BaseSmiEntityModel
    {
        public ShipmentDetailsModel()
        {
            ShipmentStatusEvents = new List<ShipmentStatusEventModel>();
            Items = new List<ShipmentItemModel>();
        }

        public string TrackingNumber { get; set; }
        public string TrackingNumberUrl { get; set; }
        public DateTime? ShippedDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public IList<ShipmentStatusEventModel> ShipmentStatusEvents { get; set; }
        public bool ShowSku { get; set; }
        public IList<ShipmentItemModel> Items { get; set; }

        public OrderDetailsModel Order { get; set; }

		#region Nested Classes

        public partial class ShipmentItemModel : BaseSmiEntityModel
        {
            public string Sku { get; set; }
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public string ProductSeName { get; set; }
            public string AttributeInfo { get; set; }
            public string RentalInfo { get; set; }

            public int QuantityOrdered { get; set; }
            public int QuantityShipped { get; set; }
        }

        public partial class ShipmentStatusEventModel : BaseSmiModel
        {
            public string EventName { get; set; }
            public string Location { get; set; }
            public string Country { get; set; }
            public DateTime? Date { get; set; }
        }

		#endregion
    }
}