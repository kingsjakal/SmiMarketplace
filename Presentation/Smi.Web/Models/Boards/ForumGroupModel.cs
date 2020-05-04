using System.Collections.Generic;
using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Boards
{
    public partial  class ForumGroupModel : BaseSmiModel
    {
        public ForumGroupModel()
        {
            Forums = new List<ForumRowModel>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string SeName { get; set; }

        public IList<ForumRowModel> Forums { get; set; }
    }
}