using FluentValidation;
using Smi.Core.Domain.Catalog;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Catalog;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Catalog
{
    /// <summary>
    /// Represent a review type validator
    /// </summary>
    public partial class ReviewTypeValidator : BaseSmiValidator<ReviewTypeModel>
    {
        public ReviewTypeValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Settings.ReviewType.Fields.Name.Required"));
            RuleFor(x => x.Description).NotEmpty().WithMessage(localizationService.GetResource("Admin.Settings.ReviewType.Fields.Description.Required"));

            SetDatabaseValidationRules<ReviewType>(dataProvider);
        }
    }
}
