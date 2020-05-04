using System;
using System.Collections.Generic;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Forums
{
    /// <summary>
    /// Represents a forum list model
    /// </summary>
    public partial class ForumModel : BaseSmiEntityModel
    {
        #region Ctor

        public ForumModel()
        {
            ForumGroups = new List<ForumGroupModel>();
        }

        #endregion

        #region Properties

        [SmiResourceDisplayName("Admin.ContentManagement.Forums.Forum.Fields.ForumGroupId")]
        public int ForumGroupId { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.Forums.Forum.Fields.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.Forums.Forum.Fields.Description")]
        public string Description { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.Forums.Forum.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [SmiResourceDisplayName("Admin.ContentManagement.Forums.Forum.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        public List<ForumGroupModel> ForumGroups { get; set; }

        #endregion
    }
}