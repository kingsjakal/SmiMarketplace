using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Profile
{
    public partial class PostsModel : BaseSmiModel
    {
        public int ForumTopicId { get; set; }
        public string ForumTopicTitle { get; set; }
        public string ForumTopicSlug { get; set; }
        public string ForumPostText { get; set; }
        public string Posted { get; set; }
    }
}