using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Orders;
using Smi.Core.Domain.Shipping;
using Smi.Data.Extensions;

namespace Smi.Data.Mapping.Builders.Shipping
{
    /// <summary>
    /// Represents a shipment entity builder
    /// </summary>
    public partial class ShipmentBuilder : SmiEntityBuilder<Shipment>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table.WithColumn(nameof(Shipment.OrderId)).AsInt32().ForeignKey<Order>();
        }

        #endregion
    }
}