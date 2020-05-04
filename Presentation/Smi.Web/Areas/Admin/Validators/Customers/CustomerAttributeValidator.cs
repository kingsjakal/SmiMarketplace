using FluentValidation;
using Smi.Core.Domain.Customers;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Customers;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Customers
{
    public partial class CustomerAttributeValidator : BaseSmiValidator<CustomerAttributeModel>
    {
        public CustomerAttributeValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Customers.CustomerAttributes.Fields.Name.Required"));

            SetDatabaseValidationRules<CustomerAttribute>(dataProvider);
        }
    }
}