using FluentValidation;
using Smi.Core.Domain.Stores;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Stores;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Stores
{
    public partial class StoreValidator : BaseSmiValidator<StoreModel>
    {
        public StoreValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Stores.Fields.Name.Required"));
            RuleFor(x => x.Url).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Stores.Fields.Url.Required"));

            SetDatabaseValidationRules<Store>(dataProvider);
        }
    }
}