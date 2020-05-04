using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Vendors
{
    public class VendorInfoModel : BaseSmiModel
    {
        public VendorInfoModel()
        {
            VendorAttributes = new List<VendorAttributeModel>();
        }

        [SmiResourceDisplayName("Account.VendorInfo.Name")]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        [SmiResourceDisplayName("Account.VendorInfo.Email")]
        public string Email { get; set; }

        [SmiResourceDisplayName("Account.VendorInfo.Description")]
        public string Description { get; set; }

        [SmiResourceDisplayName("Account.VendorInfo.Picture")]
        public string PictureUrl { get; set; }

        public IList<VendorAttributeModel> VendorAttributes { get; set; }
    }
}