using FluentValidation;
using Smi.Core.Domain.Directory;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Directory;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Directory
{
    public partial class StateProvinceValidator : BaseSmiValidator<StateProvinceModel>
    {
        public StateProvinceValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Countries.States.Fields.Name.Required"));

            SetDatabaseValidationRules<StateProvince>(dataProvider);
        }
    }
}