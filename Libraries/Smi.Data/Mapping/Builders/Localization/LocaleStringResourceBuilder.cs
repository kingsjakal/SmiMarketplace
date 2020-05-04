﻿using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Localization;
using Smi.Data.Extensions;

namespace Smi.Data.Mapping.Builders.Localization
{
    /// <summary>
    /// Represents a locale string resource entity builder
    /// </summary>
    public partial class LocaleStringResourceBuilder : SmiEntityBuilder<LocaleStringResource>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(LocaleStringResource.ResourceName)).AsString(200).NotNullable()
                .WithColumn(nameof(LocaleStringResource.ResourceValue)).AsString(int.MaxValue).NotNullable()
                .WithColumn(nameof(LocaleStringResource.LanguageId)).AsInt32().ForeignKey<Language>();
        }

        #endregion
    }
}