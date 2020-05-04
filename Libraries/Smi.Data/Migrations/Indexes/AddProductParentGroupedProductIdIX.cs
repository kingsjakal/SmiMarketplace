using FluentMigrator;
using Smi.Core.Domain.Catalog;

namespace Smi.Data.Migrations.Indexes
{
    [SmiMigration("2020/03/13 09:36:08:9037705")]
    public class AddProductParentGroupedProductIdIX : AutoReversingMigration
    {
        #region Methods         

        public override void Up()
        {
            Create.Index("IX_Product_ParentGroupedProductId").OnTable(nameof(Product))
                .OnColumn(nameof(Product.ParentGroupedProductId)).Ascending()
                .WithOptions().NonClustered();
        }

        #endregion
    }
}