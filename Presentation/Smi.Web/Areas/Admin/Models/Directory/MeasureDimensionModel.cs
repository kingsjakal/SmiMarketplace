using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Directory
{
    /// <summary>
    /// Represents a measure dimension model
    /// </summary>
    public partial class MeasureDimensionModel : BaseSmiEntityModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.Configuration.Shipping.Measures.Dimensions.Fields.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Shipping.Measures.Dimensions.Fields.SystemKeyword")]
        public string SystemKeyword { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Shipping.Measures.Dimensions.Fields.Ratio")]
        public decimal Ratio { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Shipping.Measures.Dimensions.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Shipping.Measures.Dimensions.Fields.IsPrimaryDimension")]
        public bool IsPrimaryDimension { get; set; }

        #endregion
    }
}