using System.Collections.Generic;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Common
{
    /// <summary>
    /// Represents an address attribute value model
    /// </summary>
    public partial class AddressAttributeValueModel : BaseSmiEntityModel, ILocalizedModel<AddressAttributeValueLocalizedModel>
    {
        #region Ctor

        public AddressAttributeValueModel()
        {
            Locales = new List<AddressAttributeValueLocalizedModel>();
        }

        #endregion

        #region Properties

        public int AddressAttributeId { get; set; }

        [SmiResourceDisplayName("Admin.Address.AddressAttributes.Values.Fields.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.Address.AddressAttributes.Values.Fields.IsPreSelected")]
        public bool IsPreSelected { get; set; }

        [SmiResourceDisplayName("Admin.Address.AddressAttributes.Values.Fields.DisplayOrder")]
        public int DisplayOrder {get;set;}

        public IList<AddressAttributeValueLocalizedModel> Locales { get; set; }

        #endregion
    }

    public partial class AddressAttributeValueLocalizedModel : ILocalizedLocaleModel
    {
        public int LanguageId { get; set; }

        [SmiResourceDisplayName("Admin.Address.AddressAttributes.Values.Fields.Name")]
        public string Name { get; set; }
    }
}