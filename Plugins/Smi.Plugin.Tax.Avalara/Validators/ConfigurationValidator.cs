using FluentValidation;
using Smi.Plugin.Tax.Avalara.Models.Configuration;
using Smi.Services.Localization;
using Smi.Web.Framework.Validators;

namespace Smi.Plugin.Tax.Avalara.Validators
{
    /// <summary>
    /// Represents configuration model validator
    /// </summary>
    public class ConfigurationValidator : BaseSmiValidator<ConfigurationModel>
    {
        #region Ctor

        public ConfigurationValidator(ILocalizationService localizationService)
        {
            RuleFor(model => model.AccountId)
                .NotEmpty()
                .WithMessage(localizationService.GetResource("Plugins.Tax.Avalara.Fields.AccountId.Required"));
            RuleFor(model => model.LicenseKey)
                .NotEmpty()
                .WithMessage(localizationService.GetResource("Plugins.Tax.Avalara.Fields.LicenseKey.Required"));
        }

        #endregion
    }
}