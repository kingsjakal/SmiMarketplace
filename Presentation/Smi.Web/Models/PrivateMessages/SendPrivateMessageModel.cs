using Smi.Web.Framework.Models;

namespace Smi.Web.Models.PrivateMessages
{
    public partial class SendPrivateMessageModel : BaseSmiEntityModel
    {
        public int ToCustomerId { get; set; }
        public string CustomerToName { get; set; }
        public bool AllowViewingToProfile { get; set; }

        public int ReplyToMessageId { get; set; }
        
        public string Subject { get; set; }
        
        public string Message { get; set; }
    }
}