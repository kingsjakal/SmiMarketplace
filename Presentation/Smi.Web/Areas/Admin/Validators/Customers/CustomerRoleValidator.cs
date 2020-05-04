using FluentValidation;
using Smi.Core.Domain.Customers;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Customers;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Customers
{
    public partial class CustomerRoleValidator : BaseSmiValidator<CustomerRoleModel>
    {
        public CustomerRoleValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Customers.CustomerRoles.Fields.Name.Required"));

            SetDatabaseValidationRules<CustomerRole>(dataProvider);
        }
    }
}