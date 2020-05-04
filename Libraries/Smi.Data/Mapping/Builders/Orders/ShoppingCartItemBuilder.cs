using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Catalog;
using Smi.Core.Domain.Customers;
using Smi.Core.Domain.Orders;
using Smi.Data.Extensions;

namespace Smi.Data.Mapping.Builders.Orders
{
    /// <summary>
    /// Represents a shopping cart item entity builder
    /// </summary>
    public partial class ShoppingCartItemBuilder : SmiEntityBuilder<ShoppingCartItem>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(ShoppingCartItem.CustomerId)).AsInt32().ForeignKey<Customer>()
                .WithColumn(nameof(ShoppingCartItem.ProductId)).AsInt32().ForeignKey<Product>();
        }

        #endregion
    }
}