using FluentValidation;
using Smi.Core.Domain.Tasks;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Tasks;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Tasks
{
    public partial class ScheduleTaskValidator : BaseSmiValidator<ScheduleTaskModel>
    {
        public ScheduleTaskValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.System.ScheduleTasks.Name.Required"));
            RuleFor(x => x.Seconds).GreaterThan(0).WithMessage(localizationService.GetResource("Admin.System.ScheduleTasks.Seconds.Positive"));

            SetDatabaseValidationRules<ScheduleTask>(dataProvider);
        }
    }
}