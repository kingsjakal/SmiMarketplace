using FluentValidation;
using Smi.Core.Domain.Customers;
using Smi.Services.Localization;
using Smi.Web.Framework.Validators;
using Smi.Web.Models.Customer;

namespace Smi.Web.Validators.Customer
{
    public partial class LoginValidator : BaseSmiValidator<LoginModel>
    {
        public LoginValidator(ILocalizationService localizationService, CustomerSettings customerSettings)
        {
            if (!customerSettings.UsernamesEnabled)
            {
                //login by email
                RuleFor(x => x.Email).NotEmpty().WithMessage(localizationService.GetResource("Account.Login.Fields.Email.Required"));
                RuleFor(x => x.Email).EmailAddress().WithMessage(localizationService.GetResource("Common.WrongEmail"));
            }
        }
    }
}