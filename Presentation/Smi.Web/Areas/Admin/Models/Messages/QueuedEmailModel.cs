using System;
using System.ComponentModel.DataAnnotations;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Messages
{
    /// <summary>
    /// Represents a queued email model
    /// </summary>
    public partial class QueuedEmailModel: BaseSmiEntityModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.System.QueuedEmails.Fields.Id")]
        public override int Id { get; set; }

        [SmiResourceDisplayName("Admin.System.QueuedEmails.Fields.Priority")]
        public string PriorityName { get; set; }

        [SmiResourceDisplayName("Admin.System.QueuedEmails.Fields.From")]
        public string From { get; set; }

        [SmiResourceDisplayName("Admin.System.QueuedEmails.Fields.FromName")]
        public string FromName { get; set; }

        [SmiResourceDisplayName("Admin.System.QueuedEmails.Fields.To")]
        public string To { get; set; }

        [SmiResourceDisplayName("Admin.System.QueuedEmails.Fields.ToName")]
        public string ToName { get; set; }

        [SmiResourceDisplayName("Admin.System.QueuedEmails.Fields.ReplyTo")]
        public string ReplyTo { get; set; }

        [SmiResourceDisplayName("Admin.System.QueuedEmails.Fields.ReplyToName")]
        public string ReplyToName { get; set; }

        [SmiResourceDisplayName("Admin.System.QueuedEmails.Fields.CC")]
        public string CC { get; set; }

        [SmiResourceDisplayName("Admin.System.QueuedEmails.Fields.Bcc")]
        public string Bcc { get; set; }

        [SmiResourceDisplayName("Admin.System.QueuedEmails.Fields.Subject")]
        public string Subject { get; set; }

        [SmiResourceDisplayName("Admin.System.QueuedEmails.Fields.Body")]
        public string Body { get; set; }

        [SmiResourceDisplayName("Admin.System.QueuedEmails.Fields.AttachmentFilePath")]
        public string AttachmentFilePath { get; set; }

        [SmiResourceDisplayName("Admin.System.QueuedEmails.Fields.AttachedDownload")]
        [UIHint("Download")]
        public int AttachedDownloadId { get; set; }

        [SmiResourceDisplayName("Admin.System.QueuedEmails.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        [SmiResourceDisplayName("Admin.System.QueuedEmails.Fields.SendImmediately")]
        public bool SendImmediately { get; set; }

        [SmiResourceDisplayName("Admin.System.QueuedEmails.Fields.DontSendBeforeDate")]
        [UIHint("DateTimeNullable")]
        public DateTime? DontSendBeforeDate { get; set; }

        [SmiResourceDisplayName("Admin.System.QueuedEmails.Fields.SentTries")]
        public int SentTries { get; set; }

        [SmiResourceDisplayName("Admin.System.QueuedEmails.Fields.SentOn")]
        public DateTime? SentOn { get; set; }

        [SmiResourceDisplayName("Admin.System.QueuedEmails.Fields.EmailAccountName")]
        public string EmailAccountName { get; set; }

        #endregion
    }
}