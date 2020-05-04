using FluentValidation;
using Smi.Core.Domain.Vendors;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Vendors;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Vendors
{
    public partial class VendorAttributeValueValidator : BaseSmiValidator<VendorAttributeValueModel>
    {
        public VendorAttributeValueValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Vendors.VendorAttributes.Values.Fields.Name.Required"));

            SetDatabaseValidationRules<VendorAttributeValue>(dataProvider);
        }
    }
}