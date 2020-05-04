using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Orders;

namespace Smi.Data.Mapping.Builders.Orders
{
    /// <summary>
    /// Represents a checkout attribute entity builder
    /// </summary>
    public partial class CheckoutAttributeBuilder : SmiEntityBuilder<CheckoutAttribute>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table.WithColumn(nameof(CheckoutAttribute.Name)).AsString(400).NotNullable();
        }

        #endregion
    }
}