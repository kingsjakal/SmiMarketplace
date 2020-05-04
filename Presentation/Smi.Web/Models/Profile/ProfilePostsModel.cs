using System.Collections.Generic;
using Smi.Web.Framework.Models;
using Smi.Web.Models.Common;

namespace Smi.Web.Models.Profile
{
    public partial class ProfilePostsModel : BaseSmiModel
    {
        public IList<PostsModel> Posts { get; set; }
        public PagerModel PagerModel { get; set; }
    }
}