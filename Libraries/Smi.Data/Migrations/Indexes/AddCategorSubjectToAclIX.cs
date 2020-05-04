using FluentMigrator;
using Smi.Core.Domain.Catalog;

namespace Smi.Data.Migrations.Indexes
{
    [SmiMigration("2020/03/13 11:35:09:1647934")]
    public class AddCategorSubjectToAclIX : AutoReversingMigration
    {
        #region Methods

        public override void Up()
        {
            Create.Index("IX_Category_SubjectToAcl").OnTable(nameof(Category))
                .OnColumn(nameof(Category.SubjectToAcl)).Ascending()
                .WithOptions().NonClustered();
        }

        #endregion
    }
}