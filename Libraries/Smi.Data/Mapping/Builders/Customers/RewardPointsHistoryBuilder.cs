using System.Data;
using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Customers;
using Smi.Core.Domain.Orders;
using Smi.Data.Extensions;

namespace Smi.Data.Mapping.Builders.Customers
{
    /// <summary>
    /// Represents a reward points history entity builder
    /// </summary>
    public partial class RewardPointsHistoryBuilder : SmiEntityBuilder<RewardPointsHistory>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(RewardPointsHistory.CustomerId)).AsInt32().ForeignKey<Customer>();
        }

        #endregion
    }
}