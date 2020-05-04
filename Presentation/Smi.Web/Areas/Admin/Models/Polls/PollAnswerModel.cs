using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Polls
{
    /// <summary>
    /// Represents a poll answer model
    /// </summary>
    public partial class PollAnswerModel : BaseSmiEntityModel
    {
        #region Properties

        public int PollId { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.Polls.Answers.Fields.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.Polls.Answers.Fields.NumberOfVotes")]
        public int NumberOfVotes { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.Polls.Answers.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        #endregion
    }
}