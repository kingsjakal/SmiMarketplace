using FluentValidation;
using Smi.Core.Domain.Orders;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Orders;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Orders
{
    public partial class ReturnRequestActionValidator : BaseSmiValidator<ReturnRequestActionModel>
    {
        public ReturnRequestActionValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Settings.Order.ReturnRequestActions.Name.Required"));

            SetDatabaseValidationRules<ReturnRequestAction>(dataProvider);
        }
    }
}