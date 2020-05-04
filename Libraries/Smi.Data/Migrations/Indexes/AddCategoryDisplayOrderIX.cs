using FluentMigrator;
using Smi.Core.Domain.Catalog;

namespace Smi.Data.Migrations.Indexes
{
    [SmiMigration("2020/03/13 09:36:08:9037696")]
    public class AddCategoryDisplayOrderIX : AutoReversingMigration
    {
        #region Methods         

        public override void Up()
        {
            Create.Index("IX_Category_DisplayOrder").OnTable(nameof(Category))
                .OnColumn(nameof(Category.DisplayOrder)).Ascending()
                .WithOptions().NonClustered();
        }

        #endregion
    }
}