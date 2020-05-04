﻿using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Catalog;
using Smi.Core.Domain.Customers;
using Smi.Data.Extensions;

namespace Smi.Data.Mapping.Builders.Catalog
{
    /// <summary>
    /// Represents a back in stock subscription entity builder
    /// </summary>
    public partial class BackInStockSubscriptionBuilder : SmiEntityBuilder<BackInStockSubscription>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(BackInStockSubscription.CustomerId)).AsInt32().ForeignKey<Customer>()
                .WithColumn(nameof(BackInStockSubscription.ProductId)).AsInt32().ForeignKey<Product>();
        }

        #endregion
    }
}