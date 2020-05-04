using System.Collections.Generic;
using Smi.Core.Domain.Catalog;
using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Common
{
    public partial class AddressAttributeModel : BaseSmiEntityModel
    {
        public AddressAttributeModel()
        {
            Values = new List<AddressAttributeValueModel>();
        }

        public string Name { get; set; }

        public bool IsRequired { get; set; }

        /// <summary>
        /// Default value for textboxes
        /// </summary>
        public string DefaultValue { get; set; }

        public AttributeControlType AttributeControlType { get; set; }

        public IList<AddressAttributeValueModel> Values { get; set; }
    }

    public partial class AddressAttributeValueModel : BaseSmiEntityModel
    {
        public string Name { get; set; }

        public bool IsPreSelected { get; set; }
    }
}