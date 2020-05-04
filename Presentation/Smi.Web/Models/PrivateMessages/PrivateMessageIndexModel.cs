using Smi.Web.Framework.Models;

namespace Smi.Web.Models.PrivateMessages
{
    public partial class PrivateMessageIndexModel : BaseSmiModel
    {
        public int InboxPage { get; set; }
        public int SentItemsPage { get; set; }
        public bool SentItemsTabSelected { get; set; }
    }
}