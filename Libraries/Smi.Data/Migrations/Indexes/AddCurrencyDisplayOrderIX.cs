using FluentMigrator;
using Smi.Core.Domain.Directory;

namespace Smi.Data.Migrations.Indexes
{
    [SmiMigration("2020/03/13 09:36:08:9037708")]
    public class AddCurrencyDisplayOrderIX : AutoReversingMigration
    {
        #region Methods          

        public override void Up()
        {
            Create.Index("IX_Currency_DisplayOrder").OnTable(nameof(Currency))
                .OnColumn(nameof(Currency.DisplayOrder)).Ascending()
                .WithOptions().NonClustered();
        }

        #endregion
    }
}