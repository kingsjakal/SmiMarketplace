using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Customers;
using Smi.Data.Extensions;

namespace Smi.Data.Mapping.Builders.Customers
{
    /// <summary>
    /// Represents a external authentication record entity builder
    /// </summary>
    public partial class ExternalAuthenticationRecordBuilder : SmiEntityBuilder<ExternalAuthenticationRecord>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table.WithColumn(nameof(ExternalAuthenticationRecord.CustomerId)).AsInt32().ForeignKey<Customer>();
        }

        #endregion
    }
}