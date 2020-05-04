using FluentValidation;
using Smi.Core.Domain.Vendors;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Services.Seo;
using Smi.Web.Areas.Admin.Models.Vendors;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Vendors
{
    public partial class VendorValidator : BaseSmiValidator<VendorModel>
    {
        public VendorValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Vendors.Fields.Name.Required"));

            RuleFor(x => x.Email).NotEmpty().WithMessage(localizationService.GetResource("Admin.Vendors.Fields.Email.Required"));
            RuleFor(x => x.Email).EmailAddress().WithMessage(localizationService.GetResource("Admin.Common.WrongEmail"));
            RuleFor(x => x.PageSizeOptions).Must(ValidatorUtilities.PageSizeOptionsValidator).WithMessage(localizationService.GetResource("Admin.Vendors.Fields.PageSizeOptions.ShouldHaveUniqueItems"));
            RuleFor(x => x.PageSize).Must((x, context) =>
            {
                if (!x.AllowCustomersToSelectPageSize && x.PageSize <= 0)
                    return false;

                return true;
            }).WithMessage(localizationService.GetResource("Admin.Vendors.Fields.PageSize.Positive"));
            RuleFor(x => x.SeName).Length(0, SmiSeoDefaults.SearchEngineNameLength)
                .WithMessage(string.Format(localizationService.GetResource("Admin.SEO.SeName.MaxLengthValidation"), SmiSeoDefaults.SearchEngineNameLength));

            SetDatabaseValidationRules<Vendor>(dataProvider);
        }
    }
}