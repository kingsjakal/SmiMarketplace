﻿using FluentMigrator;
using Smi.Core.Domain.Catalog;

namespace Smi.Data.Migrations.Indexes
{
    [SmiMigration("2020/03/13 09:36:08:9037678")]
    public class AddProductPriceDatesEtcIX : AutoReversingMigration
    {
        #region Methods

        public override void Up()
        {
            Create.Index("IX_Product_PriceDatesEtc").OnTable(nameof(Product))
                .OnColumn(nameof(Product.Price)).Ascending()
                .OnColumn(nameof(Product.AvailableStartDateTimeUtc)).Ascending()
                .OnColumn(nameof(Product.AvailableEndDateTimeUtc)).Ascending()
                .OnColumn(nameof(Product.Published)).Ascending()
                .OnColumn(nameof(Product.Deleted)).Ascending()
                .WithOptions().NonClustered();
        }

        #endregion
    }
}