using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Profile
{
    public partial class ProfileIndexModel : BaseSmiModel
    {
        public int CustomerProfileId { get; set; }
        public string ProfileTitle { get; set; }
        public int PostsPage { get; set; }
        public bool PagingPosts { get; set; }
        public bool ForumsEnabled { get; set; }
    }
}