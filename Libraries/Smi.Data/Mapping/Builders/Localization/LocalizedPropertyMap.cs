using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Localization;
using Smi.Data.Extensions;

namespace Smi.Data.Mapping.Builders.Localization
{
    /// <summary>
    /// Represents a localized property entity builder
    /// </summary>
    public partial class LocalizedPropertyBuilder : SmiEntityBuilder<LocalizedProperty>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(LocalizedProperty.LocaleKeyGroup)).AsString(400).NotNullable()
                .WithColumn(nameof(LocalizedProperty.LocaleKey)).AsString(400).NotNullable()
                .WithColumn(nameof(LocalizedProperty.LocaleValue)).AsString(int.MaxValue).NotNullable()
                .WithColumn(nameof(LocalizedProperty.LanguageId)).AsInt32().ForeignKey<Language>();
        }

        #endregion
    }
}