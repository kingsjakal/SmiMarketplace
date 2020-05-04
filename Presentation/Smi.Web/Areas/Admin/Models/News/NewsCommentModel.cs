using System;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.News
{
    /// <summary>
    /// Represents a news comment model
    /// </summary>
    public partial class NewsCommentModel : BaseSmiEntityModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.ContentManagement.News.Comments.Fields.NewsItem")]
        public int NewsItemId { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.News.Comments.Fields.NewsItem")]
        public string NewsItemTitle { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.News.Comments.Fields.Customer")]
        public int CustomerId { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.News.Comments.Fields.Customer")]
        public string CustomerInfo { get; set; }
        
        [SmiResourceDisplayName("Admin.ContentManagement.News.Comments.Fields.CommentTitle")]
        public string CommentTitle { get; set; }
        
        [SmiResourceDisplayName("Admin.ContentManagement.News.Comments.Fields.CommentText")]
        public string CommentText { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.News.Comments.Fields.IsApproved")]
        public bool IsApproved { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.News.Comments.Fields.StoreName")]
        public int StoreId { get; set; }

        public string StoreName { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.News.Comments.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        #endregion
    }
}