using System.Data;
using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Orders;
using Smi.Data.Extensions;

namespace Smi.Data.Mapping.Builders.Orders
{
    /// <summary>
    /// Represents a gift card entity builder
    /// </summary>
    public partial class GiftCardBuilder : SmiEntityBuilder<GiftCard>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table.WithColumn(nameof(GiftCard.PurchasedWithOrderItemId)).AsInt32().Nullable().ForeignKey<OrderItem>(onDelete: Rule.None);
        }

        #endregion
    }
}