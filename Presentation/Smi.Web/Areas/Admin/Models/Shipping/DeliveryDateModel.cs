using System.Collections.Generic;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Shipping
{
    /// <summary>
    /// Represents a delivery date model
    /// </summary>
    public partial class DeliveryDateModel : BaseSmiEntityModel, ILocalizedModel<DeliveryDateLocalizedModel>
    {
        #region Ctor

        public DeliveryDateModel()
        {
            Locales = new List<DeliveryDateLocalizedModel>();
        }

        #endregion

        #region Properties

        [SmiResourceDisplayName("Admin.Configuration.Shipping.DeliveryDates.Fields.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Shipping.DeliveryDates.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        public IList<DeliveryDateLocalizedModel> Locales { get; set; }

        #endregion
    }

    public partial class DeliveryDateLocalizedModel : ILocalizedLocaleModel
    {
        public int LanguageId { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Shipping.DeliveryDates.Fields.Name")]
        public string Name { get; set; }
    }
}