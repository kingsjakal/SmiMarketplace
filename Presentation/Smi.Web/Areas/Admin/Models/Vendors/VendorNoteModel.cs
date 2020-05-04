using System;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Vendors
{
    /// <summary>
    /// Represents a vendor note model
    /// </summary>
    public partial class VendorNoteModel : BaseSmiEntityModel
    {
        #region Properties

        public int VendorId { get; set; }

        [SmiResourceDisplayName("Admin.Vendors.VendorNotes.Fields.Note")]
        public string Note { get; set; }

        [SmiResourceDisplayName("Admin.Vendors.VendorNotes.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        #endregion
    }
}