using FluentMigrator;
using Smi.Core.Domain.Common;

namespace Smi.Data.Migrations.Indexes
{
    [SmiMigration("2020/03/13 09:36:08:9037686")]
    public class AddGenericAttributeEntityIdKeyGroupIX : AutoReversingMigration
    {
        #region Methods          

        public override void Up()
        {
            Create.Index("IX_GenericAttribute_EntityId_and_KeyGroup").OnTable(nameof(GenericAttribute))
                .OnColumn(nameof(GenericAttribute.EntityId)).Ascending()
                .OnColumn(nameof(GenericAttribute.KeyGroup)).Ascending()
                .WithOptions().NonClustered();
        }

        #endregion
    }
}