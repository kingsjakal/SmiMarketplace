using System;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Orders
{
    /// <summary>
    /// Represents an order note model
    /// </summary>
    public partial class OrderNoteModel : BaseSmiEntityModel
    {
        #region Properties

        public int OrderId { get; set; }

        [SmiResourceDisplayName("Admin.Orders.OrderNotes.Fields.DisplayToCustomer")]
        public bool DisplayToCustomer { get; set; }

        [SmiResourceDisplayName("Admin.Orders.OrderNotes.Fields.Note")]
        public string Note { get; set; }

        [SmiResourceDisplayName("Admin.Orders.OrderNotes.Fields.Download")]
        public int DownloadId { get; set; }

        [SmiResourceDisplayName("Admin.Orders.OrderNotes.Fields.Download")]
        public Guid DownloadGuid { get; set; }

        [SmiResourceDisplayName("Admin.Orders.OrderNotes.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        #endregion
    }
}