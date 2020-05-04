using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Plugin.Payments.Manual.Models
{
    public class PaymentInfoModel : BaseSmiModel
    {
        public PaymentInfoModel()
        {
            CreditCardTypes = new List<SelectListItem>();
            ExpireMonths = new List<SelectListItem>();
            ExpireYears = new List<SelectListItem>();
        }

        [SmiResourceDisplayName("Payment.SelectCreditCard")]
        public string CreditCardType { get; set; }

        [SmiResourceDisplayName("Payment.SelectCreditCard")]
        public IList<SelectListItem> CreditCardTypes { get; set; }

        [SmiResourceDisplayName("Payment.CardholderName")]
        public string CardholderName { get; set; }

        [SmiResourceDisplayName("Payment.CardNumber")]
        public string CardNumber { get; set; }

        [SmiResourceDisplayName("Payment.ExpirationDate")]
        public string ExpireMonth { get; set; }

        [SmiResourceDisplayName("Payment.ExpirationDate")]
        public string ExpireYear { get; set; }

        public IList<SelectListItem> ExpireMonths { get; set; }

        public IList<SelectListItem> ExpireYears { get; set; }

        [SmiResourceDisplayName("Payment.CardCode")]
        public string CardCode { get; set; }
    }
}