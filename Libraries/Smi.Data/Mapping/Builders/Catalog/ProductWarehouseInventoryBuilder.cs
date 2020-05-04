using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Catalog;
using Smi.Core.Domain.Shipping;
using Smi.Data.Extensions;

namespace Smi.Data.Mapping.Builders.Catalog
{
    /// <summary>
    /// Represents a product warehouse inventory entity builder
    /// </summary>
    public partial class ProductWarehouseInventoryBuilder : SmiEntityBuilder<ProductWarehouseInventory>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(ProductWarehouseInventory.ProductId)).AsInt32().ForeignKey<Product>()
                .WithColumn(nameof(ProductWarehouseInventory.WarehouseId)).AsInt32().ForeignKey<Warehouse>();
        }

        #endregion
    }
}