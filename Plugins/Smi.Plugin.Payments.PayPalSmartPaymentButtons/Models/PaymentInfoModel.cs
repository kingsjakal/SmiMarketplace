using Smi.Web.Framework.Models;

namespace Smi.Plugin.Payments.PayPalSmartPaymentButtons.Models
{
    /// <summary>
    /// Represents a payment info model
    /// </summary>
    public class PaymentInfoModel : BaseSmiModel
    {
        #region Properties

        public string OrderId { get; set; }

        public string Errors { get; set; }

        #endregion
    }
}