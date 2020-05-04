using FluentMigrator;
using Smi.Data.Migrations;
using Smi.Plugin.Tax.Avalara.Domain;

namespace Smi.Plugin.Tax.Avalara.Data
{
    [SkipMigrationOnUpdate]
    [SmiMigration("2020/02/03 09:09:17:6455442", "Tax.Avalara base schema")]
    public class SchemaMigration : AutoReversingMigration
    {
        #region Fields

        protected IMigrationManager _migrationManager;

        #endregion

        #region Ctor

        public SchemaMigration(IMigrationManager migrationManager)
        {
            _migrationManager = migrationManager;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Collect the UP migration expressions
        /// </summary>
        public override void Up()
        {
            _migrationManager.BuildTable<TaxTransactionLog>(Create);
        }

        #endregion
    }
}