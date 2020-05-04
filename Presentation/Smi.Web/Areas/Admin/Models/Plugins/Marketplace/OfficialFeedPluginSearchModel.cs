using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Plugins.Marketplace
{
    /// <summary>
    /// Represents a search model of plugins of the official feed
    /// </summary>
    public partial class OfficialFeedPluginSearchModel : BaseSearchModel
    {
        #region Ctor

        public OfficialFeedPluginSearchModel()
        {
            AvailableVersions = new List<SelectListItem>();
            AvailableCategories = new List<SelectListItem>();
            AvailablePrices = new List<SelectListItem>();
        }

        #endregion

        #region Properties

        [SmiResourceDisplayName("Admin.Configuration.Plugins.OfficialFeed.Name")]
        public string SearchName { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Plugins.OfficialFeed.Version")]
        public int SearchVersionId { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Plugins.OfficialFeed.Category")]
        public int SearchCategoryId { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Plugins.OfficialFeed.Price")]
        public int SearchPriceId { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Plugins.OfficialFeed.Version")]
        public IList<SelectListItem> AvailableVersions { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Plugins.OfficialFeed.Category")]
        public IList<SelectListItem> AvailableCategories { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Plugins.OfficialFeed.Price")]
        public IList<SelectListItem> AvailablePrices { get; set; }

        #endregion
    }
}