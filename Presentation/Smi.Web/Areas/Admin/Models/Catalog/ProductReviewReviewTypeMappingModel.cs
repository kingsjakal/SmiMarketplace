using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a product review and review type mapping model
    /// </summary>
    public class ProductReviewReviewTypeMappingModel : BaseSmiEntityModel
    {
        #region Properties

        public int ProductReviewId { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.ProductReviewsExt.Fields.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.ProductReviewsExt.Fields.Description")]
        public string Description { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.ProductReviewsExt.Fields.VisibleToAllCustomers")]
        public bool VisibleToAllCustomers { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.ProductReviewsExt.Fields.Rating")]
        public int Rating { get; set; }

        #endregion
    }
}
