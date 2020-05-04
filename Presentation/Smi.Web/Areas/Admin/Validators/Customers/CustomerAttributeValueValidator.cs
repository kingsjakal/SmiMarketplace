using FluentValidation;
using Smi.Core.Domain.Customers;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Customers;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Customers
{
    public partial class CustomerAttributeValueValidator : BaseSmiValidator<CustomerAttributeValueModel>
    {
        public CustomerAttributeValueValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Customers.CustomerAttributes.Values.Fields.Name.Required"));

            SetDatabaseValidationRules<CustomerAttributeValue>(dataProvider);
        }
    }
}