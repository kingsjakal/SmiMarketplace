using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Logging;

namespace Smi.Data.Mapping.Builders.Logging
{
    /// <summary>
    /// Represents an activity log type entity builder
    /// </summary>
    public partial class ActivityLogTypeBuilder : SmiEntityBuilder<ActivityLogType>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(ActivityLogType.SystemKeyword)).AsString(100).NotNullable()
                .WithColumn(nameof(ActivityLogType.Name)).AsString(200).NotNullable();
        }

        #endregion
    }
}