using FluentValidation;
using Smi.Core.Domain.Vendors;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Vendors;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Vendors
{
    public partial class VendorAttributeValidator : BaseSmiValidator<VendorAttributeModel>
    {
        public VendorAttributeValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Vendors.VendorAttributes.Fields.Name.Required"));

            SetDatabaseValidationRules<VendorAttribute>(dataProvider);
        }
    }
}