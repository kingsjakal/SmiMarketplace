using System.Collections.Generic;
using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Blogs
{
    public partial class BlogPostYearModel : BaseSmiModel
    {
        public BlogPostYearModel()
        {
            Months = new List<BlogPostMonthModel>();
        }
        public int Year { get; set; }
        public IList<BlogPostMonthModel> Months { get; set; }
    }

    public partial class BlogPostMonthModel : BaseSmiModel
    {
        public int Month { get; set; }

        public int BlogPostCount { get; set; }
    }
}