using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Plugin.Widgets.FacebookPixel.Models
{
    /// <summary>
    /// Represents a Facebook Pixel search model
    /// </summary>
    public class FacebookPixelSearchModel : BaseSearchModel
    {
        #region Ctor

        public FacebookPixelSearchModel()
        {
            AvailableStores = new List<SelectListItem>();
        }

        #endregion

        #region Properties

        [SmiResourceDisplayName("Plugins.Widgets.FacebookPixel.Configuration.Search.Store")]
        public int StoreId { get; set; }

        public IList<SelectListItem> AvailableStores { get; set; }

        public bool HideStoresList { get; set; }

        public bool HideSearchBlock { get; set; }

        #endregion
    }
}