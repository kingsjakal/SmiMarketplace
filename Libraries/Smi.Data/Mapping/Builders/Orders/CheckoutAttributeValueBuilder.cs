using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Orders;
using Smi.Data.Extensions;

namespace Smi.Data.Mapping.Builders.Orders
{
    /// <summary>
    /// Represents a checkout attribute value entity builder
    /// </summary>
    public partial class CheckoutAttributeValueBuilder : SmiEntityBuilder<CheckoutAttributeValue>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(CheckoutAttributeValue.Name)).AsString(400).NotNullable()
                .WithColumn(nameof(CheckoutAttributeValue.ColorSquaresRgb)).AsString(100).Nullable()
                .WithColumn(nameof(CheckoutAttributeValue.CheckoutAttributeId)).AsInt32().ForeignKey<CheckoutAttribute>();
        }

        #endregion
    }
}