using System.ComponentModel.DataAnnotations;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Common
{
    public partial class ContactUsModel : BaseSmiModel
    {
        [DataType(DataType.EmailAddress)]
        [SmiResourceDisplayName("ContactUs.Email")]
        public string Email { get; set; }
        
        [SmiResourceDisplayName("ContactUs.Subject")]
        public string Subject { get; set; }
        public bool SubjectEnabled { get; set; }

        [SmiResourceDisplayName("ContactUs.Enquiry")]
        public string Enquiry { get; set; }

        [SmiResourceDisplayName("ContactUs.FullName")]
        public string FullName { get; set; }

        public bool SuccessfullySent { get; set; }
        public string Result { get; set; }

        public bool DisplayCaptcha { get; set; }
    }
}