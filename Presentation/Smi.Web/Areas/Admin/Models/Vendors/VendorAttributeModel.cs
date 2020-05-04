using System.Collections.Generic;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Vendors
{
    /// <summary>
    /// Represents a vendor attribute model
    /// </summary>
    public partial class VendorAttributeModel : BaseSmiEntityModel, ILocalizedModel<VendorAttributeLocalizedModel>
    {
        #region Ctor

        public VendorAttributeModel()
        {
            Locales = new List<VendorAttributeLocalizedModel>();
            VendorAttributeValueSearchModel = new VendorAttributeValueSearchModel();
        }

        #endregion

        #region Properties

        [SmiResourceDisplayName("Admin.Vendors.VendorAttributes.Fields.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.Vendors.VendorAttributes.Fields.IsRequired")]
        public bool IsRequired { get; set; }

        [SmiResourceDisplayName("Admin.Vendors.VendorAttributes.Fields.AttributeControlType")]
        public int AttributeControlTypeId { get; set; }

        [SmiResourceDisplayName("Admin.Vendors.VendorAttributes.Fields.AttributeControlType")]
        public string AttributeControlTypeName { get; set; }

        [SmiResourceDisplayName("Admin.Vendors.VendorAttributes.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        public IList<VendorAttributeLocalizedModel> Locales { get; set; }

        public VendorAttributeValueSearchModel VendorAttributeValueSearchModel { get; set; }

        #endregion
    }

    public partial class VendorAttributeLocalizedModel : ILocalizedLocaleModel
    {
        public int LanguageId { get; set; }

        [SmiResourceDisplayName("Admin.Vendors.VendorAttributes.Fields.Name")]
        public string Name { get; set; }
    }
}