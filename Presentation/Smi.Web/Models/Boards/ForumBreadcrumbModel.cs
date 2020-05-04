using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Boards
{
    public partial class ForumBreadcrumbModel : BaseSmiModel
    {
        public int ForumGroupId { get; set; }
        public string ForumGroupName { get; set; }
        public string ForumGroupSeName { get; set; }
        
        public int ForumId { get; set; }
        public string ForumName { get; set; }
        public string ForumSeName { get; set; }

        public int ForumTopicId { get; set; }
        public string ForumTopicSubject { get; set; }
        public string ForumTopicSeName { get; set; }
    }
}