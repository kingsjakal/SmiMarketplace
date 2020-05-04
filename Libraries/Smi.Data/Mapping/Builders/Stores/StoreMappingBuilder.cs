using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Stores;
using Smi.Data.Extensions;

namespace Smi.Data.Mapping.Builders.Stores
{
    /// <summary>
    /// Represents a store mapping entity builder
    /// </summary>
    public partial class StoreMappingBuilder : SmiEntityBuilder<StoreMapping>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(StoreMapping.EntityName)).AsString(400).NotNullable()
                .WithColumn(nameof(StoreMapping.StoreId)).AsInt32().ForeignKey<Store>();
        }

        #endregion
    }
}