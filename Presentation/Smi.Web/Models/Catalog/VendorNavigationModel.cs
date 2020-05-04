using System.Collections.Generic;
using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Catalog
{
    public partial class VendorNavigationModel : BaseSmiModel
    {
        public VendorNavigationModel()
        {
            Vendors = new List<VendorBriefInfoModel>();
        }

        public IList<VendorBriefInfoModel> Vendors { get; set; }

        public int TotalVendors { get; set; }
    }

    public partial class VendorBriefInfoModel : BaseSmiEntityModel
    {
        public string Name { get; set; }

        public string SeName { get; set; }
    }
}