using FluentValidation;
using Smi.Plugin.Payments.PayPalSmartPaymentButtons.Models;
using Smi.Services.Localization;
using Smi.Web.Framework.Validators;

namespace Smi.Plugin.Payments.PayPalSmartPaymentButtons.Validators
{
    /// <summary>
    /// Represents configuration model validator
    /// </summary>
    public class ConfigurationValidator : BaseSmiValidator<ConfigurationModel>
    {
        #region Ctor

        public ConfigurationValidator(ILocalizationService localizationService)
        {
            RuleFor(model => model.ClientId)
                .NotEmpty()
                .WithMessage(localizationService.GetResource("Plugins.Payments.PayPalSmartPaymentButtons.Fields.ClientId.Required"))
                .When(model => !model.UseSandbox);

            RuleFor(model => model.SecretKey)
                .NotEmpty()
                .WithMessage(localizationService.GetResource("Plugins.Payments.PayPalSmartPaymentButtons.Fields.SecretKey.Required"))
                .When(model => !model.UseSandbox);
        }

        #endregion
    }
}