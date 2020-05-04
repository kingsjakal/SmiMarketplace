using FluentValidation;
using Smi.Core.Domain.Configuration;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Settings;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Settings
{
    public partial class SettingValidator : BaseSmiValidator<SettingModel>
    {
        public SettingValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Settings.AllSettings.Fields.Name.Required"));

            SetDatabaseValidationRules<Setting>(dataProvider);
        }
    }
}