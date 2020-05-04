using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Customers;
using Smi.Data.Extensions;

namespace Smi.Data.Mapping.Builders.Customers
{
    /// <summary>
    /// Represents a customer customer role mapping entity builder
    /// </summary>
    public partial class CustomerCustomerRoleMappingBuilder : SmiEntityBuilder<CustomerCustomerRoleMapping>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(NameCompatibilityManager.GetColumnName(typeof(CustomerCustomerRoleMapping), nameof(CustomerCustomerRoleMapping.CustomerId)))
                    .AsInt32().ForeignKey<Customer>().PrimaryKey()
                .WithColumn(NameCompatibilityManager.GetColumnName(typeof(CustomerCustomerRoleMapping), nameof(CustomerCustomerRoleMapping.CustomerRoleId)))
                    .AsInt32().ForeignKey<CustomerRole>().PrimaryKey();
        }

        #endregion
    }
}