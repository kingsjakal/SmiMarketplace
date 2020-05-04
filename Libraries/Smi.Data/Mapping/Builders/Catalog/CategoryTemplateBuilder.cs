using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Catalog;

namespace Smi.Data.Mapping.Builders.Catalog
{
    /// <summary>
    /// Represents a category template entity builder
    /// </summary>
    public class CategoryTemplateBuilder : SmiEntityBuilder<CategoryTemplate>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table) 
        {
            table
                .WithColumn(nameof(CategoryTemplate.Name)).AsString(400).NotNullable()
                .WithColumn(nameof(CategoryTemplate.ViewPath)).AsString(400).NotNullable();
        }

        #endregion
    }
}