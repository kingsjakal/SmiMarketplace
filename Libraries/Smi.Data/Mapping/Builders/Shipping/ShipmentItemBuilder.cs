using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Shipping;
using Smi.Data.Extensions;

namespace Smi.Data.Mapping.Builders.Shipping
{
    /// <summary>
    /// Represents a shipment item entity builder
    /// </summary>
    public partial class ShipmentItemBuilder : SmiEntityBuilder<ShipmentItem>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table.WithColumn(nameof(ShipmentItem.ShipmentId)).AsInt32().ForeignKey<Shipment>();
        }

        #endregion
    }
}