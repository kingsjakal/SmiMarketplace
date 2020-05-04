using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Customers
{
    /// <summary>
    /// Represents a customer associated external authentication model
    /// </summary>
    public partial class CustomerAssociatedExternalAuthModel : BaseSmiEntityModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.Customers.Customers.AssociatedExternalAuth.Fields.Email")]
        public string Email { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.AssociatedExternalAuth.Fields.ExternalIdentifier")]
        public string ExternalIdentifier { get; set; }
        
        [SmiResourceDisplayName("Admin.Customers.Customers.AssociatedExternalAuth.Fields.AuthMethodName")]
        public string AuthMethodName { get; set; }

        #endregion
    }
}