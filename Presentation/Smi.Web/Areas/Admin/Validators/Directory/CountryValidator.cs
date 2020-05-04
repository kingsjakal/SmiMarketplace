using FluentValidation;
using Smi.Core.Domain.Directory;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Directory;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Directory
{
    public partial class CountryValidator : BaseSmiValidator<CountryModel>
    {
        public CountryValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage(localizationService.GetResource("Admin.Configuration.Countries.Fields.Name.Required"));
            RuleFor(p => p.Name).Length(1, 100);

            RuleFor(x => x.TwoLetterIsoCode)
                .NotEmpty()
                .WithMessage(localizationService.GetResource("Admin.Configuration.Countries.Fields.TwoLetterIsoCode.Required"));
            RuleFor(x => x.TwoLetterIsoCode)
                .Length(2)
                .WithMessage(localizationService.GetResource("Admin.Configuration.Countries.Fields.TwoLetterIsoCode.Length"));

            RuleFor(x => x.ThreeLetterIsoCode)
                .NotEmpty()
                .WithMessage(localizationService.GetResource("Admin.Configuration.Countries.Fields.ThreeLetterIsoCode.Required"));
            RuleFor(x => x.ThreeLetterIsoCode)
                .Length(3)
                .WithMessage(localizationService.GetResource("Admin.Configuration.Countries.Fields.ThreeLetterIsoCode.Length"));

            SetDatabaseValidationRules<Country>(dataProvider);
        }
    }
}