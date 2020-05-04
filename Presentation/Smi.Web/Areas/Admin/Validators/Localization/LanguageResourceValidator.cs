using FluentValidation;
using Smi.Core.Domain.Localization;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Localization;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Localization
{
    public partial class LanguageResourceValidator : BaseSmiValidator<LocaleResourceModel>
    {
        public LanguageResourceValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            //if validation without this set rule is applied, in this case nothing will be validated
            //it's used to prevent auto-validation of child models
            RuleSet(SmiValidatorDefaults.ValidationRuleSet, () =>
            {
                RuleFor(model => model.ResourceName)
                    .NotEmpty()
                    .WithMessage(localizationService.GetResource("Admin.Configuration.Languages.Resources.Fields.Name.Required"));

                RuleFor(model => model.ResourceValue)
                    .NotEmpty()
                    .WithMessage(localizationService.GetResource("Admin.Configuration.Languages.Resources.Fields.Value.Required"));

                SetDatabaseValidationRules<LocaleStringResource>(dataProvider);
            });
        }
    }
}