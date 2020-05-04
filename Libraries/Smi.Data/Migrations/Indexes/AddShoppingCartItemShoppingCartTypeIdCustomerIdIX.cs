using FluentMigrator;
using Smi.Core.Domain.Orders;

namespace Smi.Data.Migrations.Indexes
{
    [SmiMigration("2020/03/13 09:36:08:9037691")]
    public class AddShoppingCartItemShoppingCartTypeIdCustomerIdIX : AutoReversingMigration
    {
        #region Methods          

        public override void Up()
        {
            Create.Index("IX_ShoppingCartItem_ShoppingCartTypeId_CustomerId").OnTable(nameof(ShoppingCartItem))
                .OnColumn(nameof(ShoppingCartItem.ShoppingCartTypeId)).Ascending()
                .OnColumn(nameof(ShoppingCartItem.CustomerId)).Ascending()
                .WithOptions().NonClustered();
        }

        #endregion
    }
}