using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a model of products that use the specification attribute
    /// </summary>
    public partial class SpecificationAttributeProductModel : BaseSmiEntityModel
    {
        #region Properties

        public int SpecificationAttributeId { get; set; }

        public int ProductId { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Attributes.SpecificationAttributes.UsedByProducts.Product")]
        public string ProductName { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Attributes.SpecificationAttributes.UsedByProducts.Published")]
        public bool Published { get; set; }

        #endregion
    }
}