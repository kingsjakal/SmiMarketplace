using FluentValidation;
using Smi.Core.Domain.Catalog;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Templates;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Templates
{
    public partial class CategoryTemplateValidator : BaseSmiValidator<CategoryTemplateModel>
    {
        public CategoryTemplateValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.System.Templates.Category.Name.Required"));
            RuleFor(x => x.ViewPath).NotEmpty().WithMessage(localizationService.GetResource("Admin.System.Templates.Category.ViewPath.Required"));

            SetDatabaseValidationRules<CategoryTemplate>(dataProvider);
        }
    }
}