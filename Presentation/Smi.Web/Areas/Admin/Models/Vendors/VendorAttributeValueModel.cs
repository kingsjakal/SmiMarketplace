using System.Collections.Generic;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Vendors
{
    /// <summary>
    /// Represents a vendor attribute value model
    /// </summary>
    public partial class VendorAttributeValueModel : BaseSmiEntityModel, ILocalizedModel<VendorAttributeValueLocalizedModel>
    {
        #region Ctor

        public VendorAttributeValueModel()
        {
            Locales = new List<VendorAttributeValueLocalizedModel>();
        }

        #endregion

        #region Properties

        public int VendorAttributeId { get; set; }

        [SmiResourceDisplayName("Admin.Vendors.VendorAttributes.Values.Fields.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.Vendors.VendorAttributes.Values.Fields.IsPreSelected")]
        public bool IsPreSelected { get; set; }

        [SmiResourceDisplayName("Admin.Vendors.VendorAttributes.Values.Fields.DisplayOrder")]
        public int DisplayOrder {get;set;}

        public IList<VendorAttributeValueLocalizedModel> Locales { get; set; }

        #endregion
    }

    public partial class VendorAttributeValueLocalizedModel : ILocalizedLocaleModel
    {
        public int LanguageId { get; set; }

        [SmiResourceDisplayName("Admin.Vendors.VendorAttributes.Values.Fields.Name")]
        public string Name { get; set; }
    }
}