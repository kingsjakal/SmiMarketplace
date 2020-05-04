using System.Collections.Generic;
using Smi.Core.Domain.Catalog;
using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Vendors
{
    public partial class VendorAttributeModel : BaseSmiEntityModel
    {
        public VendorAttributeModel()
        {
            Values = new List<VendorAttributeValueModel>();
        }

        public string Name { get; set; }

        public bool IsRequired { get; set; }

        /// <summary>
        /// Default value for textboxes
        /// </summary>
        public string DefaultValue { get; set; }

        public AttributeControlType AttributeControlType { get; set; }

        public IList<VendorAttributeValueModel> Values { get; set; }

    }

    public partial class VendorAttributeValueModel : BaseSmiEntityModel
    {
        public string Name { get; set; }

        public bool IsPreSelected { get; set; }
    }
}