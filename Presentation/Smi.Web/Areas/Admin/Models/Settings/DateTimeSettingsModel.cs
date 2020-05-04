using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Settings
{
    /// <summary>
    /// Represents a date time settings model
    /// </summary>
    public partial class DateTimeSettingsModel : BaseSmiModel, ISettingsModel
    {
        #region Ctor

        public DateTimeSettingsModel()
        {
            AvailableTimeZones = new List<SelectListItem>();
        }

        #endregion

        #region Properties

        public int ActiveStoreScopeConfiguration { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.CustomerUser.AllowCustomersToSetTimeZone")]
        public bool AllowCustomersToSetTimeZone { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.CustomerUser.DefaultStoreTimeZone")]
        public string DefaultStoreTimeZoneId { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.CustomerUser.DefaultStoreTimeZone")]
        public IList<SelectListItem> AvailableTimeZones { get; set; }

        #endregion
    }
}