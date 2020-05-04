using System.Collections.Generic;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Models.Catalog
{
    public partial class ProductReviewOverviewModel : BaseSmiModel
    {
        public int ProductId { get; set; }

        public int RatingSum { get; set; }

        public int TotalReviews { get; set; }

        public bool AllowCustomerReviews { get; set; }
    }

    public partial class ProductReviewsModel : BaseSmiModel
    {
        public ProductReviewsModel()
        {
            Items = new List<ProductReviewModel>();
            AddProductReview = new AddProductReviewModel();
            ReviewTypeList = new List<ReviewTypeModel>();
            AddAdditionalProductReviewList = new List<AddProductReviewReviewTypeMappingModel>();
        }

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string ProductSeName { get; set; }

        public IList<ProductReviewModel> Items { get; set; }

        public AddProductReviewModel AddProductReview { get; set; }

        public IList<ReviewTypeModel> ReviewTypeList { get; set; }

        public IList<AddProductReviewReviewTypeMappingModel> AddAdditionalProductReviewList { get; set; }        
    }

    public partial class ReviewTypeModel : BaseSmiEntityModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int DisplayOrder { get; set; }

        public bool IsRequired { get; set; }

        public bool VisibleToAllCustomers { get; set; }

        public double AverageRating { get; set; }
    }

    public partial class ProductReviewModel : BaseSmiEntityModel
    {
        public ProductReviewModel()
        {
            AdditionalProductReviewList = new List<ProductReviewReviewTypeMappingModel>();
        }

        public int CustomerId { get; set; }

        public string CustomerAvatarUrl { get; set; }

        public string CustomerName { get; set; }

        public bool AllowViewingProfiles { get; set; }
        
        public string Title { get; set; }

        public string ReviewText { get; set; }

        public string ReplyText { get; set; }

        public int Rating { get; set; }

        public string WrittenOnStr { get; set; }

        public ProductReviewHelpfulnessModel Helpfulness { get; set; }

        public IList<ProductReviewReviewTypeMappingModel> AdditionalProductReviewList { get; set; }
    }

    public partial class ProductReviewHelpfulnessModel : BaseSmiModel
    {
        public int ProductReviewId { get; set; }

        public int HelpfulYesTotal { get; set; }

        public int HelpfulNoTotal { get; set; }
    }

    public partial class AddProductReviewModel : BaseSmiModel
    {
        [SmiResourceDisplayName("Reviews.Fields.Title")]
        public string Title { get; set; }
        
        [SmiResourceDisplayName("Reviews.Fields.ReviewText")]
        public string ReviewText { get; set; }

        [SmiResourceDisplayName("Reviews.Fields.Rating")]
        public int Rating { get; set; }

        public bool DisplayCaptcha { get; set; }

        public bool CanCurrentCustomerLeaveReview { get; set; }

        public bool SuccessfullyAdded { get; set; }

        public string Result { get; set; }
    }

    public partial class AddProductReviewReviewTypeMappingModel : BaseSmiEntityModel
    {
        public int ProductReviewId { get; set; }

        public int ReviewTypeId { get; set; }

        public int Rating { get; set; }
        
        public string Name { get; set; }

        public string Description { get; set; }

        public int DisplayOrder { get; set; }

        public bool IsRequired { get; set; }
    }

    public partial class ProductReviewReviewTypeMappingModel : BaseSmiEntityModel
    {
        public int ProductReviewId { get; set; }

        public int ReviewTypeId { get; set; }

        public int Rating { get; set; }

        public string Name { get; set; }

        public bool VisibleToAllCustomers { get; set; }
    }
}