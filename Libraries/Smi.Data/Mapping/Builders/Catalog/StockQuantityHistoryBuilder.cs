using System.Data;
using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Catalog;
using Smi.Core.Domain.Shipping;
using Smi.Data.Extensions;

namespace Smi.Data.Mapping.Builders.Catalog
{
    /// <summary>
    /// Represents a stock quantity history entity builder
    /// </summary>
    public partial class StockQuantityHistoryBuilder : SmiEntityBuilder<StockQuantityHistory>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(StockQuantityHistory.ProductId)).AsInt32().ForeignKey<Product>()
                .WithColumn(nameof(StockQuantityHistory.WarehouseId)).AsInt32().Nullable().ForeignKey<Warehouse>(onDelete: Rule.None);
        }

        #endregion
    }
}