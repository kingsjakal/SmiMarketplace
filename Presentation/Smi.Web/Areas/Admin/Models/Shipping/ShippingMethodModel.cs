using System.Collections.Generic;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Shipping
{
    /// <summary>
    /// Represents a shipping method model
    /// </summary>
    public partial class ShippingMethodModel : BaseSmiEntityModel, ILocalizedModel<ShippingMethodLocalizedModel>
    {
        #region Ctor

        public ShippingMethodModel()
        {
            Locales = new List<ShippingMethodLocalizedModel>();
        }

        #endregion

        #region Properties

        [SmiResourceDisplayName("Admin.Configuration.Shipping.Methods.Fields.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Shipping.Methods.Fields.Description")]
        public string Description { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Shipping.Methods.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        public IList<ShippingMethodLocalizedModel> Locales { get; set; }

        #endregion
    }

    public partial class ShippingMethodLocalizedModel : ILocalizedLocaleModel
    {
        public int LanguageId { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Shipping.Methods.Fields.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Shipping.Methods.Fields.Description")]
        public string Description { get; set; }
    }
}