using FluentValidation;
using Smi.Services.Localization;
using Smi.Web.Framework.Validators;
using Smi.Web.Models.Catalog;

namespace Smi.Web.Validators.Catalog
{
    public partial class ProductEmailAFriendValidator : BaseSmiValidator<ProductEmailAFriendModel>
    {
        public ProductEmailAFriendValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.FriendEmail).NotEmpty().WithMessage(localizationService.GetResource("Products.EmailAFriend.FriendEmail.Required"));
            RuleFor(x => x.FriendEmail).EmailAddress().WithMessage(localizationService.GetResource("Common.WrongEmail"));

            RuleFor(x => x.YourEmailAddress).NotEmpty().WithMessage(localizationService.GetResource("Products.EmailAFriend.YourEmailAddress.Required"));
            RuleFor(x => x.YourEmailAddress).EmailAddress().WithMessage(localizationService.GetResource("Common.WrongEmail"));
        }}
}