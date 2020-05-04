using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Catalog;
using Smi.Data.Extensions;

namespace Smi.Data.Mapping.Builders.Catalog
{
    /// <summary>
    /// Represents a product attribute value entity builder
    /// </summary>
    public partial class ProductAttributeValueBuilder : SmiEntityBuilder<ProductAttributeValue>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(ProductAttributeValue.Name)).AsString(400).NotNullable()
                .WithColumn(nameof(ProductAttributeValue.ColorSquaresRgb)).AsString(100).Nullable()
                .WithColumn(nameof(ProductAttributeValue.ProductAttributeMappingId)).AsInt32().ForeignKey<ProductAttributeMapping>();
        }

        #endregion
    }
}