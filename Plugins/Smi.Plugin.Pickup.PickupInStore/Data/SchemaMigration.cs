using FluentMigrator;
using Smi.Data.Migrations;
using Smi.Plugin.Pickup.PickupInStore.Domain;

namespace Smi.Plugin.Pickup.PickupInStore.Data
{
    [SkipMigrationOnUpdate]
    [SmiMigration("2020/02/03 09:30:17:6455422", "Pickup.PickupInStore base schema")]
    public class SchemaMigration : AutoReversingMigration
    {
        protected IMigrationManager _migrationManager;

        public SchemaMigration(IMigrationManager migrationManager)
        {
            _migrationManager = migrationManager;
        }

        public override void Up()
        {
            _migrationManager.BuildTable<StorePickupPoint>(Create);
        }
    }
}