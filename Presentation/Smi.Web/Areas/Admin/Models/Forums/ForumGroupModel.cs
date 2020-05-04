using System;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Forums
{
    /// <summary>
    /// Represents a forum group model
    /// </summary>
    public partial class ForumGroupModel : BaseSmiEntityModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.ContentManagement.Forums.ForumGroup.Fields.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.Forums.ForumGroup.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.Forums.ForumGroup.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        #endregion
    }
}