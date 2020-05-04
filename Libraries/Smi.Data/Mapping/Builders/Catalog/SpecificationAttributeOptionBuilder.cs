using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Catalog;
using Smi.Data.Extensions;

namespace Smi.Data.Mapping.Builders.Catalog
{
    /// <summary>
    /// Represents a specification attribute option entity builder
    /// </summary>
    public partial class SpecificationAttributeOptionBuilder : SmiEntityBuilder<SpecificationAttributeOption>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(SpecificationAttributeOption.Name)).AsString(int.MaxValue).NotNullable()
                .WithColumn(nameof(SpecificationAttributeOption.ColorSquaresRgb)).AsString(100).Nullable()
                .WithColumn(nameof(SpecificationAttributeOption.SpecificationAttributeId)).AsInt32().ForeignKey<SpecificationAttribute>();
        }

        #endregion
    }
}