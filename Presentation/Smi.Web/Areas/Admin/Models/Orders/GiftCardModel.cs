using System;
using System.ComponentModel.DataAnnotations;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Orders
{
    /// <summary>
    /// Represents a gift card model
    /// </summary>
    public partial class GiftCardModel: BaseSmiEntityModel
    {
        #region Ctor

        public GiftCardModel()
        {
            GiftCardUsageHistorySearchModel = new GiftCardUsageHistorySearchModel();
        }

        #endregion

        #region Properties

        [SmiResourceDisplayName("Admin.GiftCards.Fields.GiftCardType")]
        public int GiftCardTypeId { get; set; }

        [SmiResourceDisplayName("Admin.GiftCards.Fields.OrderId")]
        public int? PurchasedWithOrderId { get; set; }

        [SmiResourceDisplayName("Admin.GiftCards.Fields.CustomOrderNumber")]
        public string PurchasedWithOrderNumber { get; set; }

        [SmiResourceDisplayName("Admin.GiftCards.Fields.Amount")]
        public decimal Amount { get; set; }

        [SmiResourceDisplayName("Admin.GiftCards.Fields.Amount")]
        public string AmountStr { get; set; }

        [SmiResourceDisplayName("Admin.GiftCards.Fields.RemainingAmount")]
        public string RemainingAmountStr { get; set; }

        [SmiResourceDisplayName("Admin.GiftCards.Fields.IsGiftCardActivated")]
        public bool IsGiftCardActivated { get; set; }

        [SmiResourceDisplayName("Admin.GiftCards.Fields.GiftCardCouponCode")]
        public string GiftCardCouponCode { get; set; }

        [SmiResourceDisplayName("Admin.GiftCards.Fields.RecipientName")]
        public string RecipientName { get; set; }

        [DataType(DataType.EmailAddress)]
        [SmiResourceDisplayName("Admin.GiftCards.Fields.RecipientEmail")]
        public string RecipientEmail { get; set; }

        [SmiResourceDisplayName("Admin.GiftCards.Fields.SenderName")]
        public string SenderName { get; set; }

        [DataType(DataType.EmailAddress)]
        [SmiResourceDisplayName("Admin.GiftCards.Fields.SenderEmail")]
        public string SenderEmail { get; set; }

        [SmiResourceDisplayName("Admin.GiftCards.Fields.Message")]
        public string Message { get; set; }

        [SmiResourceDisplayName("Admin.GiftCards.Fields.IsRecipientNotified")]
        public bool IsRecipientNotified { get; set; }

        [SmiResourceDisplayName("Admin.GiftCards.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        public string PrimaryStoreCurrencyCode { get; set; }

        public GiftCardUsageHistorySearchModel GiftCardUsageHistorySearchModel { get; set; }

        #endregion
    }
}