using System;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a product review model
    /// </summary>
    public partial class ProductReviewModel : BaseSmiEntityModel
    {
        #region Ctor

        public ProductReviewModel()
        {
            ProductReviewReviewTypeMappingSearchModel = new ProductReviewReviewTypeMappingSearchModel();            
        }

        #endregion

        #region Properties

        [SmiResourceDisplayName("Admin.Catalog.ProductReviews.Fields.Store")]
        public string StoreName { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.ProductReviews.Fields.Product")]
        public int ProductId { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.ProductReviews.Fields.Product")]
        public string ProductName { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.ProductReviews.Fields.Customer")]
        public int CustomerId { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.ProductReviews.Fields.Customer")]
        public string CustomerInfo { get; set; }
        
        [SmiResourceDisplayName("Admin.Catalog.ProductReviews.Fields.Title")]
        public string Title { get; set; }
        
        [SmiResourceDisplayName("Admin.Catalog.ProductReviews.Fields.ReviewText")]
        public string ReviewText { get; set; }
        
        [SmiResourceDisplayName("Admin.Catalog.ProductReviews.Fields.ReplyText")]
        public string ReplyText { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.ProductReviews.Fields.Rating")]
        public int Rating { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.ProductReviews.Fields.IsApproved")]
        public bool IsApproved { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.ProductReviews.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        //vendor
        public bool IsLoggedInAsVendor { get; set; }

        public ProductReviewReviewTypeMappingSearchModel ProductReviewReviewTypeMappingSearchModel { get; set; }

        #endregion
    }
}