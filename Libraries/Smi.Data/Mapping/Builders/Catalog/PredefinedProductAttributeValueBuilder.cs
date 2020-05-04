using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Catalog;
using Smi.Data.Extensions;

namespace Smi.Data.Mapping.Builders.Catalog
{
    /// <summary>
    /// Represents a predefined product attribute value entity builder
    /// </summary>
    public partial class PredefinedProductAttributeValueBuilder : SmiEntityBuilder<PredefinedProductAttributeValue>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(PredefinedProductAttributeValue.Name)).AsString(400).NotNullable()
                .WithColumn(nameof(PredefinedProductAttributeValue.ProductAttributeId)).AsInt32().ForeignKey<ProductAttribute>();
        }

        #endregion
    }
}