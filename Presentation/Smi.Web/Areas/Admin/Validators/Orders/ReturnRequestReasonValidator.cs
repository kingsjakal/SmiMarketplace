using FluentValidation;
using Smi.Core.Domain.Orders;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Orders;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Orders
{
    public partial class ReturnRequestReasonValidator : BaseSmiValidator<ReturnRequestReasonModel>
    {
        public ReturnRequestReasonValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Settings.Order.ReturnRequestReasons.Name.Required"));

            SetDatabaseValidationRules<ReturnRequestReason>(dataProvider);
        }
    }
}