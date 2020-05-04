using FluentMigrator;
using Smi.Core.Domain.Catalog;

namespace Smi.Data.Migrations.Indexes
{
    [SmiMigration("2020/03/13 11:35:09:1647933")]
    public class AddProductLimitedToStoresIX : AutoReversingMigration
    {
        #region Methods

        public override void Up()
        {
            Create.Index("IX_Product_LimitedToStores").OnTable(nameof(Product))
                .OnColumn(nameof(Product.LimitedToStores)).Ascending()
                .WithOptions().NonClustered();
        }

        #endregion
    }
}