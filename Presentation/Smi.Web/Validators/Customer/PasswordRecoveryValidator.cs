using FluentValidation;
using Smi.Services.Localization;
using Smi.Web.Framework.Validators;
using Smi.Web.Models.Customer;

namespace Smi.Web.Validators.Customer
{
    public partial class PasswordRecoveryValidator : BaseSmiValidator<PasswordRecoveryModel>
    {
        public PasswordRecoveryValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage(localizationService.GetResource("Account.PasswordRecovery.Email.Required"));
            RuleFor(x => x.Email).EmailAddress().WithMessage(localizationService.GetResource("Common.WrongEmail"));
        }
    }
}