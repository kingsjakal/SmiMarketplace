using FluentMigrator;
using Smi.Core.Domain.Catalog;

namespace Smi.Data.Migrations.Indexes
{
    [SmiMigration("2020/03/13 11:35:09:1647935")]
    public class AddManufacturerSubjectToAclIX : AutoReversingMigration
    {
        #region Methods

        public override void Up()
        {
            Create.Index("IX_Manufacturer_SubjectToAcl").OnTable(nameof(Manufacturer))
                .OnColumn(nameof(Manufacturer.SubjectToAcl)).Ascending()
                .WithOptions().NonClustered();
        }

        #endregion
    }
}