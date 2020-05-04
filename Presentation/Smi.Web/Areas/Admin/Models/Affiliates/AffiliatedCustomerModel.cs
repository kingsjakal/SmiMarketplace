using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Affiliates
{
    /// <summary>
    /// Represents an affiliated customer model
    /// </summary>
    public partial class AffiliatedCustomerModel : BaseSmiEntityModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.Affiliates.Customers.Name")]
        public string Name { get; set; }

        #endregion
    }
}