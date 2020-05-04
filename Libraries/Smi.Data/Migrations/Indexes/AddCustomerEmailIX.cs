using FluentMigrator;
using Smi.Core.Domain.Customers;

namespace Smi.Data.Migrations.Indexes
{
    [SmiMigration("2020/03/13 09:36:08:9037681")]
    public class AddCustomerEmailIX : AutoReversingMigration
    {
        #region Methods   

        public override void Up()
        {
            Create.Index("IX_Customer_Email").OnTable(nameof(Customer))
                .OnColumn(nameof(Customer.Email)).Ascending()
                .WithOptions().NonClustered();
        }

        #endregion
    }
}