using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Orders;

namespace Smi.Data.Mapping.Builders.Orders
{
    /// <summary>
    /// Represents a return request reason entity builder
    /// </summary>
    public partial class ReturnRequestReasonBuilder : SmiEntityBuilder<ReturnRequestReason>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table.WithColumn(nameof(ReturnRequestReason.Name)).AsString(400).NotNullable();
        }

        #endregion
    }
}