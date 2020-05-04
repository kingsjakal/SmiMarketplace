using System.Collections.Generic;
using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Boards
{
    public partial class BoardsIndexModel : BaseSmiModel
    {
        public BoardsIndexModel()
        {
            ForumGroups = new List<ForumGroupModel>();
        }
        
        public IList<ForumGroupModel> ForumGroups { get; set; }
    }
}