using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Polls;
using Smi.Data.Extensions;

namespace Smi.Data.Mapping.Builders.Polls
{
    /// <summary>
    /// Represents a poll answer entity builder
    /// </summary>
    public partial class PollAnswerBuilder : SmiEntityBuilder<PollAnswer>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(PollAnswer.Name)).AsString(int.MaxValue).NotNullable()
                .WithColumn(nameof(PollAnswer.PollId)).AsInt32().ForeignKey<Poll>();
        }

        #endregion
    }
}