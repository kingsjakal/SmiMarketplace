using System;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Home
{
    /// <summary>
    /// Represents a SmiMarketplace news details model
    /// </summary>
    public partial class SmiMarketplaceNewsDetailsModel : BaseSmiModel
    {
        #region Properties

        public string Title { get; set; }

        public string Url { get; set; }

        public string Summary { get; set; }

        public DateTimeOffset PublishDate { get; set; }

        #endregion
    }
}