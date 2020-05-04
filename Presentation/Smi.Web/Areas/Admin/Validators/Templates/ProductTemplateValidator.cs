using FluentValidation;
using Smi.Core.Domain.Catalog;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Templates;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Templates
{
    public partial class ProductTemplateValidator : BaseSmiValidator<ProductTemplateModel>
    {
        public ProductTemplateValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.System.Templates.Product.Name.Required"));
            RuleFor(x => x.ViewPath).NotEmpty().WithMessage(localizationService.GetResource("Admin.System.Templates.Product.ViewPath.Required"));

            SetDatabaseValidationRules<ProductTemplate>(dataProvider);
        }
    }
}