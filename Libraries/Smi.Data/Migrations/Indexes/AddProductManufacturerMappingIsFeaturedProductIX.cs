using FluentMigrator;
using Smi.Core.Domain.Catalog;
using Smi.Data.Mapping;

namespace Smi.Data.Migrations.Indexes
{
    [SmiMigration("2020/03/13 11:35:09:1647938")]
    public class AddProductManufacturerMappingIsFeaturedProductIX : AutoReversingMigration
    {
        #region Methods

        public override void Up()
        {
            Create.Index("IX_Product_Manufacturer_Mapping_IsFeaturedProduct")
                .OnTable(NameCompatibilityManager.GetTableName(typeof(ProductManufacturer)))
                .OnColumn(nameof(ProductManufacturer.IsFeaturedProduct)).Ascending()
                .WithOptions().NonClustered();
        }

        #endregion
    }
}