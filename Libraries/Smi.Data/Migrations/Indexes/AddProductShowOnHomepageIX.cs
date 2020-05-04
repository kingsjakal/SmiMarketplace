﻿using FluentMigrator;
using Smi.Core.Domain.Catalog;

namespace Smi.Data.Migrations.Indexes
{
    [SmiMigration("2020/03/13 09:36:08:9037704")]
    public class AddProductShowOnHomepageIX : AutoReversingMigration
    {
        #region Methods          

        public override void Up()
        {
            Create.Index("IX_Product_ShowOnHomepage").OnTable(nameof(Product))
                .OnColumn(nameof(Product.ShowOnHomepage)).Ascending()
                .WithOptions().NonClustered();
        }

        #endregion
    }
}