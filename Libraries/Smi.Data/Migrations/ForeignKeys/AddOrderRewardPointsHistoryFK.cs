using System.Data;
using FluentMigrator;
using Smi.Core.Domain.Customers;
using Smi.Core.Domain.Orders;

namespace Smi.Data.Migrations.Indexes
{
    [SmiMigration("2020/03/17 11:26:08:9037680")]
    public class AddOrderRewardPointsHistoryFK : AutoReversingMigration
    {
        #region Methods          

        public override void Up()
        {
            Create.ForeignKey().FromTable(nameof(Order)).ForeignColumn(nameof(Order.RewardPointsHistoryEntryId))
                .ToTable(nameof(RewardPointsHistory)).PrimaryColumn(nameof(RewardPointsHistory.Id)).OnDelete(Rule.None);
        }

        #endregion
    }
}
