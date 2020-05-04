using FluentValidation;
using Smi.Core.Domain.Messages;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Messages;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Messages
{
    public partial class NewsLetterSubscriptionValidator : BaseSmiValidator<NewsletterSubscriptionModel>
    {
        public NewsLetterSubscriptionValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage(localizationService.GetResource("Admin.Promotions.NewsLetterSubscriptions.Fields.Email.Required"));
            RuleFor(x => x.Email).EmailAddress().WithMessage(localizationService.GetResource("Admin.Common.WrongEmail"));

            SetDatabaseValidationRules<NewsLetterSubscription>(dataProvider);
        }
    }
}