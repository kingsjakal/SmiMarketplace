using FluentValidation;
using Smi.Core.Domain.Orders;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Orders;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Orders
{
    public partial class CheckoutAttributeValidator : BaseSmiValidator<CheckoutAttributeModel>
    {
        public CheckoutAttributeValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Catalog.Attributes.CheckoutAttributes.Fields.Name.Required"));

            SetDatabaseValidationRules<CheckoutAttribute>(dataProvider);
        }
    }
}