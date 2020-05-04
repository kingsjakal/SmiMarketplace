using FluentMigrator;
using Smi.Core.Domain.Forums;
using Smi.Data.Mapping;

namespace Smi.Data.Migrations.Indexes
{
    [SmiMigration("2020/03/13 09:36:08:9037699")]
    public class AddForumsForumDisplayOrderIX : AutoReversingMigration
    {
        #region Methods          

        public override void Up()
        {
            Create.Index("IX_Forums_Forum_DisplayOrder").OnTable(NameCompatibilityManager.GetTableName(typeof(Forum)))
                .OnColumn(nameof(Forum.DisplayOrder)).Ascending()
                .WithOptions().NonClustered();
        }

        #endregion
    }
}