using FluentValidation;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Catalog;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Catalog
{
    public partial class PredefinedProductAttributeValueModelValidator : BaseSmiValidator<PredefinedProductAttributeValueModel>
    {
        public PredefinedProductAttributeValueModelValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage(localizationService.GetResource("Admin.Catalog.Attributes.ProductAttributes.PredefinedValues.Fields.Name.Required"));
        }
    }
}