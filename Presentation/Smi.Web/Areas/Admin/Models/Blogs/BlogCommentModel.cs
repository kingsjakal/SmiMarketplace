using System;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Blogs
{
    /// <summary>
    /// Represents a blog comment model
    /// </summary>
    public partial class BlogCommentModel : BaseSmiEntityModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.ContentManagement.Blog.Comments.Fields.BlogPost")]
        public int BlogPostId { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.Blog.Comments.Fields.BlogPost")]
        public string BlogPostTitle { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.Blog.Comments.Fields.Customer")]
        public int CustomerId { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.Blog.Comments.Fields.Customer")]
        public string CustomerInfo { get; set; }
        
        [SmiResourceDisplayName("Admin.ContentManagement.Blog.Comments.Fields.Comment")]
        public string Comment { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.Blog.Comments.Fields.IsApproved")]
        public bool IsApproved { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.Blog.Comments.Fields.StoreName")]
        public int StoreId { get; set; }
        public string StoreName { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.Blog.Comments.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        #endregion
    }
}