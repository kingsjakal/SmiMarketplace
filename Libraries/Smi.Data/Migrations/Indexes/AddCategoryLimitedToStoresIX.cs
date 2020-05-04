using FluentMigrator;
using Smi.Core.Domain.Catalog;

namespace Smi.Data.Migrations.Indexes
{
    [SmiMigration("2020/03/13 11:35:09:1647931")]
    public class AddCategoryLimitedToStoresIX : AutoReversingMigration
    {
        #region Methods

        public override void Up()
        {
            Create.Index("IX_Category_LimitedToStores").OnTable(nameof(Category))
                .OnColumn(nameof(Category.LimitedToStores)).Ascending()
                .WithOptions().NonClustered();
        }

        #endregion
    }
}