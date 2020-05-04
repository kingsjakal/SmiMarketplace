using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Blogs
{
    public partial class BlogPostTagModel : BaseSmiModel
    {
        public string Name { get; set; }

        public int BlogPostCount { get; set; }
    }
}