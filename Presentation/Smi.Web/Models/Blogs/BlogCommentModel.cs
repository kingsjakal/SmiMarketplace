using System;
using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Blogs
{
    public partial class BlogCommentModel : BaseSmiEntityModel
    {
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string CustomerAvatarUrl { get; set; }

        public string CommentText { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool AllowViewingProfiles { get; set; }
    }
}