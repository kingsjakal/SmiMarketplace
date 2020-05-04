﻿using FluentMigrator;
using Smi.Core.Domain.Catalog;

namespace Smi.Data.Migrations.Indexes
{
    [SmiMigration("2020/03/13 11:35:09:1647936")]
    public class AddProductSubjectToAclIX : AutoReversingMigration
    {
        #region Methods

        public override void Up()
        {
            Create.Index("IX_Product_SubjectToAcl").OnTable(nameof(Product))
                .OnColumn(nameof(Product.SubjectToAcl)).Ascending()
                .WithOptions().NonClustered();
        }

        #endregion
    }
}