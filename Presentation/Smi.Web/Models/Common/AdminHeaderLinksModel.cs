using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Common
{
    public partial class AdminHeaderLinksModel : BaseSmiModel
    {
        public string ImpersonatedCustomerName { get; set; }
        public bool IsCustomerImpersonated { get; set; }
        public bool DisplayAdminLink { get; set; }
        public string EditPageUrl { get; set; }
    }
}