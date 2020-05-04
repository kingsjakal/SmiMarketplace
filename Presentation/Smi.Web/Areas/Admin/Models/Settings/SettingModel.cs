using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Smi.Web.Areas.Admin.Models.Settings
{
    /// <summary>
    /// Represents a setting model
    /// </summary>
    public partial class SettingModel : BaseSmiEntityModel
    {
        #region Ctor

        public SettingModel()
        {
            AvailableStores = new List<SelectListItem>();
        }

        #endregion

        #region Properties

        [SmiResourceDisplayName("Admin.Configuration.Settings.AllSettings.Fields.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.AllSettings.Fields.Value")]
        public string Value { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.AllSettings.Fields.StoreName")]
        public string Store { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.AllSettings.Fields.Store")]
        public int StoreId { get; set; }
        public IList<SelectListItem> AvailableStores { get; set; }

        #endregion
    }
}