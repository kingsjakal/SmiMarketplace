using FluentValidation;
using Smi.Core.Domain.Catalog;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Catalog;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Catalog
{
    public partial class ProductTagValidator : BaseSmiValidator<ProductTagModel>
    {
        public ProductTagValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Catalog.ProductTags.Fields.Name.Required"));

            SetDatabaseValidationRules<ProductTag>(dataProvider);
        }
    }
}