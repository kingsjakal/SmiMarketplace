using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Plugin.Widgets.FacebookPixel.Models
{
    /// <summary>
    /// Represents a Facebook Pixel model
    /// </summary>
    public class FacebookPixelModel : BaseSmiEntityModel
    {
        #region Ctor

        public FacebookPixelModel()
        {
            AvailableStores = new List<SelectListItem>();
            CustomEventSearchModel = new CustomEventSearchModel();
        }

        #endregion

        #region Properties

        [SmiResourceDisplayName("Plugins.Widgets.FacebookPixel.Configuration.Fields.PixelId")]
        public string PixelId { get; set; }

        [SmiResourceDisplayName("Plugins.Widgets.FacebookPixel.Configuration.Fields.DisableForUsersNotAcceptingCookieConsent")]
        public bool DisableForUsersNotAcceptingCookieConsent { get; set; }

        [SmiResourceDisplayName("Plugins.Widgets.FacebookPixel.Configuration.Fields.Enabled")]
        public bool Enabled { get; set; }

        [SmiResourceDisplayName("Plugins.Widgets.FacebookPixel.Configuration.Fields.Store")]
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public IList<SelectListItem> AvailableStores { get; set; }
        public bool HideStoresList { get; set; }

        [SmiResourceDisplayName("Plugins.Widgets.FacebookPixel.Configuration.Fields.UseAdvancedMatching")]
        public bool UseAdvancedMatching { get; set; }

        [SmiResourceDisplayName("Plugins.Widgets.FacebookPixel.Configuration.Fields.PassUserProperties")]
        public bool PassUserProperties { get; set; }

        [SmiResourceDisplayName("Plugins.Widgets.FacebookPixel.Configuration.Fields.TrackPageView")]
        public bool TrackPageView { get; set; }

        [SmiResourceDisplayName("Plugins.Widgets.FacebookPixel.Configuration.Fields.TrackAddToCart")]
        public bool TrackAddToCart { get; set; }

        [SmiResourceDisplayName("Plugins.Widgets.FacebookPixel.Configuration.Fields.TrackPurchase")]
        public bool TrackPurchase { get; set; }

        [SmiResourceDisplayName("Plugins.Widgets.FacebookPixel.Configuration.Fields.TrackViewContent")]
        public bool TrackViewContent { get; set; }

        [SmiResourceDisplayName("Plugins.Widgets.FacebookPixel.Configuration.Fields.TrackAddToWishlist")]
        public bool TrackAddToWishlist { get; set; }

        [SmiResourceDisplayName("Plugins.Widgets.FacebookPixel.Configuration.Fields.TrackInitiateCheckout")]
        public bool TrackInitiateCheckout { get; set; }

        [SmiResourceDisplayName("Plugins.Widgets.FacebookPixel.Configuration.Fields.TrackSearch")]
        public bool TrackSearch { get; set; }

        [SmiResourceDisplayName("Plugins.Widgets.FacebookPixel.Configuration.Fields.TrackContact")]
        public bool TrackContact { get; set; }

        [SmiResourceDisplayName("Plugins.Widgets.FacebookPixel.Configuration.Fields.TrackCompleteRegistration")]
        public bool TrackCompleteRegistration { get; set; }

        public bool HideCustomEventsSearch { get; set; }

        public CustomEventSearchModel CustomEventSearchModel { get; set; }

        #endregion
    }
}