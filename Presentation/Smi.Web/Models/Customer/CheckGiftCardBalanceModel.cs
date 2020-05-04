using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Smi.Web.Models.Customer
{
    public partial class CheckGiftCardBalanceModel : BaseSmiModel
    {
        public string Result { get; set; }

        public string Message { get; set; }
        
        [SmiResourceDisplayName("ShoppingCart.GiftCardCouponCode.Tooltip")]
        public string GiftCardCode { get; set; }
    }
}
