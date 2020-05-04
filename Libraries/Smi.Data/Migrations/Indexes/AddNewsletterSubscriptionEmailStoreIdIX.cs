using FluentMigrator;
using Smi.Core.Domain.Messages;

namespace Smi.Data.Migrations.Indexes
{
    [SmiMigration("2020/03/13 09:36:08:9037690")]
    public class AddNewsletterSubscriptionEmailStoreIdIX : AutoReversingMigration
    {
        #region Methods          

        public override void Up()
        {
            Create.Index("IX_NewsletterSubscription_Email_StoreId").OnTable(nameof(NewsLetterSubscription))
                .OnColumn(nameof(NewsLetterSubscription.Email)).Ascending()
                .OnColumn(nameof(NewsLetterSubscription.StoreId)).Ascending()
                .WithOptions().NonClustered();
        }

        #endregion
    }
}