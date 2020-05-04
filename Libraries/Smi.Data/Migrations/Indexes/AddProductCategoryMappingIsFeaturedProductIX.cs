using FluentMigrator;
using Smi.Core.Domain.Catalog;
using Smi.Data.Mapping;

namespace Smi.Data.Migrations.Indexes
{
    [SmiMigration("2020/03/13 11:35:09:1647937")]
    public class AddProductCategoryMappingIsFeaturedProductIX : AutoReversingMigration
    {
        #region Methods

        public override void Up()
        {
            Create.Index("IX_Product_Category_Mapping_IsFeaturedProduct").OnTable(NameCompatibilityManager.GetTableName(typeof(ProductCategory)))
                .OnColumn(nameof(ProductCategory.IsFeaturedProduct)).Ascending()
                .WithOptions().NonClustered();
        }

        #endregion
    }
}