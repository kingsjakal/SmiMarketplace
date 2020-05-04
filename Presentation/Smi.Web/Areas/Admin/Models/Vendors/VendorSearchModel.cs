using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Vendors
{
    /// <summary>
    /// Represents a vendor search model
    /// </summary>
    public partial class VendorSearchModel : BaseSearchModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.Vendors.List.SearchName")]
        public string SearchName { get; set; }

        [SmiResourceDisplayName("Admin.Vendors.List.SearchEmail")]
        public string SearchEmail { get; set; }

        #endregion
    }
}