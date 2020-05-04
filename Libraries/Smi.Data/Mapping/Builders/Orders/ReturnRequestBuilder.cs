using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Customers;
using Smi.Core.Domain.Orders;
using Smi.Data.Extensions;

namespace Smi.Data.Mapping.Builders.Orders
{
    /// <summary>
    /// Represents a return request entity builder
    /// </summary>
    public partial class ReturnRequestBuilder : SmiEntityBuilder<ReturnRequest>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(ReturnRequest.ReasonForReturn)).AsString(int.MaxValue).NotNullable()
                .WithColumn(nameof(ReturnRequest.RequestedAction)).AsString(int.MaxValue).NotNullable()
                .WithColumn(nameof(ReturnRequest.CustomerId)).AsInt32().ForeignKey<Customer>();
        }

        #endregion
    }
}