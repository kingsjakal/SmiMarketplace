using System.Collections.Generic;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Orders
{
    /// <summary>
    /// Represents a return request reason model
    /// </summary>
    public partial class ReturnRequestReasonModel : BaseSmiEntityModel, ILocalizedModel<ReturnRequestReasonLocalizedModel>
    {
        #region Ctor

        public ReturnRequestReasonModel()
        {
            Locales = new List<ReturnRequestReasonLocalizedModel>();
        }

        #endregion

        #region Properties

        [SmiResourceDisplayName("Admin.Configuration.Settings.Order.ReturnRequestReasons.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.Order.ReturnRequestReasons.DisplayOrder")]
        public int DisplayOrder { get; set; }

        public IList<ReturnRequestReasonLocalizedModel> Locales { get; set; }

        #endregion
    }

    public partial class ReturnRequestReasonLocalizedModel : ILocalizedLocaleModel
    {
        public int LanguageId { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.Order.ReturnRequestReasons.Name")]
        public string Name { get; set; }
    }
}