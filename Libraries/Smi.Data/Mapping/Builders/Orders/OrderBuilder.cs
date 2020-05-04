using System.Data;
using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Common;
using Smi.Core.Domain.Customers;
using Smi.Core.Domain.Orders;
using Smi.Data.Extensions;

namespace Smi.Data.Mapping.Builders.Orders
{
    /// <summary>
    /// Represents a order entity builder
    /// </summary>
    public partial class OrderBuilder : SmiEntityBuilder<Order>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(Order.CustomOrderNumber)).AsString(int.MaxValue).NotNullable()
                .WithColumn(nameof(Order.BillingAddressId)).AsInt32().ForeignKey<Address>(onDelete: Rule.None)
                .WithColumn(nameof(Order.CustomerId)).AsInt32().ForeignKey<Customer>(onDelete: Rule.None)
                .WithColumn(nameof(Order.PickupAddressId)).AsInt32().Nullable().ForeignKey<Address>(onDelete: Rule.None)
                .WithColumn(nameof(Order.ShippingAddressId)).AsInt32().Nullable().ForeignKey<Address>(onDelete: Rule.None);
        }

        #endregion
    }
}