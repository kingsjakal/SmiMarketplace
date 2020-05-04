using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Plugins
{
    /// <summary>
    /// Represents a plugin search model
    /// </summary>
    public partial class PluginSearchModel : BaseSearchModel
    {
        #region Ctor

        public PluginSearchModel()
        {
            AvailableLoadModes = new List<SelectListItem>();
            AvailableGroups = new List<SelectListItem>();
        }

        #endregion

        #region Properties

        [SmiResourceDisplayName("Admin.Configuration.Plugins.LoadMode")]
        public int SearchLoadModeId { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Plugins.Group")]
        public string SearchGroup { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Plugins.FriendlyName")]
        public string SearchFriendlyName { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Plugins.Author")]
        public string SearchAuthor { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Plugins.LoadMode")]
        public IList<SelectListItem> AvailableLoadModes { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Plugins.Group")]
        public IList<SelectListItem> AvailableGroups { get; set; }

        public bool NeedToRestart { get; set; }

        #endregion
    }
}