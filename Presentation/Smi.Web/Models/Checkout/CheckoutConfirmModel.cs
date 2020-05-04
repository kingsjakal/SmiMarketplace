using System.Collections.Generic;
using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Checkout
{
    public partial class CheckoutConfirmModel : BaseSmiModel
    {
        public CheckoutConfirmModel()
        {
            Warnings = new List<string>();
        }

        public bool TermsOfServiceOnOrderConfirmPage { get; set; }
        public bool TermsOfServicePopup { get; set; }
        public string MinOrderTotalWarning { get; set; }

        public IList<string> Warnings { get; set; }
    }
}