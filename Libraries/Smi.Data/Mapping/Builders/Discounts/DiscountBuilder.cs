﻿using FluentMigrator.Builders.Create.Table;
using Smi.Core.Domain.Discounts;

namespace Smi.Data.Mapping.Builders.Discounts
{
    /// <summary>
    /// Represents a discount entity builder
    /// </summary>
    public partial class DiscountBuilder : SmiEntityBuilder<Discount>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
               .WithColumn(nameof(Discount.Name)).AsString(200).NotNullable()
               .WithColumn(nameof(Discount.CouponCode)).AsString(100).Nullable();
        }

        #endregion
    }
}