using System.Collections.Generic;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Customers
{
    /// <summary>
    /// Represents a customer attribute model
    /// </summary>
    public partial class CustomerAttributeModel : BaseSmiEntityModel, ILocalizedModel<CustomerAttributeLocalizedModel>
    {
        #region Ctor

        public CustomerAttributeModel()
        {
            Locales = new List<CustomerAttributeLocalizedModel>();
            CustomerAttributeValueSearchModel = new CustomerAttributeValueSearchModel();
        }

        #endregion

        #region Properties

        [SmiResourceDisplayName("Admin.Customers.CustomerAttributes.Fields.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.Customers.CustomerAttributes.Fields.IsRequired")]
        public bool IsRequired { get; set; }

        [SmiResourceDisplayName("Admin.Customers.CustomerAttributes.Fields.AttributeControlType")]
        public int AttributeControlTypeId { get; set; }

        [SmiResourceDisplayName("Admin.Customers.CustomerAttributes.Fields.AttributeControlType")]
        public string AttributeControlTypeName { get; set; }

        [SmiResourceDisplayName("Admin.Customers.CustomerAttributes.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        public IList<CustomerAttributeLocalizedModel> Locales { get; set; }

        public CustomerAttributeValueSearchModel CustomerAttributeValueSearchModel { get; set; }

        #endregion
    }

    public partial class CustomerAttributeLocalizedModel : ILocalizedLocaleModel
    {
        public int LanguageId { get; set; }

        [SmiResourceDisplayName("Admin.Customers.CustomerAttributes.Fields.Name")]
        public string Name { get; set; }
    }
}