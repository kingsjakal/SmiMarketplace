using Smi.Core.Domain.Forums;
using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Boards
{
    public partial class ForumTopicRowModel : BaseSmiModel
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string SeName { get; set; }
        public int LastPostId { get; set; }

        public int NumPosts { get; set; }
        public int Views { get; set; }
        public int Votes { get; set; }
        public int NumReplies { get; set; }
        public ForumTopicType ForumTopicType { get; set; }

        public int CustomerId { get; set; }
        public bool AllowViewingProfiles { get; set; }
        public string CustomerName { get; set; }

        //posts
        public int TotalPostPages { get; set; }
    }
}