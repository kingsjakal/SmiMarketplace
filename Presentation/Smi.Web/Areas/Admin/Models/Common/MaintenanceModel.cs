using System;
using System.ComponentModel.DataAnnotations;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Common
{
    public partial class MaintenanceModel : BaseSmiModel
    {
        public MaintenanceModel()
        {
            DeleteGuests = new DeleteGuestsModel();
            DeleteAbandonedCarts = new DeleteAbandonedCartsModel();
            DeleteExportedFiles = new DeleteExportedFilesModel();
            BackupFileSearchModel = new BackupFileSearchModel();
            DeleteAlreadySentQueuedEmails = new DeleteAlreadySentQueuedEmailsModel();
        }

        public DeleteGuestsModel DeleteGuests { get; set; }

        public DeleteAbandonedCartsModel DeleteAbandonedCarts { get; set; }

        public DeleteExportedFilesModel DeleteExportedFiles { get; set; }

        public BackupFileSearchModel BackupFileSearchModel { get; set; }

        public DeleteAlreadySentQueuedEmailsModel DeleteAlreadySentQueuedEmails { get; set; }

        public bool BackupSupported { get; set; }

        #region Nested classes

        public partial class DeleteGuestsModel : BaseSmiModel
        {
            [SmiResourceDisplayName("Admin.System.Maintenance.DeleteGuests.StartDate")]
            [UIHint("DateNullable")]
            public DateTime? StartDate { get; set; }

            [SmiResourceDisplayName("Admin.System.Maintenance.DeleteGuests.EndDate")]
            [UIHint("DateNullable")]
            public DateTime? EndDate { get; set; }

            [SmiResourceDisplayName("Admin.System.Maintenance.DeleteGuests.OnlyWithoutShoppingCart")]
            public bool OnlyWithoutShoppingCart { get; set; }

            public int? NumberOfDeletedCustomers { get; set; }
        }

        public partial class DeleteAbandonedCartsModel : BaseSmiModel
        {
            [SmiResourceDisplayName("Admin.System.Maintenance.DeleteAbandonedCarts.OlderThan")]
            [UIHint("Date")]
            public DateTime OlderThan { get; set; }

            public int? NumberOfDeletedItems { get; set; }
        }

        public partial class DeleteExportedFilesModel : BaseSmiModel
        {
            [SmiResourceDisplayName("Admin.System.Maintenance.DeleteExportedFiles.StartDate")]
            [UIHint("DateNullable")]
            public DateTime? StartDate { get; set; }

            [SmiResourceDisplayName("Admin.System.Maintenance.DeleteExportedFiles.EndDate")]
            [UIHint("DateNullable")]
            public DateTime? EndDate { get; set; }

            public int? NumberOfDeletedFiles { get; set; }
        }

        public partial class DeleteAlreadySentQueuedEmailsModel : BaseSmiModel
        {
            [SmiResourceDisplayName("Admin.System.Maintenance.DeleteAlreadySentQueuedEmails.StartDate")]
            [UIHint("DateNullable")]
            public DateTime? StartDate { get; set; }

            [SmiResourceDisplayName("Admin.System.Maintenance.DeleteAlreadySentQueuedEmails.EndDate")]
            [UIHint("DateNullable")]
            public DateTime? EndDate { get; set; }

            public int? NumberOfDeletedEmails { get; set; }
        }

        #endregion
    }
}
