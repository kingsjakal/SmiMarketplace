using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Plugin.Tax.Avalara.Models.Tax
{
    /// <summary>
    /// Represents an extended tax category model
    /// </summary>
    public class TaxCategoryModel : Smi.Web.Areas.Admin.Models.Tax.TaxCategoryModel
    {
        #region Properties

        public string Description { get; set; }

        [SmiResourceDisplayName("Plugins.Tax.Avalara.Fields.TaxCodeType")]
        public string TypeId { get; set; }
        public string Type { get; set; }

        #endregion
    }
}