﻿using FluentMigrator;
using Smi.Core.Domain.Catalog;

namespace Smi.Data.Migrations.Indexes
{
    [SmiMigration("2020/03/13 11:35:09:1647940")]
    public class AddProductDeleteIdIX : AutoReversingMigration
    {
        #region Methods

        public override void Up()
        {
            Create.Index("IX_Product_Delete_Id").OnTable(nameof(Product))
                .OnColumn(nameof(Product.Deleted)).Ascending()
                .OnColumn(nameof(Product.Id)).Ascending()
                .WithOptions().NonClustered();
        }

        #endregion
    }
}