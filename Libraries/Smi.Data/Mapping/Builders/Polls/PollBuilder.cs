using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Localization;
using Smi.Core.Domain.Polls;
using Smi.Data.Extensions;

namespace Smi.Data.Mapping.Builders.Polls
{
    /// <summary>
    /// Represents a poll entity builder
    /// </summary>
    public partial class PollBuilder : SmiEntityBuilder<Poll>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(Poll.Name)).AsString(int.MaxValue).NotNullable()
                .WithColumn(nameof(Poll.LanguageId)).AsInt32().ForeignKey<Language>();
        }

        #endregion
    }
}