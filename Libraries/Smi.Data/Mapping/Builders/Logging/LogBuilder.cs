using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Customers;
using Smi.Core.Domain.Logging;
using Smi.Data.Extensions;

namespace Smi.Data.Mapping.Builders.Logging
{
    /// <summary>
    /// Represents a log entity builder
    /// </summary>
    public partial class LogBuilder : SmiEntityBuilder<Log>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(Log.ShortMessage)).AsString(int.MaxValue).NotNullable()
                .WithColumn(nameof(Log.IpAddress)).AsString(200).Nullable()
                .WithColumn(nameof(Log.CustomerId)).AsInt32().Nullable().ForeignKey<Customer>();
        }

        #endregion
    }
}