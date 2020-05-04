using System.ComponentModel.DataAnnotations;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Common
{
    public partial class ContactVendorModel : BaseSmiModel
    {
        public int VendorId { get; set; }
        public string VendorName { get; set; }

        [DataType(DataType.EmailAddress)]
        [SmiResourceDisplayName("ContactVendor.Email")]
        public string Email { get; set; }

        [SmiResourceDisplayName("ContactVendor.Subject")]
        public string Subject { get; set; }
        public bool SubjectEnabled { get; set; }

        [SmiResourceDisplayName("ContactVendor.Enquiry")]
        public string Enquiry { get; set; }

        [SmiResourceDisplayName("ContactVendor.FullName")]
        public string FullName { get; set; }

        public bool SuccessfullySent { get; set; }
        public string Result { get; set; }

        public bool DisplayCaptcha { get; set; }
    }
}