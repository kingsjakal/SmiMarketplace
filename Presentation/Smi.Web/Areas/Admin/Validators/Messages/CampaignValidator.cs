using FluentValidation;
using Smi.Core.Domain.Messages;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Messages;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Messages
{
    public partial class CampaignValidator : BaseSmiValidator<CampaignModel>
    {
        public CampaignValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Promotions.Campaigns.Fields.Name.Required"));

            RuleFor(x => x.Subject).NotEmpty().WithMessage(localizationService.GetResource("Admin.Promotions.Campaigns.Fields.Subject.Required"));

            RuleFor(x => x.Body).NotEmpty().WithMessage(localizationService.GetResource("Admin.Promotions.Campaigns.Fields.Body.Required"));

            SetDatabaseValidationRules<Campaign>(dataProvider);
        }
    }
}