using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Orders;
using Smi.Data.Extensions;

namespace Smi.Data.Mapping.Builders.Orders
{
    /// <summary>
    /// Represents a gift card usage history entity builder
    /// </summary>
    public partial class GiftCardUsageHistoryBuilder : SmiEntityBuilder<GiftCardUsageHistory>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(GiftCardUsageHistory.GiftCardId)).AsInt32().ForeignKey<GiftCard>()
                .WithColumn(nameof(GiftCardUsageHistory.UsedWithOrderId)).AsInt32().ForeignKey<Order>();
        }

        #endregion
    }
}