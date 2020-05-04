using FluentValidation;
using Smi.Core.Domain.Catalog;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Services.Seo;
using Smi.Web.Areas.Admin.Models.Catalog;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Catalog
{
    public partial class ManufacturerValidator : BaseSmiValidator<ManufacturerModel>
    {
        public ManufacturerValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Catalog.Manufacturers.Fields.Name.Required"));
            RuleFor(x => x.PageSizeOptions).Must(ValidatorUtilities.PageSizeOptionsValidator).WithMessage(localizationService.GetResource("Admin.Catalog.Manufacturers.Fields.PageSizeOptions.ShouldHaveUniqueItems"));
            RuleFor(x => x.PageSize).Must((x, context) =>
            {
                if (!x.AllowCustomersToSelectPageSize && x.PageSize <= 0)
                    return false;

                return true;
            }).WithMessage(localizationService.GetResource("Admin.Catalog.Manufacturers.Fields.PageSize.Positive"));
            RuleFor(x => x.SeName).Length(0, SmiSeoDefaults.SearchEngineNameLength)
                .WithMessage(string.Format(localizationService.GetResource("Admin.SEO.SeName.MaxLengthValidation"), SmiSeoDefaults.SearchEngineNameLength));

            SetDatabaseValidationRules<Manufacturer>(dataProvider);
        }
    }
}