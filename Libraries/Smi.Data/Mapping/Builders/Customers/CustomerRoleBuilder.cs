﻿using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Customers;

namespace Smi.Data.Mapping.Builders.Customers
{
    /// <summary>
    /// Represents a customer role entity builder
    /// </summary>
    public partial class CustomerRoleBuilder : SmiEntityBuilder<CustomerRole>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(CustomerRole.Name)).AsString(255).NotNullable()
                .WithColumn(nameof(CustomerRole.SystemName)).AsString(255).Nullable();
        }

        #endregion
    }
}