using FluentMigrator;
using Smi.Core.Domain.Directory;

namespace Smi.Data.Migrations.Indexes
{
    [SmiMigration("2020/03/13 09:36:08:9037679")]
    public class AddCountryDisplayOrderIX : AutoReversingMigration
    {
        #region Methods

        public override void Up()
        {
            Create.Index("IX_Country_DisplayOrder").OnTable(nameof(Country))
                .OnColumn(nameof(Country.DisplayOrder)).Ascending()
                .WithOptions().NonClustered();
        }

        #endregion
    }
}