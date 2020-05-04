using System.Collections.Generic;
using Smi.Web.Framework.Models;
using Smi.Web.Models.Common;

namespace Smi.Web.Models.PrivateMessages
{
    public partial class PrivateMessageListModel : BaseSmiModel
    {
        public IList<PrivateMessageModel> Messages { get; set; }
        public PagerModel PagerModel { get; set; }
    }
}