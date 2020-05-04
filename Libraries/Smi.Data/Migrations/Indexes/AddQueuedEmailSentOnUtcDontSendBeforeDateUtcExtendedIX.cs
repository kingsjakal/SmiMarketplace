using FluentMigrator;
using FluentMigrator.SqlServer;
using Smi.Core.Domain.Messages;

namespace Smi.Data.Migrations.Indexes
{
    [SmiMigration("2020/03/13 12:02:35:9280393")]
    public class AddQueuedEmailSentOnUtcDontSendBeforeDateUtcExtendedIX : AutoReversingMigration
    {
        #region Methods          

        public override void Up()
        {
            Create.Index("IX_QueuedEmail_SentOnUtc_DontSendBeforeDateUtc_Extended").OnTable(nameof(QueuedEmail))
                .OnColumn(nameof(QueuedEmail.SentOnUtc)).Ascending()
                .OnColumn(nameof(QueuedEmail.DontSendBeforeDateUtc)).Ascending()
                .WithOptions().NonClustered()
                .Include(nameof(QueuedEmail.SentTries));
        }

        #endregion
    }
}