using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Smi.Web.Framework.TagHelpers.Admin
{
    /// <summary>
    /// Smi-panel tag helper
    /// </summary>
    [HtmlTargetElement("Smi-panels", Attributes = ID_ATTRIBUTE_NAME)]
    public class SmiPanelsTagHelper : TagHelper
    {
        private const string ID_ATTRIBUTE_NAME = "id";

        /// <summary>
        /// ViewContext
        /// </summary>
        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }
    }
}