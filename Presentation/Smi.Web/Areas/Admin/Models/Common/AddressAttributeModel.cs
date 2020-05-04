using System.Collections.Generic;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Common
{
    /// <summary>
    /// Represents an address attribute model
    /// </summary>
    public partial class AddressAttributeModel : BaseSmiEntityModel, ILocalizedModel<AddressAttributeLocalizedModel>
    {
        #region Ctor

        public AddressAttributeModel()
        {
            Locales = new List<AddressAttributeLocalizedModel>();
            AddressAttributeValueSearchModel = new AddressAttributeValueSearchModel();
        }

        #endregion

        #region Properties

        [SmiResourceDisplayName("Admin.Address.AddressAttributes.Fields.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.Address.AddressAttributes.Fields.IsRequired")]
        public bool IsRequired { get; set; }

        [SmiResourceDisplayName("Admin.Address.AddressAttributes.Fields.AttributeControlType")]
        public int AttributeControlTypeId { get; set; }

        [SmiResourceDisplayName("Admin.Address.AddressAttributes.Fields.AttributeControlType")]
        public string AttributeControlTypeName { get; set; }

        [SmiResourceDisplayName("Admin.Address.AddressAttributes.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        public IList<AddressAttributeLocalizedModel> Locales { get; set; }

        public AddressAttributeValueSearchModel AddressAttributeValueSearchModel { get; set; }

        #endregion
    }

    public partial class AddressAttributeLocalizedModel : ILocalizedLocaleModel
    {
        public int LanguageId { get; set; }

        [SmiResourceDisplayName("Admin.Address.AddressAttributes.Fields.Name")]
        public string Name { get; set; }
    }
}