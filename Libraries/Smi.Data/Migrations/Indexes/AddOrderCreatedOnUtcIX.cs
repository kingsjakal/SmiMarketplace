using FluentMigrator;
using Smi.Core.Domain.Orders;

namespace Smi.Data.Migrations.Indexes
{
    [SmiMigration("2020/03/13 09:36:08:9037688")]
    public class AddOrderCreatedOnUtcIX : AutoReversingMigration
    {
        #region Methods          

        public override void Up()
        {
            Create.Index("IX_Order_CreatedOnUtc").OnTable(nameof(Order))
                .OnColumn(nameof(Order.CreatedOnUtc)).Descending()
                .WithOptions().NonClustered();
        }

        #endregion
    }
}