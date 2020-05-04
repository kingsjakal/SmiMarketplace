using System.Collections.Generic;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Customers
{
    /// <summary>
    /// Represents a customer attribute value model
    /// </summary>
    public partial class CustomerAttributeValueModel : BaseSmiEntityModel, ILocalizedModel<CustomerAttributeValueLocalizedModel>
    {
        #region Ctor

        public CustomerAttributeValueModel()
        {
            Locales = new List<CustomerAttributeValueLocalizedModel>();
        }

        #endregion

        #region Properties

        public int CustomerAttributeId { get; set; }

        [SmiResourceDisplayName("Admin.Customers.CustomerAttributes.Values.Fields.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.Customers.CustomerAttributes.Values.Fields.IsPreSelected")]
        public bool IsPreSelected { get; set; }

        [SmiResourceDisplayName("Admin.Customers.CustomerAttributes.Values.Fields.DisplayOrder")]
        public int DisplayOrder {get;set;}

        public IList<CustomerAttributeValueLocalizedModel> Locales { get; set; }

        #endregion
    }

    public partial class CustomerAttributeValueLocalizedModel : ILocalizedLocaleModel
    {
        public int LanguageId { get; set; }

        [SmiResourceDisplayName("Admin.Customers.CustomerAttributes.Values.Fields.Name")]
        public string Name { get; set; }
    }
}