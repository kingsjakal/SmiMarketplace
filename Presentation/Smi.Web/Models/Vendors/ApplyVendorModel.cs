using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Vendors
{
    public partial class ApplyVendorModel : BaseSmiModel
    {
        public ApplyVendorModel()
        {
            VendorAttributes = new List<VendorAttributeModel>();
        }

        [SmiResourceDisplayName("Vendors.ApplyAccount.Name")]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        [SmiResourceDisplayName("Vendors.ApplyAccount.Email")]
        public string Email { get; set; }

        [SmiResourceDisplayName("Vendors.ApplyAccount.Description")]
        public string Description { get; set; }

        public IList<VendorAttributeModel> VendorAttributes { get; set; }

        public bool DisplayCaptcha { get; set; }

        public bool TermsOfServiceEnabled { get; set; }
        public bool TermsOfServicePopup { get; set; }

        public bool DisableFormInput { get; set; }
        public string Result { get; set; }
    }
}