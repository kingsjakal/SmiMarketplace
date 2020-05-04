using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Catalog;

namespace Smi.Data.Mapping.Builders.Catalog
{
    /// <summary>
    /// Represents a manufacturer template entity builder
    /// </summary>
    public partial class ManufacturerTemplateBuilder : SmiEntityBuilder<ManufacturerTemplate>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table) 
        {
            table
                .WithColumn(nameof(ManufacturerTemplate.Name)).AsString(400).NotNullable()
                .WithColumn(nameof(ManufacturerTemplate.ViewPath)).AsString(400).NotNullable();
        }
        
        #endregion
    }
}