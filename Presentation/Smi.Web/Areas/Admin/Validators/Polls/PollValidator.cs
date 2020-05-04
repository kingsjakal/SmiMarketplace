using FluentValidation;
using Smi.Core.Domain.Polls;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Polls;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Polls
{
    public partial class PollValidator : BaseSmiValidator<PollModel>
    {
        public PollValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.ContentManagement.Polls.Fields.Name.Required"));

            SetDatabaseValidationRules<Poll>(dataProvider);
        }
    }
}