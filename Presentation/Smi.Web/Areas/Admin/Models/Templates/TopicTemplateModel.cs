using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Templates
{
    /// <summary>
    /// Represents a topic template model
    /// </summary>
    public partial class TopicTemplateModel : BaseSmiEntityModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.System.Templates.Topic.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.System.Templates.Topic.ViewPath")]
        public string ViewPath { get; set; }

        [SmiResourceDisplayName("Admin.System.Templates.Topic.DisplayOrder")]
        public int DisplayOrder { get; set; }

        #endregion
    }
}