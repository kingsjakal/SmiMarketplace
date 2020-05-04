using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Catalog;
using Smi.Data.Extensions;

namespace Smi.Data.Mapping.Builders.Catalog
{
    /// <summary>
    /// Represents a product manufacturer entity builder
    /// </summary>
    public partial class ProductManufacturerBuilder : SmiEntityBuilder<ProductManufacturer>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(ProductManufacturer.ManufacturerId)).AsInt32().ForeignKey<Manufacturer>()
                .WithColumn(nameof(ProductManufacturer.ProductId)).AsInt32().ForeignKey<Product>();
        }

        #endregion
    }
}