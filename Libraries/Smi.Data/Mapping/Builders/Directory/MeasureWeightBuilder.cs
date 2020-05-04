﻿using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Directory;

namespace Smi.Data.Mapping.Builders.Directory
{
    /// <summary>
    /// Represents a measure weight entity builder
    /// </summary>
    public partial class MeasureWeightBuilder : SmiEntityBuilder<MeasureWeight>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(MeasureWeight.Name)).AsString(100).NotNullable()
                .WithColumn(nameof(MeasureWeight.SystemKeyword)).AsString(100).NotNullable()
                .WithColumn(nameof(MeasureWeight.Ratio)).AsDecimal(18, 8);
        }

        #endregion
    }
}