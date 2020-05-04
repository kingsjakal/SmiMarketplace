using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Payments
{
    /// <summary>
    /// Represents a payment method model
    /// </summary>
    public partial class PaymentMethodModel : BaseSmiModel, IPluginModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.Configuration.Payment.Methods.Fields.FriendlyName")]
        public string FriendlyName { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Payment.Methods.Fields.SystemName")]
        public string SystemName { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Payment.Methods.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Payment.Methods.Fields.IsActive")]
        public bool IsActive { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Payment.Methods.Configure")]
        public string ConfigurationUrl { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Payment.Methods.Fields.Logo")]
        public string LogoUrl { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Payment.Methods.Fields.SupportCapture")]
        public bool SupportCapture { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Payment.Methods.Fields.SupportPartiallyRefund")]
        public bool SupportPartiallyRefund { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Payment.Methods.Fields.SupportRefund")]
        public bool SupportRefund { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Payment.Methods.Fields.SupportVoid")]
        public bool SupportVoid { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Payment.Methods.Fields.RecurringPaymentType")]
        public string RecurringPaymentType { get; set; }

        #endregion
    }
}