using System.ComponentModel.DataAnnotations;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Messages
{
    /// <summary>
    /// Represents a newsletter subscription model
    /// </summary>
    public partial class NewsletterSubscriptionModel : BaseSmiEntityModel
    {
        #region Properties

        [DataType(DataType.EmailAddress)]
        [SmiResourceDisplayName("Admin.Promotions.NewsLetterSubscriptions.Fields.Email")]
        public string Email { get; set; }

        [SmiResourceDisplayName("Admin.Promotions.NewsLetterSubscriptions.Fields.Active")]
        public bool Active { get; set; }

        [SmiResourceDisplayName("Admin.Promotions.NewsLetterSubscriptions.Fields.Store")]
        public string StoreName { get; set; }

        [SmiResourceDisplayName("Admin.Promotions.NewsLetterSubscriptions.Fields.CreatedOn")]
        public string CreatedOn { get; set; }

        #endregion
    }
}