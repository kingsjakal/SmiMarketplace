using FluentValidation;
using Smi.Core.Domain.Catalog;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Catalog;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Catalog
{
    public partial class SpecificationAttributeValidator : BaseSmiValidator<SpecificationAttributeModel>
    {
        public SpecificationAttributeValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Catalog.Attributes.SpecificationAttributes.Fields.Name.Required"));

            SetDatabaseValidationRules<SpecificationAttribute>(dataProvider);
        }
    }
}