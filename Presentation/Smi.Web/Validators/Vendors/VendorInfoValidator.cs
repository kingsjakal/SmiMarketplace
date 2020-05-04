using FluentValidation;
using Smi.Services.Localization;
using Smi.Web.Framework.Validators;
using Smi.Web.Models.Vendors;

namespace Smi.Web.Validators.Vendors
{
    public partial class VendorInfoValidator : BaseSmiValidator<VendorInfoModel>
    {
        public VendorInfoValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Account.VendorInfo.Name.Required"));

            RuleFor(x => x.Email).NotEmpty().WithMessage(localizationService.GetResource("Account.VendorInfo.Email.Required"));
            RuleFor(x => x.Email).EmailAddress().WithMessage(localizationService.GetResource("Common.WrongEmail"));
        }
    }
}