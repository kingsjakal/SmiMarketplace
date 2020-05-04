using FluentValidation;
using Smi.Services.Localization;
using Smi.Web.Framework.Validators;
using Smi.Web.Models.Customer;

namespace Smi.Web.Validators.Customer
{
    public partial class GiftCardValidator : BaseSmiValidator<CheckGiftCardBalanceModel>
    {
        public GiftCardValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.GiftCardCode).NotEmpty().WithMessage(localizationService.GetResource("CheckGiftCardBalance.GiftCardCouponCode.Empty"));            
        }
    }
}
