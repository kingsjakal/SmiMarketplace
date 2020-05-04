using FluentValidation;
using Smi.Core.Domain.Orders;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Orders;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Orders
{
    public partial class ReturnRequestValidator : BaseSmiValidator<ReturnRequestModel>
    {
        public ReturnRequestValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.ReasonForReturn).NotEmpty().WithMessage(localizationService.GetResource("Admin.ReturnRequests.Fields.ReasonForReturn.Required"));
            RuleFor(x => x.RequestedAction).NotEmpty().WithMessage(localizationService.GetResource("Admin.ReturnRequests.Fields.RequestedAction.Required"));

            SetDatabaseValidationRules<ReturnRequest>(dataProvider);
        }
    }
}