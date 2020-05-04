using FluentValidation;
using Smi.Core.Domain.Directory;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Directory;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Directory
{
    public partial class MeasureWeightValidator : BaseSmiValidator<MeasureWeightModel>
    {
        public MeasureWeightValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Shipping.Measures.Weights.Fields.Name.Required"));
            RuleFor(x => x.SystemKeyword).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Shipping.Measures.Weights.Fields.SystemKeyword.Required"));

            SetDatabaseValidationRules<MeasureWeight>(dataProvider);
        }
    }
}