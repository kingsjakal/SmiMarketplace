using FluentValidation;
using Smi.Core.Domain.Customers;
using Smi.Services.Localization;
using Smi.Web.Framework.Validators;
using Smi.Web.Models.Customer;

namespace Smi.Web.Validators.Customer
{
    public partial class PasswordRecoveryConfirmValidator : BaseSmiValidator<PasswordRecoveryConfirmModel>
    {
        public PasswordRecoveryConfirmValidator(ILocalizationService localizationService, CustomerSettings customerSettings)
        {
            RuleFor(x => x.NewPassword).IsPassword(localizationService, customerSettings);            
            RuleFor(x => x.ConfirmNewPassword).NotEmpty().WithMessage(localizationService.GetResource("Account.PasswordRecovery.ConfirmNewPassword.Required"));
            RuleFor(x => x.ConfirmNewPassword).Equal(x => x.NewPassword).WithMessage(localizationService.GetResource("Account.PasswordRecovery.NewPassword.EnteredPasswordsDoNotMatch"));
        }
    }
}