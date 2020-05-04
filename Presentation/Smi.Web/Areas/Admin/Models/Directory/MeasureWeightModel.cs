using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Directory
{
    /// <summary>
    /// Represents a measure weight model
    /// </summary>
    public partial class MeasureWeightModel : BaseSmiEntityModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.Configuration.Shipping.Measures.Weights.Fields.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Shipping.Measures.Weights.Fields.SystemKeyword")]
        public string SystemKeyword { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Shipping.Measures.Weights.Fields.Ratio")]
        public decimal Ratio { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Shipping.Measures.Weights.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Shipping.Measures.Weights.Fields.IsPrimaryWeight")]
        public bool IsPrimaryWeight { get; set; }

        #endregion
    }
}