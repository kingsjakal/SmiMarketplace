using FluentMigrator;
using FluentMigrator.SqlServer;
using Smi.Core.Domain.Catalog;
using Smi.Data.Mapping;

namespace Smi.Data.Migrations.Indexes
{
    [SmiMigration("2020/03/13 12:02:35:9280389")]
    public class AddPCMProductIdExtendedIX : AutoReversingMigration
    {
        #region Methods          

        public override void Up()
        {
            Create.Index("IX_PCM_ProductId_Extended").OnTable(NameCompatibilityManager.GetTableName(typeof(ProductCategory)))
                .OnColumn(nameof(ProductCategory.ProductId)).Ascending()
                .OnColumn(nameof(ProductCategory.IsFeaturedProduct)).Ascending()
                .WithOptions().NonClustered()
                .Include(nameof(ProductCategory.CategoryId));
        }

        #endregion
    }
}