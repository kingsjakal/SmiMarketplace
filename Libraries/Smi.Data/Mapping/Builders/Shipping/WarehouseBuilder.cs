using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Shipping;

namespace Smi.Data.Mapping.Builders.Shipping
{
    /// <summary>
    /// Represents a warehouse entity builder
    /// </summary>
    public partial class WarehouseBuilder : SmiEntityBuilder<Warehouse>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table.WithColumn(nameof(Warehouse.Name)).AsString(400).NotNullable();
        }

        #endregion
    }
}