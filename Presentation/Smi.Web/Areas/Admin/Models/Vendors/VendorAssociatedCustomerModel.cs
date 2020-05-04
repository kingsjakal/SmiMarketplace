using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Vendors
{
    /// <summary>
    /// Represents a vendor associated customer model
    /// </summary>
    public partial class VendorAssociatedCustomerModel : BaseSmiEntityModel
    {
        #region Properties

        public string Email { get; set; }

        #endregion
    }
}