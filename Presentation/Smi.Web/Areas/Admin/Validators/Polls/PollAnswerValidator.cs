using FluentValidation;
using Smi.Core.Domain.Polls;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Polls;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Polls
{
    public partial class PollAnswerValidator : BaseSmiValidator<PollAnswerModel>
    {
        public PollAnswerValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            //if validation without this set rule is applied, in this case nothing will be validated
            //it's used to prevent auto-validation of child models
            RuleSet(SmiValidatorDefaults.ValidationRuleSet, () =>
            {
                RuleFor(model => model.Name)
                    .NotEmpty()
                    .WithMessage(localizationService.GetResource("Admin.ContentManagement.Polls.Answers.Fields.Name.Required"));

                SetDatabaseValidationRules<PollAnswer>(dataProvider);
            });
        }
    }
}