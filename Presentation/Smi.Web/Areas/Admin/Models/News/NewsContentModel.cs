using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.News
{
    /// <summary>
    /// Represents a news content model
    /// </summary>
    public partial class NewsContentModel : BaseSmiModel
    {
        #region Ctor

        public NewsContentModel()
        {
            NewsItems = new NewsItemSearchModel();
            NewsComments = new NewsCommentSearchModel();
            SearchTitle = new NewsItemSearchModel().SearchTitle;
        }

        #endregion

        #region Properties

        [SmiResourceDisplayName("Admin.ContentManagement.News.NewsItems.List.SearchTitle")]
        public string SearchTitle { get; set; }

        public NewsItemSearchModel NewsItems { get; set; }

        public NewsCommentSearchModel NewsComments { get; set; }

        #endregion
    }
}
