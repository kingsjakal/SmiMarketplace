using System.Collections.Generic;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Home
{
    /// <summary>
    /// Represents a SmiMarketplace news model
    /// </summary>
    public partial class SmiMarketplaceNewsModel : BaseSmiModel
    {
        #region Ctor

        public SmiMarketplaceNewsModel()
        {
            Items = new List<SmiMarketplaceNewsDetailsModel>();
        }

        #endregion

        #region Properties

        public List<SmiMarketplaceNewsDetailsModel> Items { get; set; }

        public bool HasNewItems { get; set; }

        public bool HideAdvertisements { get; set; }

        #endregion
    }
}