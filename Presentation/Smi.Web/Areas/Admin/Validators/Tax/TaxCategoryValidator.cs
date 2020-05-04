using FluentValidation;
using Smi.Core.Domain.Tax;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Tax;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Tax
{
    public partial class TaxCategoryValidator : BaseSmiValidator<TaxCategoryModel>
    {
        public TaxCategoryValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Tax.Categories.Fields.Name.Required"));

            SetDatabaseValidationRules<TaxCategory>(dataProvider);
        }
    }
}