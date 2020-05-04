﻿using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Catalog;

namespace Smi.Data.Mapping.Builders.Catalog
{
    /// <summary>
    /// Represents a product tag entity builder
    /// </summary>
    public partial class ProductTagBuilder : SmiEntityBuilder<ProductTag>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table.WithColumn(nameof(ProductTag.Name)).AsString(400).NotNullable();
        }

        #endregion
    }
}