using FluentValidation;
using Smi.Services.Localization;
using Smi.Web.Framework.Validators;
using Smi.Web.Models.Boards;

namespace Smi.Web.Validators.Boards
{
    public partial class EditForumPostValidator : BaseSmiValidator<EditForumPostModel>
    {
        public EditForumPostValidator(ILocalizationService localizationService)
        {            
            RuleFor(x => x.Text).NotEmpty().WithMessage(localizationService.GetResource("Forum.TextCannotBeEmpty"));
        }
    }
}