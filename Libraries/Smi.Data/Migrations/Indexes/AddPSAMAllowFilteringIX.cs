using FluentMigrator;
using FluentMigrator.SqlServer;
using Smi.Core.Domain.Catalog;
using Smi.Data.Mapping;

namespace Smi.Data.Migrations.Indexes
{
    [SmiMigration("2020/03/13 12:02:35:9280391")]
    public class AddPSAMAllowFilteringIX : AutoReversingMigration
    {
        #region Methods         

        public override void Up()
        {
            Create.Index("IX_PSAM_AllowFiltering").OnTable(NameCompatibilityManager.GetTableName(typeof(ProductSpecificationAttribute)))
                .OnColumn(nameof(ProductSpecificationAttribute.AllowFiltering)).Ascending()
                .WithOptions().NonClustered()
                .Include(nameof(ProductSpecificationAttribute.ProductId))
                .Include(nameof(ProductSpecificationAttribute.SpecificationAttributeOptionId));
        }

        #endregion
    }
}