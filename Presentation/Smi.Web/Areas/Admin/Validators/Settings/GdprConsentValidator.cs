using FluentValidation;
using Smi.Core.Domain.Gdpr;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Settings;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Settings
{
    public partial class GdprConsentValidator : BaseSmiValidator<GdprConsentModel>
    {
        public GdprConsentValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Message).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Settings.Gdpr.Consent.Message.Required"));
            RuleFor(x => x.RequiredMessage)
                .NotEmpty()
                .WithMessage(localizationService.GetResource("Admin.Configuration.Settings.Gdpr.Consent.RequiredMessage.Required"))
                .When(x => x.IsRequired);

            SetDatabaseValidationRules<GdprConsent>(dataProvider);
        }
    }
}