﻿using FluentMigrator;
using Smi.Core.Domain.Catalog;

namespace Smi.Data.Migrations.Indexes
{
    [SmiMigration("2020/03/13 09:36:08:9037702")]
    public class AddProductDeletedPublishedIX : AutoReversingMigration
    {
        #region Methods         

        public override void Up()
        {
            Create.Index("IX_Product_Deleted_and_Published").OnTable(nameof(Product))
                .OnColumn(nameof(Product.Published)).Ascending()
                .OnColumn(nameof(Product.Deleted)).Ascending()
                .WithOptions().NonClustered();
        }

        #endregion
    }
}