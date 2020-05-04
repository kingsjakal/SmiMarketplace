using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Customer
{
    public partial class GdprConsentModel : BaseSmiEntityModel
    {
        public string Message { get; set; }

        public bool IsRequired { get; set; }

        public string RequiredMessage { get; set; }

        public bool Accepted { get; set; }
    }
}