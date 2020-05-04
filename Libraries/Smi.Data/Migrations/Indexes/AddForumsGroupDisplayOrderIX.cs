using FluentMigrator;
using Smi.Core.Domain.Forums;
using Smi.Data.Mapping;

namespace Smi.Data.Migrations.Indexes
{
    [SmiMigration("2020/03/13 09:36:08:9037698")]
    public class AddForumsGroupDisplayOrderIX : AutoReversingMigration
    {
        #region Methods          

        public override void Up()
        {
            Create.Index("IX_Forums_Group_DisplayOrder").OnTable(NameCompatibilityManager.GetTableName(typeof(ForumGroup)))
                .OnColumn(nameof(ForumGroup.DisplayOrder)).Ascending()
                .WithOptions().NonClustered();
        }

        #endregion
    }
}