using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Boards
{
    public partial class TopicMoveModel : BaseSmiEntityModel
    {
        public TopicMoveModel()
        {
            ForumList = new List<SelectListItem>();
        }

        public int ForumSelected { get; set; }
        public string TopicSeName { get; set; }
        
        public IEnumerable<SelectListItem> ForumList { get; set; }
    }
}