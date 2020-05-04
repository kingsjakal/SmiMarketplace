using System.Collections.Generic;
using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Catalog
{
    public partial class ManufacturerNavigationModel : BaseSmiModel
    {
        public ManufacturerNavigationModel()
        {
            Manufacturers = new List<ManufacturerBriefInfoModel>();
        }

        public IList<ManufacturerBriefInfoModel> Manufacturers { get; set; }

        public int TotalManufacturers { get; set; }
    }

    public partial class ManufacturerBriefInfoModel : BaseSmiEntityModel
    {
        public string Name { get; set; }

        public string SeName { get; set; }
        
        public bool IsActive { get; set; }
    }
}