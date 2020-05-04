using System.Collections.Generic;
using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Blogs
{
    public partial class BlogPostListModel : BaseSmiModel
    {
        public BlogPostListModel()
        {
            PagingFilteringContext = new BlogPagingFilteringModel();
            BlogPosts = new List<BlogPostModel>();
        }

        public int WorkingLanguageId { get; set; }
        public BlogPagingFilteringModel PagingFilteringContext { get; set; }
        public IList<BlogPostModel> BlogPosts { get; set; }
    }
}