using FluentMigrator;
using Smi.Data.Migrations;
using Smi.Plugin.Shipping.FixedByWeightByTotal.Domain;

namespace Smi.Plugin.Shipping.FixedByWeightByTotal.Data
{
    [SkipMigrationOnUpdate]
    [SmiMigration("2020/02/03 08:40:55:1687541", "Shipping.FixedByWeightByTotal base schema")]
    public class SchemaMigration : AutoReversingMigration
    {
        protected IMigrationManager _migrationManager;

        public SchemaMigration(IMigrationManager migrationManager)
        {
            _migrationManager = migrationManager;
        }

        public override void Up()
        {
            _migrationManager.BuildTable<ShippingByWeightByTotalRecord>(Create);
        }
    }
}