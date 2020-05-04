using FluentValidation;
using Smi.Core.Domain.Orders;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Orders;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Orders
{
    public partial class CheckoutAttributeValueValidator : BaseSmiValidator<CheckoutAttributeValueModel>
    {
        public CheckoutAttributeValueValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Catalog.Attributes.CheckoutAttributes.Values.Fields.Name.Required"));

            SetDatabaseValidationRules<CheckoutAttributeValue>(dataProvider);
        }
    }
}