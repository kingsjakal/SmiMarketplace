using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Orders
{
    /// <summary>
    /// Represents a shipment item search model
    /// </summary>
    public partial class ShipmentItemSearchModel : BaseSearchModel
    {
        #region Properties

        public int ShipmentId { get; set; }

        #endregion
    }
}