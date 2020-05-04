using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Models.News
{
    public partial class AddNewsCommentModel : BaseSmiModel
    {
        [SmiResourceDisplayName("News.Comments.CommentTitle")]
        public string CommentTitle { get; set; }

        [SmiResourceDisplayName("News.Comments.CommentText")]
        public string CommentText { get; set; }

        public bool DisplayCaptcha { get; set; }
    }
}