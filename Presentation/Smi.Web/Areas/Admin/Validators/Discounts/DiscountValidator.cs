using FluentValidation;
using Smi.Core.Domain.Discounts;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Discounts;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Discounts
{
    public partial class DiscountValidator : BaseSmiValidator<DiscountModel>
    {
        public DiscountValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Promotions.Discounts.Fields.Name.Required"));

            SetDatabaseValidationRules<Discount>(dataProvider);
        }
    }
}