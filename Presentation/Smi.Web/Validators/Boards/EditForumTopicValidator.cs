using FluentValidation;
using Smi.Services.Localization;
using Smi.Web.Framework.Validators;
using Smi.Web.Models.Boards;

namespace Smi.Web.Validators.Boards
{
    public partial class EditForumTopicValidator : BaseSmiValidator<EditForumTopicModel>
    {
        public EditForumTopicValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Subject).NotEmpty().WithMessage(localizationService.GetResource("Forum.TopicSubjectCannotBeEmpty"));
            RuleFor(x => x.Text).NotEmpty().WithMessage(localizationService.GetResource("Forum.TextCannotBeEmpty"));
        }
    }
}