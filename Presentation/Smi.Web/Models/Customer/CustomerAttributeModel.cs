using System.Collections.Generic;
using Smi.Core.Domain.Catalog;
using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Customer
{
    public partial class CustomerAttributeModel : BaseSmiEntityModel
    {
        public CustomerAttributeModel()
        {
            Values = new List<CustomerAttributeValueModel>();
        }

        public string Name { get; set; }

        public bool IsRequired { get; set; }

        /// <summary>
        /// Default value for textboxes
        /// </summary>
        public string DefaultValue { get; set; }

        public AttributeControlType AttributeControlType { get; set; }

        public IList<CustomerAttributeValueModel> Values { get; set; }

    }

    public partial class CustomerAttributeValueModel : BaseSmiEntityModel
    {
        public string Name { get; set; }

        public bool IsPreSelected { get; set; }
    }
}