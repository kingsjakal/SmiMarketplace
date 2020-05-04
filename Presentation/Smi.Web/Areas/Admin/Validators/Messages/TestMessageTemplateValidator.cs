using FluentValidation;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Messages;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Messages
{
    public partial class TestMessageTemplateValidator : BaseSmiValidator<TestMessageTemplateModel>
    {
        public TestMessageTemplateValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.SendTo).NotEmpty();
            RuleFor(x => x.SendTo).EmailAddress().WithMessage(localizationService.GetResource("Admin.Common.WrongEmail"));
        }
    }
}