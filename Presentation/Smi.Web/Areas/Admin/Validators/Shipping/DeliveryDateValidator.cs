using FluentValidation;
using Smi.Core.Domain.Shipping;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Shipping;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Shipping
{
    public partial class DeliveryDateValidator : BaseSmiValidator<DeliveryDateModel>
    {
        public DeliveryDateValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Shipping.DeliveryDates.Fields.Name.Required"));

            SetDatabaseValidationRules<DeliveryDate>(dataProvider);
        }
    }
}